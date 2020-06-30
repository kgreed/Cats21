using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cats21.Module.BusinessObjects;
using DevExpress.ExpressApp;
namespace Cats21.Module.Win.Controllers
{
    public partial class CatObjectViewController : ObjectViewController<ListView, Cat>
    {
        protected override void OnActivated()
        {
            base.OnActivated();
            
            View.CreateCustomCurrentObjectDetailView -= View_CreateCustomCurrentObjectDetailView;
            View.CreateCustomCurrentObjectDetailView += View_CreateCustomCurrentObjectDetailView;
        }
        private void View_CreateCustomCurrentObjectDetailView(object sender,
            CreateCustomCurrentObjectDetailViewEventArgs e)
        {
            if (e.ListViewCurrentObject == null) return;
            if (!(e.ListViewCurrentObject is Cat currentRec)) throw new Exception("Unexpected");
          //  var os = Application.CreateObjectSpace(typeof(Cat));
            currentRec.CatShow = MakeCatShow();


        }

        private CatShow MakeCatShow()
        {
            var cs = new CatShow
            {
                CatEvents = new List<CatShowEvent>
                {
                    new CatShowEvent {EventName = "One", 
                        EventSections = {
                        new EventSection{EventSectionName = "E1"},
                        new EventSection{EventSectionName = "E2"},
                        new EventSection{EventSectionName = "E2"}}
                    },
                    new CatShowEvent {EventName = "Two",
                        EventSections = {
                        new EventSection{EventSectionName = "E21"},
                        new EventSection{EventSectionName = "E22"},
                        new EventSection{EventSectionName = "E22"}}
                    },
                    new CatShowEvent {EventName = "Three", 
                        EventSections =
                    {
                        new EventSection{EventSectionName = "E31"},
                        new EventSection{EventSectionName = "E32"},
                        new EventSection{EventSectionName = "E32"}}
                    }
                }
            };
            return cs;
        }
    }
}
