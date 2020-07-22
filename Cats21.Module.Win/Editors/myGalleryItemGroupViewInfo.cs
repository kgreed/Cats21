using System.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
namespace Cats21.Module.Win.Editors
{
    class myGalleryItemGroupViewInfo : GalleryItemGroupViewInfo
    {
        public myGalleryItemGroupViewInfo(BaseGalleryViewInfo galleryInfo, GalleryItemGroup group)
            : base(galleryInfo, group)
        {

        }
        protected override Size LayoutItems(Size itemMaxSize, Point topLeft)
        {
            bool hide = true;
            foreach (GalleryItem item in Group.Items)
            {
                if (!item.Visible) continue;
                hide = false;
                break;
            }

            if (!hide) return base.LayoutItems(itemMaxSize, topLeft);
            this.SetBounds(new Rectangle(this.Bounds.Location, new Size(this.Bounds.Width, 40)));
            return base.LayoutItems(new Size(itemMaxSize.Width, 0), topLeft);
        }
    }
}