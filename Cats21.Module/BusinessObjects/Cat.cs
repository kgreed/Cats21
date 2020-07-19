using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.Persistent.Base;
namespace Cats21.Module.BusinessObjects
{
    [NavigationItem("Default")]
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped] public CatShow CatShow { get; set; }
    }
}