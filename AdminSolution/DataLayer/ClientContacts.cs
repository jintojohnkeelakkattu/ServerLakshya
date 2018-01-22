using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static AdminSolution.DataLayer.DbLayerContext;

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

        public int DataInsertToTable(ClientContacts ObClientContacts)
        {
            //DbLayerContext obDbLayerContext = new DbLayerContext();
            int result = 0;

            try
            {
                var Requst = new ClientContacts() {
                    clientName = ObClientContacts.clientName,
                    clientAddress = ObClientContacts.clientAddress,
                    emailAddress = ObClientContacts.emailAddress,
                    contactNumber = ObClientContacts.contactNumber,
                    alternateNumber = ObClientContacts.alternateNumber
                };
                using (var obDbLayerContext = new DbLayerContext())
                {
                    var stud = obDbLayerContext.ClientContacts.Select(s => new ClientContacts
                    {
                        ID = s.ID,
                        clientName = s.clientName,
                        contactNumber = s.contactNumber
                    }).Where(s => s.contactNumber == ObClientContacts.contactNumber);
                    if (stud.Count() == 0)
                    {
                        obDbLayerContext.ClientContacts.Add(Requst);
                        obDbLayerContext.SaveChanges();
                    }
                    else
                    {
                        throw new Exception( "Client Already Added..");
                    }
                    var Results = obDbLayerContext.ClientContacts.Select(s => new ClientContacts
                    {
                        ID = s.ID,
                        clientName = s.clientName,
                        contactNumber = s.contactNumber
                    }).Where(s => s.contactNumber == ObClientContacts.contactNumber).FirstOrDefault();
                    if (Results.ID > 0)
                    {
                        result = Results.ID;
                    }
                }

                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<ClientContacts> getClientDetails(string contactNo)
        {
            List<ClientContacts> ResultList = new List<ClientContacts>();
            try
            {
                using (var obDbLayerContext = new DbLayerContext())
                {
                    var Results = obDbLayerContext.ClientContacts.Select(s => new ClientContacts
                    {
                        ID = s.ID,
                        clientName = s.clientName,
                        contactNumber = s.contactNumber
                    }).Where(s => s.contactNumber == contactNo).ToList();
                    ResultList = Results;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return ResultList;
        }
    }
}
