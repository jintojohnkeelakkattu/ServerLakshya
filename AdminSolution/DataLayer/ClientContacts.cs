using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminSolution.DataLayer
{
    public class ClientContacts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID
        {
            get;
            set;
        }
        public string clientName
        {
            get;
            set;
        }
        public string clientAddress
        {
            get;
            set;
        }
        public string emailAddress
        {
            get;
            set;
        }
        public string contactNumber
        {
            get;
            set;
        }
        public string alternateNumber
        {
            get;
            set;
        }
    }
}
