using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace Cats21.Module.Win.Editors
{
    public class CatShowGroupCaptionControl : XtraUserControl
    {
        private Label label1;
        public string CaptionText { get; set; }

        public CatShowGroupCaptionControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // CatShowGroupCaptionControl
            // 
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(20, 20);
            this.Name = "CatShowGroupCaptionControl";
            this.Size = new System.Drawing.Size(248, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label1.Text = CaptionText;
        }
    }
}