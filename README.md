# Wildcard Pattern Matching Example

``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-4310M CPU 2.70GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT


```
|                    Method |      Mean |     Error |    StdDev |    Median | Rank |
|-------------------------- |----------:|----------:|----------:|----------:|-----:|
|  OptimizedWildCardPattern |  2.164 us | 0.0747 us | 0.2191 us |  2.085 us |    1 |
| RegexBasedWildCardPattern | 14.228 us | 0.3799 us | 1.0778 us | 13.823 us |    2 |

