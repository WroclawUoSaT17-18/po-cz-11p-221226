namespace pejnt
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bKolor = new System.Windows.Forms.Button();
            this.bWyczysc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bKwadart = new System.Windows.Forms.Button();
            this.bProst = new System.Windows.Forms.Button();
            this.bKolo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_szer = new System.Windows.Forms.TextBox();
            this.textBox_wys = new System.Windows.Forms.TextBox();
            this.bTekst = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dGrubosc = new System.Windows.Forms.NumericUpDown();
            this.bGumka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGrubosc)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(808, 481);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.panel1.Location = new System.Drawing.Point(138, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 497);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grubość ";
            // 
            // bKolor
            // 
            this.bKolor.BackColor = System.Drawing.SystemColors.Control;
            this.bKolor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKolor.Location = new System.Drawing.Point(15, 49);
            this.bKolor.Name = "bKolor";
            this.bKolor.Size = new System.Drawing.Size(120, 30);
            this.bKolor.TabIndex = 4;
            this.bKolor.Text = "Kolor";
            this.bKolor.UseVisualStyleBackColor = false;
            this.bKolor.Click += new System.EventHandler(this.bKolor_Click);
            // 
            // bWyczysc
            // 
            this.bWyczysc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bWyczysc.Location = new System.Drawing.Point(15, 85);
            this.bWyczysc.Name = "bWyczysc";
            this.bWyczysc.Size = new System.Drawing.Size(120, 46);
            this.bWyczysc.TabIndex = 5;
            this.bWyczysc.Text = "Wyczyść obraz";
            this.bWyczysc.UseVisualStyleBackColor = true;
            this.bWyczysc.Click += new System.EventHandler(this.bWyczysc_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(14, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tło";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bKwadart
            // 
            this.bKwadart.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bKwadart.Image = ((System.Drawing.Image)(resources.GetObject("bKwadart.Image")));
            this.bKwadart.Location = new System.Drawing.Point(69, 394);
            this.bKwadart.Name = "bKwadart";
            this.bKwadart.Size = new System.Drawing.Size(45, 38);
            this.bKwadart.TabIndex = 7;
            this.bKwadart.Text = "Kwadrat";
            this.bKwadart.UseVisualStyleBackColor = true;
            this.bKwadart.Click += new System.EventHandler(this.bKwadart_Click);
            // 
            // bProst
            // 
            this.bProst.Location = new System.Drawing.Point(69, 350);
            this.bProst.Name = "bProst";
            this.bProst.Size = new System.Drawing.Size(45, 38);
            this.bProst.TabIndex = 7;
            this.bProst.Text = "Prostokąt";
            this.bProst.UseVisualStyleBackColor = true;
            this.bProst.Click += new System.EventHandler(this.bProst_Click);
            // 
            // bKolo
            // 
            this.bKolo.Location = new System.Drawing.Point(12, 394);
            this.bKolo.Name = "bKolo";
            this.bKolo.Size = new System.Drawing.Size(45, 38);
            this.bKolo.TabIndex = 7;
            this.bKolo.Text = "Koło";
            this.bKolo.UseVisualStyleBackColor = true;
            this.bKolo.Click += new System.EventHandler(this.bKolo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wysokość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Szerokość";
            // 
            // textBox_szer
            // 
            this.textBox_szer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_szer.Location = new System.Drawing.Point(69, 468);
            this.textBox_szer.Name = "textBox_szer";
            this.textBox_szer.Size = new System.Drawing.Size(49, 20);
            this.textBox_szer.TabIndex = 2;
            this.textBox_szer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_wys
            // 
            this.textBox_wys.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_wys.Location = new System.Drawing.Point(69, 441);
            this.textBox_wys.Name = "textBox_wys";
            this.textBox_wys.Size = new System.Drawing.Size(49, 20);
            this.textBox_wys.TabIndex = 2;
            this.textBox_wys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bTekst
            // 
            this.bTekst.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bTekst.Location = new System.Drawing.Point(15, 137);
            this.bTekst.Name = "bTekst";
            this.bTekst.Size = new System.Drawing.Size(50, 61);
            this.bTekst.TabIndex = 8;
            this.bTekst.Text = "Tekst";
            this.bTekst.UseVisualStyleBackColor = true;
            this.bTekst.Click += new System.EventHandler(this.bTekst_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 137);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 61);
            this.textBox2.TabIndex = 9;
            // 
            // dGrubosc
            // 
            this.dGrubosc.Location = new System.Drawing.Point(69, 23);
            this.dGrubosc.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.dGrubosc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dGrubosc.Name = "dGrubosc";
            this.dGrubosc.Size = new System.Drawing.Size(60, 20);
            this.dGrubosc.TabIndex = 10;
            this.dGrubosc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bGumka
            // 
            this.bGumka.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bGumka.Location = new System.Drawing.Point(12, 350);
            this.bGumka.Name = "bGumka";
            this.bGumka.Size = new System.Drawing.Size(45, 38);
            this.bGumka.TabIndex = 11;
            this.bGumka.Text = "Gumka";
            this.bGumka.UseVisualStyleBackColor = true;
            this.bGumka.Click += new System.EventHandler(this.bGumka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 506);
            this.Controls.Add(this.bGumka);
            this.Controls.Add(this.dGrubosc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bTekst);
            this.Controls.Add(this.bKolo);
            this.Controls.Add(this.bProst);
            this.Controls.Add(this.bKwadart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bWyczysc);
            this.Controls.Add(this.bKolor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_szer);
            this.Controls.Add(this.textBox_wys);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGrubosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bKolor;
        private System.Windows.Forms.Button bWyczysc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bKwadart;
        private System.Windows.Forms.Button bProst;
        private System.Windows.Forms.Button bKolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox textBox_szer;
        protected System.Windows.Forms.TextBox textBox_wys;
        private System.Windows.Forms.Button bTekst;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown dGrubosc;
        private System.Windows.Forms.Button bGumka;
    }
}

