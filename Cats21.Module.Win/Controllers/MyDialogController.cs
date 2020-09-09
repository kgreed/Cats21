using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Win;
namespace Cats21.Module.Win.Controllers
{
    public class MyDialogController : ViewController
    {
        public void ShowDialog()
        {
                Action_Execute(null,null);
        }

        private PopupWindowShowAction popupWindowShowAction1;
        private System.ComponentModel.IContainer components;

        public MyDialogController()
        {
            var action = new SimpleAction(this, "Email", "View");
            action.Execute += Action_Execute;
        }
        private void Action_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var objectSpace = Application.CreateObjectSpace(typeof(MyDialog));
            var myDialogObject = new MyDialog("Do you want to send an email?");
            var dialogView = Application.CreateDetailView(objectSpace, myDialogObject);
            Application.ShowViewStrategy.ShowViewInPopupWindow(dialogView,
                () => {
                    Application.ShowViewStrategy.ShowMessage("You've got mail.");
                },
                () => {
                    Application.ShowViewStrategy.ShowMessage("Nothing happened.");
                }
            );
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.popupWindowShowAction1 = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // popupWindowShowAction1
            // 
            this.popupWindowShowAction1.AcceptButtonCaption = null;
            this.popupWindowShowAction1.CancelButtonCaption = null;
            this.popupWindowShowAction1.Caption = null;
            this.popupWindowShowAction1.ConfirmationMessage = null;
            this.popupWindowShowAction1.Id = "0091ee9d-5b30-4380-a5e5-36fd47e3c3f1";
            this.popupWindowShowAction1.ToolTip = null;
            this.popupWindowShowAction1.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction1_CustomizePopupWindowParams);
            this.popupWindowShowAction1.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.popupWindowShowAction1_Execute);
            // 
            // MyDialogController
            // 
            this.Actions.Add(this.popupWindowShowAction1);

        }

        private void popupWindowShowAction1_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {

        }

        private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {

        }
    }
}