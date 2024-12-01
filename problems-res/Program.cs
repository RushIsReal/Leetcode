// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Problems;
#region StartBenchmark
Stopwatch stopwatch = Stopwatch.StartNew();
long memoryBefore = GC.GetTotalMemory(true);
#endregion

//not using static classes only for copy paste into leetcode faster
Console.WriteLine(new ReverseInteger().Reverse(2147483647)); //7.reverse-integer

#region EndBenchMark
stopwatch.Stop();
long memoryAfter = GC.GetTotalMemory(false);        
long memoryUsed = memoryAfter - memoryBefore;
Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} ms");
Console.WriteLine($"Memory Used: {memoryUsed / 1024.0:F2} KB");
#endregion