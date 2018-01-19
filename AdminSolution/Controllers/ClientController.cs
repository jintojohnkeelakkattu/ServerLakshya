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
        public HttpResponseMessage postRegisterClient([FromBody]ClientContact obClientContact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = _mapper.Map<ClientContacts>(obClientContact);
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                    
               else
                {
                    return new HttpResponseMessage(HttpStatusCode.Unauthorized);
                }

            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.Unauthorized);
            }
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