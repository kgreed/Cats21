﻿using System;
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
        private Button button1;
        private Label label1;

        public CatShowControl()
        {
            InitializeComponent();
            //SetAutoSizeMode(AutoSizeMode.GrowAndShrink);
            galleryControl1.Gallery.AutoSize = GallerySizeMode.Vertical;
            //AutoSize = true;
            //AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //galleryControl1.AutoSize = true;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.galleryControl1 = new Cats21.Module.Win.Editors.myGalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.button1 = new System.Windows.Forms.Button();
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
            this.galleryControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.Location = new System.Drawing.Point(0, 58);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(760, 367);
            this.galleryControl1.TabIndex = 1;
            this.galleryControl1.Text = "galleryControl1";
            this.galleryControl1.Resize += new System.EventHandler(this.galleryControl1_Resize);
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(739, 363);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CatShowControl
            // 
            this.AutoSize = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.galleryControl1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(200, 200);
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
            // gc.Refresh();
            //var sz = new Size
            //{
            //    Height = galleryControl1.Gallery.GalleryControl.Height,
            //    Width = galleryControl1.Gallery.GalleryControl.Width
            //};
            //galleryControl1.MinimumSize = sz;
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

        private void galleryControl1_Resize(object sender, System.EventArgs e)
        {
            var top = galleryControl1.Top;
            var ctrl = sender as myGalleryControl;
            var oldSize = ctrl.Size;
            var newSize = new Size(oldSize.Width, oldSize.Height+top);
            this.MinimumSize = newSize;
        }
        public event Action PickEvent = delegate { };

        private void button1_Click(object sender, System.EventArgs e)
        {
            PickEvent();
        }
    }
}