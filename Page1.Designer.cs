﻿namespace crud_wisej_prototipe
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
            this.components = new System.ComponentModel.Container();
            Wisej.Web.ColumnHeader columnHeader1;
            this.panel1 = new Wisej.Web.Panel();
            this.button6 = new Wisej.Web.Button();
            this.Botao_Auxiliar = new Wisej.Web.Button();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.button1 = new Wisej.Web.Button();
            this.data_sorte = new Wisej.Web.Button();
            this.popula_database = new Wisej.Web.Button();
            this.testa_conexao = new Wisej.Web.Button();
            this.salva_txt = new Wisej.Web.Button();
            this.button7 = new Wisej.Web.Button();
            this.label1 = new Wisej.Web.Label();
            this.listView1 = new Wisej.Web.ListView();
            this.dataGridView2 = new Wisej.Web.DataGridView();
            this.menuBar1 = new Wisej.Web.MenuBar();
            this.toolTip1 = new Wisej.Web.ToolTip(this.components);
            this.open_window = new Wisej.Web.Button();
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
            this.button1.Location = new System.Drawing.Point(52, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Numero da Sorte :3";
            this.button1.Click += new System.EventHandler(this.Botao_GeraNumeroSorte);
            // 
            // data_sorte
            // 
            this.data_sorte.Location = new System.Drawing.Point(52, 244);
            this.data_sorte.Name = "data_sorte";
            this.data_sorte.Size = new System.Drawing.Size(163, 37);
            this.data_sorte.TabIndex = 2;
            this.data_sorte.Text = "Data da Sorte";
            this.data_sorte.Click += new System.EventHandler(this.Botao_TestaSorte);
            // 
            // popula_database
            // 
            this.popula_database.Location = new System.Drawing.Point(52, 310);
            this.popula_database.Name = "popula_database";
            this.popula_database.Size = new System.Drawing.Size(163, 35);
            this.popula_database.TabIndex = 3;
            this.popula_database.Text = "Popula database";
            this.popula_database.Click += new System.EventHandler(this.Botao_PopulaTabela);
            // 
            // testa_conexao
            // 
            this.testa_conexao.AutoSize = true;
            this.testa_conexao.Location = new System.Drawing.Point(52, 441);
            this.testa_conexao.Name = "testa_conexao";
            this.testa_conexao.Size = new System.Drawing.Size(163, 37);
            this.testa_conexao.TabIndex = 5;
            this.testa_conexao.Text = "Testa Conexao DB";
            this.testa_conexao.Click += new System.EventHandler(this.Botao_TestaConexao);
            // 
            // salva_txt
            // 
            this.salva_txt.Location = new System.Drawing.Point(52, 511);
            this.salva_txt.Name = "salva_txt";
            this.salva_txt.Size = new System.Drawing.Size(163, 37);
            this.salva_txt.TabIndex = 6;
            this.salva_txt.Text = "Salva .Txt";
            this.salva_txt.Click += new System.EventHandler(this.Botao_SalvaTxt);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(52, 377);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 37);
            this.button7.TabIndex = 8;
            this.button7.Text = "Mostra Items DB";
            this.button7.Click += new System.EventHandler(this.Botao_MostraDBTerminal);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("@defaultBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(316, 187);
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
            this.dataGridView2.Location = new System.Drawing.Point(316, 231);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(620, 454);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // menuBar1
            // 
            this.menuBar1.Dock = Wisej.Web.DockStyle.Bottom;
            this.menuBar1.Location = new System.Drawing.Point(0, 695);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(2043, 40);
            this.menuBar1.TabIndex = 13;
            this.menuBar1.TabStop = false;
            this.menuBar1.Click += new System.EventHandler(this.menuBar1_Click);
            // 
            // open_window
            // 
            this.open_window.Location = new System.Drawing.Point(52, 178);
            this.open_window.Name = "open_window";
            this.open_window.Size = new System.Drawing.Size(163, 36);
            this.open_window.TabIndex = 14;
            this.open_window.Text = "Open Window";
            this.open_window.Click += new System.EventHandler(this.button8_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.open_window);
            this.Controls.Add(this.menuBar1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.salva_txt);
            this.Controls.Add(this.testa_conexao);
            this.Controls.Add(this.popula_database);
            this.Controls.Add(this.data_sorte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1323, 505);
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
        private Wisej.Web.Button data_sorte;
        private Wisej.Web.Button popula_database;
        private Wisej.Web.Button testa_conexao;
        private Wisej.Web.Button salva_txt;
        private Wisej.Web.Button button7;
        private Wisej.Web.ComboBox comboBox1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Button Botao_Auxiliar;
        private Wisej.Web.ListView listView1;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.Button button6;
        private Wisej.Web.MenuBar menuBar1;
        private Wisej.Web.ToolTip toolTip1;
        private Wisej.Web.Button open_window;
    }
}

