``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.14393.3930 (1607/AnniversaryUpdate/Redstone1), VM=Hyper-V
Intel Xeon CPU E5-2667 v3 3.20GHz, 1 CPU, 8 logical and 8 physical cores
  [Host]                  : .NET Framework 4.8 (4.8.4240.0), X64 RyuJIT
  MediumRun-.NET 4.7      : .NET Framework 4.8 (4.8.4240.0), X64 RyuJIT
  MediumRun-.NET Core 2.1 : .NET Core 2.1.22 (CoreCLR 4.6.29220.03, CoreFX 4.6.29220.01), X64 RyuJIT
  MediumRun-.NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  MediumRun-.NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT

IterationCount=15  LaunchCount=2  WarmupCount=10  

```
|                            Method |                     Job |       Runtime | TraversalCount |  DeserializeOption | VectorLength |        Mean |     Error |      StdDev |      Median |
|---------------------------------- |------------------------ |-------------- |--------------- |------------------- |------------- |------------:|----------:|------------:|------------:|
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |               **Lazy** |            **3** |  **1,975.7 ns** |  **16.56 ns** |    **24.78 ns** |  **1,970.7 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |               Lazy |            3 |  1,457.8 ns |  15.83 ns |    22.70 ns |  1,458.9 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |               Lazy |            3 |    866.5 ns |   5.92 ns |     8.29 ns |    866.3 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |               Lazy |            3 |    703.1 ns |   6.85 ns |    10.04 ns |    705.0 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |               Lazy |            3 |    898.4 ns |   4.93 ns |     7.38 ns |    896.6 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |               Lazy |            3 |    717.3 ns |   6.33 ns |     9.08 ns |    716.7 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |               Lazy |            3 |    895.4 ns |   8.01 ns |    11.23 ns |    894.6 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |               Lazy |            3 |    725.2 ns |   3.92 ns |     5.75 ns |    725.0 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |               **Lazy** |           **30** | **15,318.6 ns** | **111.88 ns** |   **167.46 ns** | **15,287.5 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |               Lazy |           30 | 10,220.7 ns |  93.89 ns |   140.53 ns | 10,204.8 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |               Lazy |           30 |  6,542.3 ns |  43.43 ns |    63.66 ns |  6,536.4 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |               Lazy |           30 |  4,878.2 ns |  61.77 ns |    90.54 ns |  4,861.5 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |               Lazy |           30 |  6,821.0 ns |  62.53 ns |    93.60 ns |  6,802.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |               Lazy |           30 |  5,057.2 ns |  34.97 ns |    51.27 ns |  5,045.5 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |               Lazy |           30 |  6,802.7 ns |  56.96 ns |    85.26 ns |  6,775.9 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |               Lazy |           30 |  5,010.5 ns |  81.18 ns |   116.42 ns |  4,976.1 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |      **PropertyCache** |            **3** |  **2,101.6 ns** |  **19.04 ns** |    **28.50 ns** |  **2,098.8 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |      PropertyCache |            3 |  1,582.0 ns |  12.74 ns |    19.07 ns |  1,582.4 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      PropertyCache |            3 |    972.4 ns |  10.10 ns |    15.11 ns |    973.2 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      PropertyCache |            3 |    744.8 ns |  25.88 ns |    38.74 ns |    763.1 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      PropertyCache |            3 |    983.7 ns |   9.83 ns |    14.10 ns |    981.3 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      PropertyCache |            3 |    785.3 ns |   5.43 ns |     7.43 ns |    783.1 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      PropertyCache |            3 |    983.8 ns |   7.74 ns |    11.34 ns |    981.9 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      PropertyCache |            3 |    797.2 ns |   7.46 ns |    10.94 ns |    797.6 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |      **PropertyCache** |           **30** | **16,223.0 ns** | **143.09 ns** |   **209.74 ns** | **16,202.2 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |      PropertyCache |           30 | 10,673.8 ns | 201.50 ns |   295.35 ns | 10,750.1 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      PropertyCache |           30 |  7,155.2 ns | 129.67 ns |   194.09 ns |  7,199.9 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      PropertyCache |           30 |  5,137.1 ns | 204.06 ns |   305.42 ns |  5,231.0 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      PropertyCache |           30 |  7,612.5 ns |  55.84 ns |    78.28 ns |  7,600.1 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      PropertyCache |           30 |  5,447.3 ns |  47.32 ns |    67.86 ns |  5,454.7 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      PropertyCache |           30 |  7,550.3 ns |  60.78 ns |    89.09 ns |  7,526.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      PropertyCache |           30 |  5,501.0 ns |  43.39 ns |    63.60 ns |  5,481.8 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |        **VectorCache** |            **3** |  **2,167.2 ns** |  **21.45 ns** |    **30.76 ns** |  **2,174.2 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |        VectorCache |            3 |  1,613.5 ns |  21.27 ns |    31.17 ns |  1,615.6 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |        VectorCache |            3 |  1,029.8 ns |  15.83 ns |    23.69 ns |  1,029.4 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |        VectorCache |            3 |    827.8 ns |  21.07 ns |    31.54 ns |    831.9 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |        VectorCache |            3 |  1,096.5 ns |   9.54 ns |    14.28 ns |  1,095.7 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |        VectorCache |            3 |    904.9 ns |  12.73 ns |    18.66 ns |    898.9 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |        VectorCache |            3 |  1,097.3 ns |  17.62 ns |    25.82 ns |  1,084.1 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |        VectorCache |            3 |    912.1 ns |   6.19 ns |     9.26 ns |    912.1 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |        **VectorCache** |           **30** | **16,996.7 ns** | **116.37 ns** |   **163.14 ns** | **17,023.6 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |        VectorCache |           30 | 11,350.1 ns | 131.65 ns |   192.98 ns | 11,362.6 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |        VectorCache |           30 |  7,671.1 ns |  99.99 ns |   146.56 ns |  7,644.3 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |        VectorCache |           30 |  5,718.2 ns |  86.62 ns |   129.65 ns |  5,756.8 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |        VectorCache |           30 |  8,175.2 ns |  58.20 ns |    83.47 ns |  8,188.1 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |        VectorCache |           30 |  6,159.2 ns |  62.36 ns |    89.44 ns |  6,181.4 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |        VectorCache |           30 |  8,153.6 ns |  61.28 ns |    91.72 ns |  8,147.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |        VectorCache |           30 |  6,409.5 ns |  36.76 ns |    51.54 ns |  6,419.4 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** | **VectorCacheMutable** |            **3** |  **2,134.3 ns** |  **17.62 ns** |    **24.70 ns** |  **2,140.1 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 | VectorCacheMutable |            3 |  1,613.4 ns |  13.39 ns |    18.77 ns |  1,617.8 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 | VectorCacheMutable |            3 |  1,046.1 ns |   9.57 ns |    13.41 ns |  1,045.1 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 | VectorCacheMutable |            3 |    808.2 ns |   6.64 ns |     9.74 ns |    807.6 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 | VectorCacheMutable |            3 |  1,066.9 ns |  10.16 ns |    14.90 ns |  1,069.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 | VectorCacheMutable |            3 |    866.5 ns |   8.99 ns |    13.18 ns |    861.7 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 | VectorCacheMutable |            3 |  1,081.5 ns |  13.80 ns |    18.89 ns |  1,086.7 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 | VectorCacheMutable |            3 |    887.0 ns |   7.15 ns |    10.49 ns |    887.4 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** | **VectorCacheMutable** |           **30** | **16,780.3 ns** |  **91.88 ns** |   **134.68 ns** | **16,775.4 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 | VectorCacheMutable |           30 | 11,436.9 ns | 124.20 ns |   185.89 ns | 11,411.8 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 | VectorCacheMutable |           30 |  7,760.3 ns |  87.26 ns |   125.14 ns |  7,777.0 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 | VectorCacheMutable |           30 |  5,693.1 ns | 100.95 ns |   151.09 ns |  5,681.5 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 | VectorCacheMutable |           30 |  8,143.6 ns |  71.46 ns |   102.49 ns |  8,118.4 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 | VectorCacheMutable |           30 |  6,173.5 ns |  66.41 ns |    97.35 ns |  6,194.4 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 | VectorCacheMutable |           30 |  8,125.8 ns |  99.33 ns |   139.25 ns |  8,161.7 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 | VectorCacheMutable |           30 |  6,178.0 ns |  50.14 ns |    70.29 ns |  6,156.2 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |             **Greedy** |            **3** |  **2,124.3 ns** |  **16.50 ns** |    **24.70 ns** |  **2,124.0 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |             Greedy |            3 |  2,082.1 ns |  17.78 ns |    26.06 ns |  2,073.3 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |             Greedy |            3 |  1,013.4 ns |  11.11 ns |    16.28 ns |  1,016.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |             Greedy |            3 |    984.8 ns |   9.85 ns |    14.44 ns |    990.2 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |             Greedy |            3 |  1,036.8 ns |   6.41 ns |     8.77 ns |  1,041.3 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |             Greedy |            3 |  1,004.9 ns |   8.35 ns |    12.50 ns |  1,003.4 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |             Greedy |            3 |  1,050.9 ns |  10.58 ns |    15.83 ns |  1,044.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |             Greedy |            3 |  1,009.1 ns |   8.75 ns |    12.83 ns |  1,004.8 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |             **Greedy** |           **30** | **16,236.2 ns** | **170.45 ns** |   **244.46 ns** | **16,269.8 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |             Greedy |           30 | 16,100.3 ns | 121.52 ns |   181.89 ns | 16,099.2 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |             Greedy |           30 |  7,264.0 ns |  89.09 ns |   130.58 ns |  7,262.2 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |             Greedy |           30 |  7,010.5 ns |  63.14 ns |    86.43 ns |  7,010.3 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |             Greedy |           30 |  7,672.0 ns |  52.40 ns |    76.81 ns |  7,664.2 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |             Greedy |           30 |  7,382.2 ns |  61.39 ns |    91.89 ns |  7,365.3 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |             Greedy |           30 |  7,510.4 ns |  49.23 ns |    73.69 ns |  7,492.3 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |             Greedy |           30 |  7,256.3 ns |  94.54 ns |   141.50 ns |  7,250.1 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |      **GreedyMutable** |            **3** |  **2,078.2 ns** |  **16.45 ns** |    **24.62 ns** |  **2,074.7 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |      GreedyMutable |            3 |  2,042.9 ns |  15.88 ns |    23.27 ns |  2,039.3 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      GreedyMutable |            3 |    983.5 ns |   7.75 ns |    11.11 ns |    985.7 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      GreedyMutable |            3 |    959.1 ns |  13.27 ns |    19.87 ns |    959.3 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      GreedyMutable |            3 |  1,018.3 ns |   7.74 ns |    11.35 ns |  1,017.7 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      GreedyMutable |            3 |    975.9 ns |   5.53 ns |     8.10 ns |    974.7 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      GreedyMutable |            3 |  1,019.5 ns |   7.58 ns |    11.12 ns |  1,017.3 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      GreedyMutable |            3 |    978.1 ns |   9.64 ns |    13.51 ns |    976.9 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **1** |      **GreedyMutable** |           **30** | **16,237.5 ns** |  **97.75 ns** |   **143.29 ns** | **16,187.3 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              1 |      GreedyMutable |           30 | 15,729.9 ns |  82.93 ns |   116.26 ns | 15,697.2 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      GreedyMutable |           30 |  7,253.4 ns |  86.38 ns |   129.28 ns |  7,247.6 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              1 |      GreedyMutable |           30 |  6,908.2 ns |  90.31 ns |   135.17 ns |  6,929.9 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      GreedyMutable |           30 |  7,566.2 ns |  32.61 ns |    47.81 ns |  7,560.6 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              1 |      GreedyMutable |           30 |  7,250.3 ns |  62.32 ns |    91.35 ns |  7,247.5 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      GreedyMutable |           30 |  7,502.8 ns |  36.43 ns |    52.25 ns |  7,500.0 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              1 |      GreedyMutable |           30 |  7,142.6 ns |  77.61 ns |   116.16 ns |  7,140.5 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |               **Lazy** |            **3** |  **9,693.4 ns** |  **90.37 ns** |   **135.26 ns** |  **9,706.2 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |               Lazy |            3 |  7,030.8 ns |  49.85 ns |    74.61 ns |  7,020.7 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |               Lazy |            3 |  4,108.3 ns |  46.18 ns |    69.12 ns |  4,099.6 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |               Lazy |            3 |  3,111.0 ns |  57.21 ns |    85.62 ns |  3,121.5 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |               Lazy |            3 |  4,180.7 ns |  22.13 ns |    31.73 ns |  4,177.6 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |               Lazy |            3 |  3,298.4 ns |  20.21 ns |    29.62 ns |  3,295.6 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |               Lazy |            3 |  4,283.1 ns |  35.08 ns |    50.32 ns |  4,274.0 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |               Lazy |            3 |  3,309.2 ns |  27.04 ns |    40.47 ns |  3,303.6 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |               **Lazy** |           **30** | **77,314.5 ns** | **548.23 ns** |   **803.59 ns** | **77,184.7 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |               Lazy |           30 | 51,679.6 ns | 251.90 ns |   369.24 ns | 51,586.8 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |               Lazy |           30 | 32,175.3 ns | 213.58 ns |   306.31 ns | 32,186.6 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |               Lazy |           30 | 22,265.1 ns | 320.48 ns |   459.62 ns | 22,362.6 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |               Lazy |           30 | 33,469.6 ns | 258.87 ns |   371.27 ns | 33,509.2 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |               Lazy |           30 | 24,551.1 ns | 319.79 ns |   468.74 ns | 24,499.3 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |               Lazy |           30 | 33,340.3 ns | 218.51 ns |   306.32 ns | 33,414.2 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |               Lazy |           30 | 24,365.3 ns | 226.66 ns |   339.25 ns | 24,460.9 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |      **PropertyCache** |            **3** |  **8,851.9 ns** |  **37.51 ns** |    **56.14 ns** |  **8,841.5 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |      PropertyCache |            3 |  6,097.2 ns |  62.42 ns |    91.49 ns |  6,114.1 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      PropertyCache |            3 |  3,910.6 ns |  49.54 ns |    74.15 ns |  3,924.2 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      PropertyCache |            3 |  2,702.9 ns |  33.36 ns |    49.93 ns |  2,714.2 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      PropertyCache |            3 |  4,081.3 ns |  42.02 ns |    60.27 ns |  4,086.9 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      PropertyCache |            3 |  3,050.4 ns |  28.17 ns |    41.29 ns |  3,062.7 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      PropertyCache |            3 |  4,054.4 ns |  51.23 ns |    76.67 ns |  4,059.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      PropertyCache |            3 |  3,001.2 ns |  55.08 ns |    82.45 ns |  3,016.5 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |      **PropertyCache** |           **30** | **78,818.5 ns** | **561.45 ns** |   **840.35 ns** | **78,770.1 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |      PropertyCache |           30 | 52,594.3 ns | 506.81 ns |   758.57 ns | 52,731.5 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      PropertyCache |           30 | 35,598.9 ns | 841.99 ns | 1,260.25 ns | 36,222.0 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      PropertyCache |           30 | 24,964.2 ns | 646.60 ns |   967.80 ns | 25,193.2 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      PropertyCache |           30 | 37,317.3 ns | 484.48 ns |   725.15 ns | 37,175.0 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      PropertyCache |           30 | 26,776.8 ns | 203.93 ns |   298.92 ns | 26,859.7 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      PropertyCache |           30 | 36,993.3 ns | 479.73 ns |   718.03 ns | 36,956.9 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      PropertyCache |           30 | 25,391.7 ns | 779.55 ns | 1,166.80 ns | 25,163.4 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |        **VectorCache** |            **3** |  **2,594.0 ns** |  **18.75 ns** |    **26.88 ns** |  **2,592.7 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |        VectorCache |            3 |  1,916.4 ns |  14.18 ns |    21.22 ns |  1,910.6 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |        VectorCache |            3 |  1,507.4 ns |   8.59 ns |    12.85 ns |  1,509.4 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |        VectorCache |            3 |  1,132.9 ns |  14.81 ns |    21.70 ns |  1,132.8 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |        VectorCache |            3 |  1,521.2 ns |   9.59 ns |    14.36 ns |  1,521.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |        VectorCache |            3 |  1,142.0 ns |   7.93 ns |    10.85 ns |  1,141.5 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |        VectorCache |            3 |  1,510.3 ns |  12.10 ns |    17.74 ns |  1,508.6 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |        VectorCache |            3 |  1,162.1 ns |  13.15 ns |    19.68 ns |  1,164.7 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |        **VectorCache** |           **30** | **20,751.9 ns** | **231.56 ns** |   **346.59 ns** | **20,700.4 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |        VectorCache |           30 | 14,089.0 ns | 294.08 ns |   431.06 ns | 14,010.9 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |        VectorCache |           30 | 11,777.5 ns |  72.23 ns |   105.87 ns | 11,740.9 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |        VectorCache |           30 |  7,823.6 ns |  66.99 ns |   100.27 ns |  7,822.1 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |        VectorCache |           30 | 11,945.2 ns |  67.01 ns |   100.30 ns | 11,928.0 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |        VectorCache |           30 |  7,931.7 ns |  51.22 ns |    75.08 ns |  7,942.4 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |        VectorCache |           30 | 11,809.9 ns |  70.20 ns |   102.90 ns | 11,782.9 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |        VectorCache |           30 |  7,921.3 ns | 128.88 ns |   192.90 ns |  7,964.8 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** | **VectorCacheMutable** |            **3** |  **2,525.2 ns** |  **13.31 ns** |    **19.91 ns** |  **2,523.1 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 | VectorCacheMutable |            3 |  1,829.5 ns |  12.41 ns |    17.80 ns |  1,829.2 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 | VectorCacheMutable |            3 |  1,414.4 ns |   9.23 ns |    13.82 ns |  1,414.3 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 | VectorCacheMutable |            3 |  1,056.2 ns |  11.46 ns |    16.43 ns |  1,055.6 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 | VectorCacheMutable |            3 |  1,455.9 ns |   8.35 ns |    11.98 ns |  1,456.5 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 | VectorCacheMutable |            3 |  1,076.8 ns |   8.36 ns |    12.52 ns |  1,077.8 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 | VectorCacheMutable |            3 |  1,494.0 ns |   8.88 ns |    13.02 ns |  1,492.2 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 | VectorCacheMutable |            3 |  1,111.4 ns |  10.73 ns |    16.06 ns |  1,116.2 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** | **VectorCacheMutable** |           **30** | **20,030.7 ns** | **127.89 ns** |   **191.42 ns** | **20,099.4 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 | VectorCacheMutable |           30 | 13,084.5 ns |  90.31 ns |   129.53 ns | 13,092.9 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 | VectorCacheMutable |           30 | 11,265.3 ns |  98.89 ns |   148.01 ns | 11,293.7 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 | VectorCacheMutable |           30 |  7,148.2 ns |  98.36 ns |   147.23 ns |  7,145.3 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 | VectorCacheMutable |           30 | 11,433.7 ns |  59.64 ns |    83.60 ns | 11,430.2 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 | VectorCacheMutable |           30 |  7,718.9 ns |  46.02 ns |    66.00 ns |  7,708.4 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 | VectorCacheMutable |           30 | 11,591.5 ns |  71.39 ns |   106.86 ns | 11,574.5 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 | VectorCacheMutable |           30 |  7,690.3 ns | 146.76 ns |   219.67 ns |  7,671.8 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |             **Greedy** |            **3** |  **2,420.3 ns** |  **20.32 ns** |    **30.41 ns** |  **2,414.5 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |             Greedy |            3 |  2,253.7 ns |  16.82 ns |    24.65 ns |  2,255.6 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |             Greedy |            3 |  1,325.9 ns |  10.98 ns |    16.10 ns |  1,328.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |             Greedy |            3 |  1,137.8 ns |  16.67 ns |    24.44 ns |  1,136.5 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |             Greedy |            3 |  1,356.8 ns |  11.82 ns |    16.96 ns |  1,351.4 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |             Greedy |            3 |  1,186.3 ns |  12.64 ns |    17.72 ns |  1,189.0 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |             Greedy |            3 |  1,352.4 ns |   7.08 ns |    10.38 ns |  1,348.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |             Greedy |            3 |  1,202.1 ns |   8.30 ns |    12.17 ns |  1,201.8 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |             **Greedy** |           **30** | **19,107.3 ns** | **153.71 ns** |   **230.06 ns** | **19,115.5 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |             Greedy |           30 | 17,538.9 ns | 110.45 ns |   158.40 ns | 17,528.7 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |             Greedy |           30 | 10,114.5 ns |  70.76 ns |   103.72 ns | 10,122.0 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |             Greedy |           30 |  8,593.1 ns | 122.70 ns |   179.85 ns |  8,601.1 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |             Greedy |           30 | 10,374.7 ns |  47.92 ns |    71.72 ns | 10,362.0 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |             Greedy |           30 |  8,826.3 ns |  80.57 ns |   118.10 ns |  8,821.6 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |             Greedy |           30 | 10,340.0 ns |  96.36 ns |   144.23 ns | 10,286.2 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |             Greedy |           30 |  8,665.4 ns |  66.46 ns |    99.47 ns |  8,691.2 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |      **GreedyMutable** |            **3** |  **2,350.1 ns** |  **20.10 ns** |    **30.09 ns** |  **2,347.5 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |      GreedyMutable |            3 |  2,209.7 ns |  15.08 ns |    22.11 ns |  2,209.3 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      GreedyMutable |            3 |  1,258.1 ns |   8.76 ns |    12.84 ns |  1,257.5 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      GreedyMutable |            3 |  1,102.3 ns |  10.83 ns |    16.21 ns |  1,103.8 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      GreedyMutable |            3 |  1,319.0 ns |  10.16 ns |    15.21 ns |  1,315.1 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      GreedyMutable |            3 |  1,137.0 ns |   8.53 ns |    12.50 ns |  1,134.2 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      GreedyMutable |            3 |  1,274.4 ns |   4.66 ns |     6.68 ns |  1,273.4 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      GreedyMutable |            3 |  1,129.2 ns |   6.94 ns |    10.17 ns |  1,127.5 ns |
|        **FlatSharp_ParseAndTraverse** |      **MediumRun-.NET 4.7** |      **.NET 4.7** |              **5** |      **GreedyMutable** |           **30** | **18,436.6 ns** | **150.02 ns** |   **219.90 ns** | **18,447.6 ns** |
| FlatSharp_ParseAndTraversePartial |      MediumRun-.NET 4.7 |      .NET 4.7 |              5 |      GreedyMutable |           30 | 17,125.1 ns |  91.77 ns |   131.61 ns | 17,122.2 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      GreedyMutable |           30 |  9,735.9 ns |  67.55 ns |    99.02 ns |  9,727.7 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 2.1 | .NET Core 2.1 |              5 |      GreedyMutable |           30 |  8,126.5 ns |  68.00 ns |   101.78 ns |  8,128.4 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      GreedyMutable |           30 |  9,906.4 ns |  72.49 ns |   108.50 ns |  9,875.8 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 3.1 | .NET Core 3.1 |              5 |      GreedyMutable |           30 |  8,387.0 ns |  55.39 ns |    81.19 ns |  8,367.4 ns |
|        FlatSharp_ParseAndTraverse | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      GreedyMutable |           30 |  9,975.4 ns |  72.09 ns |   107.90 ns |  9,930.0 ns |
| FlatSharp_ParseAndTraversePartial | MediumRun-.NET Core 5.0 | .NET Core 5.0 |              5 |      GreedyMutable |           30 |  8,357.5 ns | 152.05 ns |   227.57 ns |  8,411.9 ns |
