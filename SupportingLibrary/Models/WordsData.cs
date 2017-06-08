using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SupportingLibrary.Models
{
    class WordsData
    {
        private const string _schemaVersion = "1.0.0";

        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
        public int NumberOfChars { get; set; }
        public string ReceivedWords { get; set; }
        public DateTime DateTime { get; set; }
        public string SchemaVersion
        {
            get { return _schemaVersion; }
            private set { }
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
