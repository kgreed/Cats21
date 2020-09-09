using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
namespace Cats21.Module.Win.Controllers
{
    [DomainComponent]
    public class MyDialog :NonPersistentBaseObject
    {
        public MyDialog(string message)
        {
            this.Message = message;
        }
        public string Message { get; private set; }
    }
}