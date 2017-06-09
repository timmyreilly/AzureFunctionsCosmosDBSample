# DocumentDB Repository Pattern for Azure Function in C#

### Repository provided by Crokus - https://github.com/Crokus/cosmosdb-repo 

1. Create a Cosmos DB instance from the Azure Portal with the MongoDB API Specification. 
2. Configure appsettings.json. `AzureWebJobsStorage` is for our queue and everything else is for Cosmos DB. (Make sure encrypted is set to `false`)
```json

{
  "IsEncrypted": false,
  "Values": {
    "AzureWebJobsStorage": "DefaultEndpointsProtocol=https;AccountName=yourstorageacountname468;AccountKey=xFCu0hheWComplicated4ntoi0g1acRZUyubbcqg2pwj1PJW8AHDo1PIduXUu8tuEkOg==",
    "DocDBEndpoint": "https://cosmo-kramer.documents.azure.com:443/",
    "DocDBKey": "SuperSecretZpOuNPIn3NlpLigSomethingSecret2klLvRKuoiib26sd9kThlf1MYdnk1cp4NI9icRAuRsfS7NrluIg==",
    "CollectionName": "FunctionOutputCollection",
    "DatabaseName": "Words"
  }
}

```

3. In the Azure Portal Create a CollectionName and DatabaseName that matches. 

<kbd>
<img src="http://imgur.com/FNae0Q6.png" width="800">
</kbd> 

4. Make sure you run your function properly by setting the Web Properties to something like this: 

<kbd>
<img src="http://imgur.com/rUNanD0.png" width="800">
</kbd>

If functions in Visual Studio 2015 are new to you watch this video: https://www.youtube.com/watch?v=R7F92POLGaE 

5. When it builds open Azure Storage Explorer and throw something in a queue. The `queueName` your function is listening to is set in function.json: 

```json
{
  "disabled": false,
  "bindings": [
    {
      "name": "myQueueItem",
      "type": "queueTrigger",
      "direction": "in",
      "queueName": "doc-db-entry",
      "connection": "AzureWebJobsStorage"
    }
  ]
}
```

And here's what that looks like in storage explorer: 
<kbd>
<img src="http://imgur.com/jlXGwOP.png" width="800">
</kbd>

6. Its running and grabbing messages off the queue. 

<kbd>
<img src="http://imgur.com/mUqrTGH.png" width="800">
</kbd>

Now you can see your documents in the Azure Portal with the messages passed through the queue: 

<kbd>
<img src="http://imgur.com/UJzvmsr.png" width="800">
</kbd>

Reach out to me on twitter if you have any questions: http://twitter.com/timmyreilly 