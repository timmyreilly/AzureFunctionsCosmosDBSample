# DocumentDB Repository Pattern for Azure Function in C#

### Repository provided by Crokus - https://github.com/Crokus/cosmosdb-repo 

1. Created a cosmos db from the Azure Portal with the MongoDB API Specification. 
2. Configured appsettings.json. `AzureWebJobsStorage` is for our queue and everything else is for Cosmos. (Make sure encrypted is false)

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

3. 