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
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new Wisej.Web.ColorDialog(this.components);
            this.chartJS1 = new Wisej.Web.Ext.ChartJS.ChartJS();
            this.SuspendLayout();
            // 
            // chartJS1
            // 
            this.chartJS1.Location = new System.Drawing.Point(141, 67);
            this.chartJS1.Name = "chartJS1";
            this.chartJS1.Options.DataLabel.BackgroundColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.BorderColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.Color = System.Drawing.Color.Black;
            this.chartJS1.Options.DataLabel.Opacity = 1F;
            this.chartJS1.Options.DataLabel.TextAlign = Wisej.Web.Ext.ChartJS.DataLabelTextAlignment.Start;
            this.chartJS1.Options.DataLabel.TextShadowColor = System.Drawing.Color.Empty;
            this.chartJS1.Options.DataLabel.TextStrokeColor = System.Drawing.Color.Empty;
            this.chartJS1.Size = new System.Drawing.Size(438, 327);
            this.chartJS1.TabIndex = 0;
            this.chartJS1.Text = "chartJS1";
            this.chartJS1.ChartClick += new Wisej.Web.Ext.ChartJS.ChartClickEventHandler(this.chartJS1_ChartClick);
            // 
            // Window
            // 
            this.ClientSize = new System.Drawing.Size(750, 537);
            this.Controls.Add(this.chartJS1);
            this.Name = "Window";
            this.Text = "Window";
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.ColorDialog colorDialog1;
        private Wisej.Web.Ext.ChartJS.ChartJS chartJS1;
    }
}