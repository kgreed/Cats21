using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Cats21.Module.BusinessObjects;
using DevExpress.ExpressApp.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
namespace Cats21.Module.Win.Editors
{
    public class CatShowControl : XtraUserControl
    {
        private myGalleryControl galleryControl1;
        private GalleryControlClient galleryControlClient1;
        private Label label1;

        public CatShowControl()
        {
            InitializeComponent();
            //SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            galleryControl1.Gallery.AutoSize = GallerySizeMode.Vertical;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //galleryControl1.AutoSize = true;
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            galleryControl1 = new myGalleryControl();
            galleryControlClient1 = new GalleryControlClient();
            AutoSize = true;
            ((ISupportInitialize) galleryControl1).BeginInit();
            galleryControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(61, 13);
            label1.TabIndex = 0;
            label1.Text = "CAT SHOW";
            // 
            // galleryControl1
            // 
            galleryControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                                                      | AnchorStyles.Left
                                                      | AnchorStyles.Right;
            galleryControl1.Controls.Add(galleryControlClient1);
            // 
            // 
            // 
            galleryControl1.Gallery.ItemClick += galleryControl1_Gallery_ItemClick;
            galleryControl1.Gallery.ItemDoubleClick += galleryControl1_Gallery_ItemDoubleClick;
            galleryControl1.Location = new Point(0, 58);
            galleryControl1.Name = "galleryControl1";
            galleryControl1.Size = new Size(760, 367);
            galleryControl1.TabIndex = 1;
            galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            galleryControlClient1.GalleryControl = galleryControl1;
            galleryControlClient1.Location = new Point(2, 2);
            galleryControlClient1.Size = new Size(739, 363);
            // 
            // CatShowControl
            // 
            Controls.Add(galleryControl1);
            Controls.Add(label1);
            MinimumSize = new Size(200, 200);
            Name = "CatShowControl";
            Size = new Size(760, 425);
            ((ISupportInitialize) galleryControl1).EndInit();
            galleryControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        public void LoadValue(CatShow catShow)
        {
            if (catShow == null) return;
            var gc = galleryControl1;
            gc.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gc.Gallery.ImageSize = new Size(120, 90);
            gc.Gallery.ShowItemText = true;
            gc.Gallery.Groups.Clear();
            foreach (var cse in catShow.CatEvents)
            {
                var group = new GalleryItemGroup
                {
                    CaptionControl = new CatShowGroupCaptionControl {CaptionText = cse.EventName}
                };
                group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                group.CaptionControlSize = new Size(20, 20);
                foreach (var sec in cse.EventSections)
                {
                    var item = new GalleryItem
                    {
                        // Caption = sec.EventSectionName, Image = Image.FromFile("c:\\images\\ford.jpg")
                        Caption = sec.EventSectionName,
                        Image = ImageLoader.Instance.GetImageInfo("ford").Image
                    };
                    group.Items.Add(item);
                }

                gc.Gallery.Groups.Add(group);
            }

            var i = 1;
            foreach (GalleryItemGroup g in gc.Gallery.Groups)
            {
                g.Items.Add(new GalleryItem {Caption = $"caption {i}"});
                i++;
            }
            gc.Refresh();
            var sz = new Size
            {
                Height = galleryControl1.Gallery.GalleryControl.Height,
                Width = galleryControl1.Gallery.GalleryControl.Width
            };
            galleryControl1.MinimumSize = sz;
            gc.Refresh();
        }

        private void galleryControl1_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void galleryControl1_Gallery_ItemDoubleClick(object sender, GalleryItemClickEventArgs e)
        {
            MessageBox.Show("Double Click");
        }
    }
}