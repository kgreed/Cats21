namespace Cats21.Module.Win.Controllers
{
    partial class CatEventController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.actPickEvent = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
            // 
            // actPickEvent
            // 
            this.actPickEvent.AcceptButtonCaption = null;
            this.actPickEvent.CancelButtonCaption = null;
            this.actPickEvent.Caption = "pick event";
            this.actPickEvent.ConfirmationMessage = null;
            this.actPickEvent.Id = "pickevent";
            this.actPickEvent.ToolTip = null;
            this.actPickEvent.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction1_CustomizePopupWindowParams);
            this.actPickEvent.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.popupWindowShowAction1_Execute);
            // 
            // CatEventController
            // 
            this.Actions.Add(this.actPickEvent);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.PopupWindowShowAction actPickEvent;
    }
}
