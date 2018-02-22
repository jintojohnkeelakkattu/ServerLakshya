using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminSolution.Models
{
    public class Event
    {
        public int Id { get; set; } = 0;
        [StringLength(50)]
        [Required(ErrorMessage = "Event Location should be filled")]
        [JsonProperty("clientName")]
        public string EventLocation
        {
            get;
            set;
        }
        [StringLength(50)]
        [Required(ErrorMessage = "One Service Must be filled")]
        [JsonProperty("RequstedService")]
        public string RequstedService
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Event Type should be select")]
        [JsonProperty("EventType")]
        public string EventType
        {
            get;
            set;
        }
        [Required(ErrorMessage = "EventDate is Must")]
        [JsonProperty("EventDate")]
        public string EventDate
        {
            get;
            set;
        }
        [MaxLength(10, ErrorMessage = "ClientId")]
        [JsonProperty("ClientId")]
        public string ClientId
        {
            get;
            set;
        }
    }
}
