﻿using System.Drawing;
using System.Windows.Forms;
using Cats21.Module.BusinessObjects;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
namespace Cats21.Module.Win.Editors
{
    public class CatShowControl : XtraUserControl
    {
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.Windows.Forms.Label label1;

        public CatShowControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAT SHOW";
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            // 
            // 
            // 
            this.galleryControl1.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControl1_Gallery_ItemClick);
            this.galleryControl1.Gallery.ItemDoubleClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControl1_Gallery_ItemDoubleClick);
            this.galleryControl1.Location = new System.Drawing.Point(0, 48);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(760, 377);
            this.galleryControl1.TabIndex = 1;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(739, 373);
            // 
            // CatShowControl
            // 
            this.Controls.Add(this.galleryControl1);
            this.Controls.Add(this.label1);
            this.Name = "CatShowControl";
            this.Size = new System.Drawing.Size(760, 425);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
       

        public void LoadValue(CatShow catShow)
        {
            if (catShow == null) return;
            var gc = this.galleryControl1;
            gc.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gc.Gallery.ImageSize = new Size(120, 90);
            gc.Gallery.ShowItemText = true;
            gc.Gallery.Groups.Clear();

            foreach (var cse in catShow.CatEvents)
            {
                var group = new GalleryItemGroup
                {
                    CaptionControl = new CatShowGroupCaptionControl { CaptionText = cse.EventName }

                };
                group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                group.CaptionControlSize = new Size(20,20);
                
                foreach (var sec in cse.EventSections)
                {
                    var item = new GalleryItem
                    {
                        Caption = sec.EventSectionName, Image = Image.FromFile("c:\\images\\ford.jpg")
                    };
                    group.Items.Add(item);
                }
                gc.Gallery.Groups.Add(group);

            }


            var i = 1;
            foreach (GalleryItemGroup g in gc.Gallery.Groups)
            {
                g.Items.Add(new GalleryItem { Caption = $"caption {i}" });
                i++;
            }

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