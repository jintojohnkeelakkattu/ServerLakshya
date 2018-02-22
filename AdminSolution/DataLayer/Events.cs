using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminSolution.DataLayer
{
    public class Events
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; } = 0;

        public string EventLocation
        {
            get;
            set;
        }

        public string RequstedService
        {
            get;
            set;
        }

        public string EventType
        {
            get;
            set;
        }

        public string EventDate
        {
            get;
            set;
        }

        public string  ClientId
        {
            get;
            set;
        }
        public ClientContacts ClientContacts { get; set; }

        public Events InsertEvent(Events obEvents, DbLayerContext obDbLayerContext)
        {
            var newResult = new Events();
            try
            {
                var eventRequestInsert = new Events()
                {
                    ClientId = obEvents.ClientId,
                    ClientContacts = obEvents.ClientContacts,
                    EventDate = obEvents.EventDate,
                    EventLocation = obEvents.EventLocation,
                    EventType = obEvents.EventType,
                    Id = obEvents.Id,
                    RequstedService = obEvents.RequstedService
                };

                var eventMatches = obDbLayerContext.Events.Select(s => new Events
                {

                    ClientContacts = s.ClientContacts,
                    EventDate = s.EventDate,
                    EventLocation = s.EventLocation,
                    EventType = s.EventType,
                    Id = s.Id

                }).Where(s => s.ClientId == obEvents.ClientId).FirstOrDefault();
                if (eventMatches != null)
                {
                    obDbLayerContext.Events.Add(eventRequestInsert);
                    obDbLayerContext.SaveChanges();
                    newResult = obDbLayerContext.Events.Select(s => new Events
                    {

                        ClientContacts = s.ClientContacts,
                        EventDate = s.EventDate,
                        EventLocation = s.EventLocation,
                        EventType = s.EventType,
                        Id = s.Id

                    }).Where(s => s.ClientId == obEvents.ClientId).FirstOrDefault();
                }
                return eventMatches != null ? eventMatches : newResult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
