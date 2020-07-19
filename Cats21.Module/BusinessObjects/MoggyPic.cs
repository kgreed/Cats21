using DevExpress.Persistent.Base;
namespace Cats21.Module.BusinessObjects
{
    [NavigationItem("Default")]
    public class MoggyPic : ICanEditInLine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ImageEditor] public byte[] Picture { get; set; }
    }
}