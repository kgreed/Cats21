using System.Collections.Generic;
using DevExpress.Data.Browsing.Design;
using DevExpress.ExpressApp.DC;
namespace Cats21.Module.BusinessObjects
{
    [DomainComponent]
    public class CatEventName
    {
        public string MoggyEvent { get; set; }

        public static CatEventName[] GetData()
        {
            var names = new List<CatEventName>
            {
                new CatEventName {MoggyEvent = "Event1"},
                new CatEventName {MoggyEvent = "Event2"},
                new CatEventName {MoggyEvent = "Event3"},
            new CatEventName {MoggyEvent = "Event4"}
            };
            return names.ToArray();
        }
    }
}