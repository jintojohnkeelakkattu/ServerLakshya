using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminSolution.Models
{
    public class Client
    {

    }

    public class ClientContact
    {
        public int Id { get; set; } = 0;
        [StringLength(50)]
        [Required(ErrorMessage = "ClientName is Must")]
        [JsonProperty("clientName")]
        public string clientName
        {
            get;
            set;
        }
        [StringLength(50)]
        [Required(ErrorMessage = "ClientAddress is Must")]
        [JsonProperty("clientAddress")]
        public string clientAddress
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Email is Must")]
        [JsonProperty("emailAddress")]
        [EmailAddress(ErrorMessage = "Not a valid email")]
        public string emailAddress
        {
            get;
            set;
        }
        [Required(ErrorMessage = "ContactNumber is Must")]
        [MaxLength(10, ErrorMessage = "Must be Maximum 10 numbers")]
        [JsonProperty("contactNumber")]
        public string contactNumber
        {
            get;
            set;
        }
        [Required(ErrorMessage = "AlternateNumber is Must")]
        [MaxLength(10, ErrorMessage = "Must be Maximum 10 numbers")]
        [JsonProperty("alternateNumber")]
        public string alternateNumber
        {
            get;
            set;
        }
    }
   
}
