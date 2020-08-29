using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
namespace Cats21.Module.Win.Controllers
{
    public class MyDialogController : ViewController
    {
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
    }
}