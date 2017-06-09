using DocumentDB.Repository;
using SupportingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportingLibrary
{
    public class Logic
    {
        private readonly string _partitionKeyName;
        private IDocumentDbRepository<WordsData> _repository;

        public Logic(string docDBEndpoint, string docDBKey, string docDbName, string partitionKeyName, string docDbCollectionName)
        {
            _partitionKeyName = partitionKeyName;  

            var initializer = new DocumentDbInitializer();

            //TODO check out connection policy 
            var client = initializer.GetClient(docDBEndpoint, docDBKey);
            _repository = new DocumentDbRepository<WordsData>(client, docDbName, _partitionKeyName, () => docDbCollectionName);
        }

        public async Task ProcessWords(string incoming)
        {
            Debug.WriteLine($"Adding { incoming } to DB");
 
            var words = new WordsData() { Id = Guid.NewGuid(), NumberOfChars = incoming.Length, ReceivedWords = incoming, DateTime = DateTime.Now };

            await _repository.AddOrUpdateAsync(words);
        }
    }
}
