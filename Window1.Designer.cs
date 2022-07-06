namespace crud_wisej_prototipe
{
    partial class ShowItems_window
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
            this.listBox1 = new Wisej.Web.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(26, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(459, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ShowItems_window
            // 
            this.ClientSize = new System.Drawing.Size(520, 474);
            this.Controls.Add(this.listBox1);
            this.Name = "ShowItems_window";
            this.Text = "Show Items";
            this.Load += new System.EventHandler(this.ShowItems_window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.ListBox listBox1;
    }
}