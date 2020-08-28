using DevExpress.XtraBars.Ribbon;
namespace Cats21.Module.Win.Editors
{
    class myGalleryControl : GalleryControl
    {
        private GalleryControlClient galleryControlClient1;

        protected override DevExpress.XtraBars.Ribbon.Gallery.GalleryControlGallery CreateGallery()
        {
            return new myGallery(this);
        }

        private void InitializeComponent()
        {
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this;
            this.galleryControlClient1.Location = new System.Drawing.Point(0, 0);
            this.galleryControlClient1.Size = new System.Drawing.Size(0, 0);
            // 
            // myGalleryControl
            // 
            this.Controls.Add(this.galleryControlClient1);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}