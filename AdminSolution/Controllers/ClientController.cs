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
        private readonly DbLayerContext _dbContext;
        public ClientController(IMapper mapper, DbLayerContext context)
        {
            _mapper = mapper;
            _dbContext = context;
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

                var result = ClientContactObject.DataInsertToTable(ClientContactObject, _dbContext);

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
        [HttpPost]
        public IActionResult putRegisterClient([FromBody]ClientContact obClientContact)
        {
            try
            {


                var ClientContactObject = new ClientContacts()
                {
                    ID = obClientContact.Id,
                    clientName = obClientContact.clientName,
                    clientAddress = obClientContact.clientAddress,
                    alternateNumber = obClientContact.alternateNumber,
                    contactNumber = obClientContact.contactNumber,
                    emailAddress = obClientContact.emailAddress

                };

                var result = ClientContactObject.DataUpdateToTable(ClientContactObject, _dbContext);

                if (result > 0)
                {

                    return Ok(result);
                }
                else
                {
                    throw new Exception("Updation Failed,Contact your Admin");
                }


            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
        [HttpGet]
        public ClientContacts getClientContactDetails(string ContactNo)
        {
            return new ClientContacts().getClientDetails(ContactNo, _dbContext);

        }
        [HttpGet]
        public HttpResponseMessage getData(int id)
        {
            HttpResponseMessage nn = new HttpResponseMessage();
            nn.Content.Headers.Add("sss", "ssssss");
            return nn;
        }

        [Route("Api/Event")]
        [HttpPost]
        public Events CraeteNewEvent([FromBody]Event obEvents)
        {
            try
            {
                var EventObject = new Events()
                {
                    RequstedService = obEvents.RequstedService,
                    EventDate = obEvents.EventDate,
                    EventLocation = obEvents.EventLocation,
                    EventType = obEvents.EventType,
                    ClientId =  obEvents.ClientId
                };

                return EventObject.InsertEvent(EventObject, _dbContext);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}