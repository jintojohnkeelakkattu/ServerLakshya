﻿using Newtonsoft.Json;
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
        [Required]
        [StringLength(50)]
        [JsonProperty("clientName")]
        public string clientName
        {
            get;
            set;
        }
        [Required]
        [StringLength(50)]
        public string clientAddress
        {
            get;
            set;
        }
        [Required]
        [StringLength(50)]
        public string emailAddress
        {
            get;
            set;
        }
        [Required]
        [StringLength(50)]
        public string contactNumber
        {
            get;
            set;
        }
        [Required]
        [StringLength(50)]
        public string alternateNumber
        {
            get;
            set;
        }
    }
}
