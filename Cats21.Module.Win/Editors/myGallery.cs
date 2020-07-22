using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
namespace Cats21.Module.Win.Editors
{
    class myGallery : GalleryControlGallery
    {
        public myGallery()
        {

        }
        public myGallery(GalleryControl galleryControl)
            : base(galleryControl)
        {

        }
        protected override DevExpress.XtraBars.Ribbon.ViewInfo.BaseGalleryViewInfo CreateViewInfo()
        {
            return new myStandaloneGalleryViewInfo(this);
        }

    }
}