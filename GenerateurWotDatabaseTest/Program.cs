// See https://aka.ms/new-console-template for more information

using GenerateurWotDatabaseTest;

StatRetriever retriever = new StatRetriever();
/*var results = retriever.RetrieveWinLossOf(528189939, 9297);
foreach (var list in results)
{
    Console.WriteLine($"==={list.Key.ToString("g")}===");
    Console.WriteLine($"{list.Value[0]} wins\n" +
                      $"{list.Value[1]} losses\n" +
                      $"{list.Value[2]} battles");
    Console.WriteLine();
}*/

var stats = retriever.RetrieveStatsOf(528189939, 9297);
Console.WriteLine(stats.HasValue ? stats.Value : "No stats");

