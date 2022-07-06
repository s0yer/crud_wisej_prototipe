namespace crud_wisej_prototipe
{
    partial class Window
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas1 = new Wisej.Web.Canvas();
            this.iFramePanel1 = new Wisej.Web.IFramePanel();
            this.shape1 = new Wisej.Web.Shape();
            this.SuspendLayout();
            // 
            // canvas1
            // 
            this.canvas1.Location = new System.Drawing.Point(34, 18);
            this.canvas1.Name = "canvas1";
            this.canvas1.Size = new System.Drawing.Size(150, 87);
            // 
            // iFramePanel1
            // 
            this.iFramePanel1.Location = new System.Drawing.Point(575, 18);
            this.iFramePanel1.Name = "iFramePanel1";
            this.iFramePanel1.Size = new System.Drawing.Size(136, 87);
            this.iFramePanel1.TabIndex = 1;
            this.iFramePanel1.Text = "iFramePanel1";
            // 
            // shape1
            // 
            this.shape1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.shape1.Location = new System.Drawing.Point(285, 151);
            this.shape1.Name = "shape1";
            this.shape1.Size = new System.Drawing.Size(159, 111);
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(749, 453);
            this.Controls.Add(this.shape1);
            this.Controls.Add(this.iFramePanel1);
            this.Controls.Add(this.canvas1);
            this.Name = "Window";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Canvas canvas1;
        private Wisej.Web.IFramePanel iFramePanel1;
        private Wisej.Web.Shape shape1;
    }
}