using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Events
{
    public class IntegrationEvents
    {

        [JsonProperty]
        public Guid Id { get; private set; }
        [JsonProperty]
        public DateTime CreatedDate { get; private set; }


        [JsonConstructor]
        public IntegrationEvents(Guid id, DateTime createdDate)
        {
            Id = id;
            CreatedDate = createdDate;
        }

        public IntegrationEvents()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }

    }
}
