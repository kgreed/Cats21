//using System;
//using Cats21.Module.BusinessObjects;
//using DevExpress.ExpressApp;
//using DevExpress.ExpressApp.Editors;
//using DevExpress.ExpressApp.Win.Editors;
//namespace Cats21.Module.Win.Controllers
//{
//    public partial class InLineEditController : ViewController
//    {
//        public InLineEditController()
//        {
//           // InitializeComponent();
//            TargetObjectType = typeof(ICanEditInLine);
//        }
//        private void ViewOnControlsCreated(object sender, EventArgs eventArgs)
//        {
//            var listView = View as ListView;
//            if (!(listView?.Editor is GridListEditor editor)) return;
//            var allowEdit = !(Frame.Template is ILookupPopupFrameTemplate);
//            editor.NewItemRowPosition = NewItemRowPosition.Bottom;
//            editor.AllowEdit = View.Model.AllowEdit = allowEdit;
//        }
//        protected override void OnActivated()
//        {
//            base.OnActivated();
//            View.ControlsCreated += ViewOnControlsCreated;
//            //((dynamic)(View.Model)).NewItemRowPosition = NewItemRowPosition.Bottom;
//        }

//        protected override void OnDeactivated()
//        {
//            base.OnDeactivated();
//            View.ControlsCreated -= ViewOnControlsCreated;
//        }
//    }
    
//}