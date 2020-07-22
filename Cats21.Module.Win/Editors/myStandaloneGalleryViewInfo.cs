using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraBars.Ribbon.ViewInfo;
namespace Cats21.Module.Win.Editors
{
    class myStandaloneGalleryViewInfo : GalleryControlGalleryViewInfo
    {
        public myStandaloneGalleryViewInfo(GalleryControlGallery gallery)
            : base(gallery)
        {

        }

        protected override GalleryItemGroupViewInfo CreateGroupInfo(BaseGalleryViewInfo galleryInfo, GalleryItemGroup group)
        {
            return new myGalleryItemGroupViewInfo(galleryInfo, group);
        }
    }
}