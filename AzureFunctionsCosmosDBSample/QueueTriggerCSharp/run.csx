#r "..\bin\SupportingLibrary.dll"

using System;
using System.Diagnostics;  
using SupportingLibrary;

public static void Run(string myQueueItem, TraceWriter log)
{
    var docDBEndpoint = System.Environment.GetEnvironmentVariable("CosmoDBEndpoint", EnvironmentVariableTarget.Process);
    var docDBKey = System.Environment.GetEnvironmentVariable("CosmoDBKey", EnvironmentVariableTarget.Process);
    var collectionName = System.Environment.GetEnvironmentVariable("CollectionName", EnvironmentVariableTarget.Process);
    var databaseName = System.Environment.GetEnvironmentVariable("DatabaseName", EnvironmentVariableTarget.Process);

    string partitionKey = "NumberOfChars"; // Partitioning on Number of Chars - arbitrary for sample purposes for more on partitioning visit: 

    var logic = new Logic(docDBEndpoint, docDBKey, databaseName, partitionKey, collectionName); 

    log.Info($"C# Timer trigger function starting: {DateTime.Now}");
    var stopWatch = new Stopwatch();
    stopWatch.Start();
    logic.ProcessWords(myQueueItem).Wait();

    stopWatch.Stop();

    log.Info($"C# Queue trigger function processed: {myQueueItem}");
}
