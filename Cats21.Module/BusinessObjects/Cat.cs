using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
namespace Cats21.Module.BusinessObjects
{
    [NavigationItem("Default")]
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped] public CatShow CatShow { get; set; }

        [ModelDefault("RowCount", "10")]
        public string Notes1 { get; set; }
        [ModelDefault("RowCount", "10")]
        public string Notes2 { get; set; }
        [ModelDefault("RowCount", "10")]
        public string Notes3 { get; set; }

    }
}