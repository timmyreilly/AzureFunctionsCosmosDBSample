#r "..\bin\SupportingLibrary.dll"

using System;

public static void Run(string myQueueItem, TraceWriter log)
{
    var docDBEndpoint = System.Environment.GetEnvironmentVariable("DocDBEndpoint", EnvironmentVariableTarget.Process);
    var docDBKey = System.Environment.GetEnvironmentVariable("DocDBKey", EnvironmentVariableTarget.Process);
    var collectionName = System.Environment.GetEnvironmentVariable("CollectionName", EnvironmentVariableTarget.Process);
    var databaseName = System.Environment.GetEnvironmentVariable("DatabaseName", EnvironmentVariableTarget.Process);


    log.Info($"C# Queue trigger function processed: {myQueueItem}");
}
