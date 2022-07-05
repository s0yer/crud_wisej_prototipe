namespace crud_wisej_prototipe
{
    partial class Page1
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
            Wisej.Web.ColumnHeader columnHeader1;
            this.panel1 = new Wisej.Web.Panel();
            this.button6 = new Wisej.Web.Button();
            this.Botao_Auxiliar = new Wisej.Web.Button();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.button1 = new Wisej.Web.Button();
            this.button2 = new Wisej.Web.Button();
            this.button3 = new Wisej.Web.Button();
            this.button4 = new Wisej.Web.Button();
            this.button5 = new Wisej.Web.Button();
            this.button7 = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.listView1 = new Wisej.Web.ListView();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            columnHeader1 = new Wisej.Web.ColumnHeader();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayPropertyName = "numero";
            columnHeader1.Name = "columnHeader1";
            columnHeader1.Text = "Numero da Sorte";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromName("@controlDark");
            this.panel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.Botao_Auxiliar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.HeaderSize = 34;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2043, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.Page1_Load);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(51, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 37);
            this.button6.TabIndex = 13;
            this.button6.Text = "Atualiza Sistema";
            this.button6.Click += new System.EventHandler(this.Page1_Load);
            // 
            // Botao_Auxiliar
            // 
            this.Botao_Auxiliar.Location = new System.Drawing.Point(179, 21);
            this.Botao_Auxiliar.Name = "Botao_Auxiliar";
            this.Botao_Auxiliar.Size = new System.Drawing.Size(100, 37);
            this.Botao_Auxiliar.TabIndex = 11;
            this.Botao_Auxiliar.Text = "Auxiliar";
            this.Botao_Auxiliar.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.LabelText = "Recover";
            this.comboBox1.Location = new System.Drawing.Point(1357, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 53);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromName("@info");
            this.button1.Location = new System.Drawing.Point(52, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Numero da Sorte :3";
            this.button1.Click += new System.EventHandler(this.Botao_GeraNumeroSorte);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Escolha o dia";
            this.button2.Click += new System.EventHandler(this.Botao_TestaSorte);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Popula database";
            this.button3.Click += new System.EventHandler(this.Botao_PopulaTabela);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(52, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 46);
            this.button4.TabIndex = 5;
            this.button4.Text = "Testa Conexao Database";
            this.button4.Click += new System.EventHandler(this.Botao_TestaConexao);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(52, 517);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 37);
            this.button5.TabIndex = 6;
            this.button5.Text = "Salva .Txt";
            this.button5.Click += new System.EventHandler(this.Botao_SalvaTxt);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(52, 372);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 37);
            this.button7.TabIndex = 8;
            this.button7.Text = "Mostra database Terminal";
            this.button7.Click += new System.EventHandler(this.Botao_MostraDBTerminal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(67, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Flag Test";
            this.label1.Click += new System.EventHandler(this.Page1_Load);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
            columnHeader1});
            this.listView1.Location = new System.Drawing.Point(1022, 170);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(518, 525);
            this.listView1.TabIndex = 11;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = true;
            this.dataGridView2.Location = new System.Drawing.Point(316, 170);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(620, 515);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1868, 739);
            this.Load += new System.EventHandler(this.Page1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Panel panel1;
        private Wisej.Web.Button button1;
        private Wisej.Web.Button button2;
        private Wisej.Web.Button button3;
        private Wisej.Web.Button button4;
        private Wisej.Web.Button button5;
        private Wisej.Web.Button button7;
        private Wisej.Web.ComboBox comboBox1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button Botao_Auxiliar;
        private Wisej.Web.ListView listView1;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.Button button6;
    }
}

