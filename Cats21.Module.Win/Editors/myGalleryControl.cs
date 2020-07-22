using DevExpress.XtraBars.Ribbon;
namespace Cats21.Module.Win.Editors
{
    class myGalleryControl : GalleryControl
    {
        protected override DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery CreateGallery()
        {
            return new myGallery(this);
        }

    }
}