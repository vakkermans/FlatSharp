﻿/*
 * Copyright 2020 James Courtney
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace FlatSharpTests.Compiler
{
    using System;
    using System.Linq;
    using System.Reflection;
    using FlatSharp;
    using FlatSharp.Compiler;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AccessModifierTests
    {
        [TestMethod]
        public void TestAccessModifierCombinations()
        {
            foreach (SetterKind setterKind in Enum.GetValues(typeof(SetterKind)))
            {
                foreach (FlatBufferDeserializationOption option in Enum.GetValues(typeof(FlatBufferDeserializationOption)))
                {
                    this.Test(setterKind, option);
                }
            }
        }

        private void Test(SetterKind setterKind, FlatBufferDeserializationOption option)
        {
            string schema = $@"
            namespace VirtualTests;
            table VirtualTable (PrecompiledSerializer:""{option}"") {{
                Default:int (setter:""{setterKind}"");
                ForcedVirtual:int (virtual:""true"", setter:""{setterKind}"");
                ForcedNonVirtual:int (virtual:""false"", setter:""{(setterKind != SetterKind.None ? setterKind : SetterKind.Public)}"");
                Struct:VirtualStruct;
            }}

            struct VirtualStruct {{
                Default:int (setter:""{setterKind}"");
                ForcedVirtual:int (virtual:""true"", setter:""{setterKind}"");
                ForcedNonVirtual:int (virtual:""false"", setter:""{(setterKind != SetterKind.None ? setterKind : SetterKind.Public)}"");
            }}";

            Assembly asm = FlatSharpCompiler.CompileAndLoadAssembly(schema);

            foreach (var typeName in new[] { "VirtualTests.VirtualTable", "VirtualTests.VirtualStruct" })
            {
                Type type = asm.GetType(typeName);
                Assert.IsTrue(type.IsPublic);
                var defaultProperty = type.GetProperty("Default");
                var forcedVirtualProperty = type.GetProperty("ForcedVirtual");
                var forcedNonVirtualProperty = type.GetProperty("ForcedNonVirtual");

                Assert.IsNotNull(defaultProperty);
                Assert.IsNotNull(forcedVirtualProperty);
                Assert.IsNotNull(forcedNonVirtualProperty);

                Assert.IsTrue(defaultProperty.GetMethod.IsPublic);
                Assert.IsTrue(forcedVirtualProperty.GetMethod.IsPublic);
                Assert.IsTrue(forcedNonVirtualProperty.GetMethod.IsPublic);

                if (setterKind == SetterKind.None)
                {
                    Assert.IsNull(defaultProperty.SetMethod);
                    Assert.IsNull(forcedVirtualProperty.SetMethod);
                    Assert.IsNotNull(forcedNonVirtualProperty.SetMethod); // non-virtual can't have null setters.
                }
                else if (setterKind == SetterKind.Protected)
                {
                    Assert.IsTrue(defaultProperty.SetMethod.IsFamily);
                    Assert.IsTrue(forcedVirtualProperty.SetMethod.IsFamily);
                    Assert.IsTrue(forcedNonVirtualProperty.SetMethod.IsFamily);
                }
                else if (setterKind == SetterKind.ProtectedInternal)
                {
                    Assert.IsTrue(defaultProperty.SetMethod.IsFamilyOrAssembly);
                    Assert.IsTrue(forcedVirtualProperty.SetMethod.IsFamilyOrAssembly);
                    Assert.IsTrue(forcedNonVirtualProperty.SetMethod.IsFamilyOrAssembly);
                }
                else if (setterKind == SetterKind.Public)
                {
                    Assert.IsTrue(defaultProperty.SetMethod.IsPublic);
                    Assert.IsTrue(forcedVirtualProperty.SetMethod.IsPublic);
                    Assert.IsTrue(forcedNonVirtualProperty.SetMethod.IsPublic);
                }
                else
                {
                    Assert.Fail();
                }
            }
        }
    }
}
