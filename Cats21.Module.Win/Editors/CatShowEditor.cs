using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cats21.Module.BusinessObjects;
using Cats21.Module.Win.Controllers;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Win.Editors;
using View = DevExpress.ExpressApp.View;
namespace Cats21.Module.Win.Editors
{
    [PropertyEditor(typeof(CatShow), true)]
    public class CatShowEditor : WinPropertyEditor, IComplexViewItem
    {
        public CatShowEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
        {
        }

        
        private CatShowControl control;
        protected override object CreateControlCore()
        { 
           control = new CatShowControl();
            control.PickEvent += Control_PickEvent;

           return control;

        }

        // In the editor
       
        private void Control_PickEvent()
        {
            try
            {
                var controller = application.CreateController<MyDialogController>();
                controller.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                Console.WriteLine(e);
                throw;
            }
  
        }

        protected override void ReadValueCore()
        {
            control.LoadValue(PropertyValue as CatShow);
            base.ReadValueCore();
        }
        private IObjectSpace objectSpace;
        private XafApplication application;
        public void Setup(IObjectSpace objectSpace, XafApplication application)
        {
            this.objectSpace = objectSpace;
            this.application = application;
        }
    }
}
