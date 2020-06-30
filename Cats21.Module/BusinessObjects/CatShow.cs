using System.Collections.Generic;
using DevExpress.DocumentServices.ServiceModel.DataContracts;
namespace Cats21.Module.BusinessObjects
{
     
    public class CatShow
    {
         
        public CatShow() {
            CatEvents = new List<CatShowEvent>();
        }

        public string CatShowName { get; set; }
        public IList<CatShowEvent> CatEvents { get; set; } 
    }
    public class CatShowEvent
    {
        public CatShowEvent()
        {
            EventSections = new List<EventSection>();
        }

        public string EventName { get; set; }
        public IList<EventSection> EventSections { get; set; }
    }
    public class EventSection
    {
        public string EventSectionName { get; set; }
    }
}