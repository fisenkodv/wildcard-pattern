using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Running;

namespace WildcardPattern
{
  internal static class Program
  {
    static void Main(string[] args)
    {
      var summary = BenchmarkRunner.Run<WildcardPatternBenchmark>();
    }
  }

  [RPlotExporter, RankColumn]
  public class WildcardPatternBenchmark
  {
    private List<string> _testData;

    [GlobalSetup]
    public void Setup()
    {
      _testData = new List<string>
      {
        "banana",
        "b?n?na",
        "b?ana",
        "b?nana",
        "b????a",
        "b*na",
        "b*a",
        "b*",
        "b???*a"
      };
    }

    [Benchmark]
    public bool[] OptimizedWildCardPattern() =>
      _testData.Select(x => WildcardPattern.IsMatchOptimized("banana", x)).ToArray();

    [Benchmark]
    public bool[] RegexBasedWildCardPattern() =>
      _testData.Select(x => WildcardPattern.IsMatchRegexBased("banana", x)).ToArray();
  }
}