``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                                                                            Method |       Array |       Mean |     Error |    StdDev | Rank | Allocated |
|---------------------------------------------------------------------------------- |------------ |-----------:|----------:|----------:|-----:|----------:|
|      **MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLinearDeTempo** | **Int32[1000]** | **335.095 ns** | **6.2280 ns** | **9.3218 ns** |   **10** |         **-** |
| MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLogaritmicaDeTempo | Int32[1000] |  18.086 ns | 0.1031 ns | 0.0861 ns |    6 |         - |
|      **MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLinearDeTempo** |  **Int32[100]** |  **40.429 ns** | **0.2990 ns** | **0.2497 ns** |    **7** |         **-** |
| MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLogaritmicaDeTempo |  Int32[100] |  11.922 ns | 0.0539 ns | 0.0450 ns |    3 |         - |
|      **MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLinearDeTempo** |   **Int32[10]** |   **4.483 ns** | **0.0165 ns** | **0.0147 ns** |    **1** |         **-** |
| MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLogaritmicaDeTempo |   Int32[10] |   6.809 ns | 0.1238 ns | 0.1609 ns |    2 |         - |
|      **MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLinearDeTempo** |  **Int32[200]** |  **72.923 ns** | **1.0175 ns** | **0.7944 ns** |    **8** |         **-** |
| MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLogaritmicaDeTempo |  Int32[200] |  13.869 ns | 0.0956 ns | 0.0847 ns |    4 |         - |
|      **MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLinearDeTempo** |  **Int32[300]** | **104.038 ns** | **1.7570 ns** | **2.5753 ns** |    **9** |         **-** |
| MedirPerformanceEncontrarIndicePrimeiraOcorrenciaEmComplexidadeLogaritmicaDeTempo |  Int32[300] |  16.103 ns | 0.1064 ns | 0.0888 ns |    5 |         - |
