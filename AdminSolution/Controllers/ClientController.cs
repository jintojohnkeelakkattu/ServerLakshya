using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using AdminSolution.Models;
using Microsoft.AspNetCore.Cors;
using System.Net;
using AutoMapper;
using AdminSolution.DataLayer;
using Newtonsoft.Json;
using System.Text;

namespace AdminSolution.Controllers
{
    
    [EnableCors("MyPolicy")]
    //[Produces("application/json")]
    public class ClientController : HomeController
    {
        private readonly IMapper _mapper;
        public ClientController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult postRegisterClient([FromBody]ClientContact obClientContact)
        {
            try
            {

                
                var ClientContactObject = new ClientContacts()
                {
                    clientName = obClientContact.clientName,
                    clientAddress = obClientContact.clientAddress,
                    alternateNumber = obClientContact.alternateNumber,
                    contactNumber = obClientContact.contactNumber,
                    emailAddress = obClientContact.emailAddress

                };

                var result=   ClientContactObject.DataInsertToTable(ClientContactObject);

                if (result > 0)
                {

                    return Ok(result);
                }
                else
                {
                    throw new Exception("Insertion Failed,Contact your Admin");
                }


           }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
        [HttpGet]
        public IEnumerable<ClientContacts> getClientContactDetails(string ContactNo)
        {
               return new ClientContacts().getClientDetails(ContactNo);

        }
        [HttpGet]
        public HttpResponseMessage getData()
        {
            HttpResponseMessage nn = new HttpResponseMessage();
            nn.Content.Headers.Add("sss", "ssssss");
            return nn;
        }

    }
}