using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cats21.Module.BusinessObjects;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;
namespace Cats21.Module.Win.Editors
{
    [PropertyEditor(typeof(CatShow), true)]
    public class CatShowEditor : WinPropertyEditor
    {
        public CatShowEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
        {
        }

        
        private CatShowControl control;
        protected override object CreateControlCore()
        { 
           control = new CatShowControl();
           return control;

        }

        protected override void ReadValueCore()
        {
            control.LoadValue(PropertyValue as CatShow);
            base.ReadValueCore();
        }

    
    }
}
