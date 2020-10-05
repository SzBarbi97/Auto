namespace Auto
{
    partial class Form1_rendszam
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
            this.label1_rendszam = new System.Windows.Forms.Label();
            this.comboBox1_gepjarmuTipusa = new System.Windows.Forms.ComboBox();
            this.label1_gepjarmuTipusa = new System.Windows.Forms.Label();
            this.label2_gyartasiIdo = new System.Windows.Forms.Label();
            this.label3_teljesitmeny = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1_rogzitettAdatok = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_rendszam = new System.Windows.Forms.TextBox();
            this.textBox2_gyartasiIdo = new System.Windows.Forms.TextBox();
            this.textBox3_teljesitmeny = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1_rendszam
            // 
            this.label1_rendszam.AutoSize = true;
            this.label1_rendszam.Location = new System.Drawing.Point(19, 49);
            this.label1_rendszam.Name = "label1_rendszam";
            this.label1_rendszam.Size = new System.Drawing.Size(57, 13);
            this.label1_rendszam.TabIndex = 1;
            this.label1_rendszam.Text = "Rendszám";
            // 
            // comboBox1_gepjarmuTipusa
            // 
            this.comboBox1_gepjarmuTipusa.FormattingEnabled = true;
            this.comboBox1_gepjarmuTipusa.Items.AddRange(new object[] {
            "Opel",
            "BMW",
            "Audi",
            "Suzuki"});
            this.comboBox1_gepjarmuTipusa.Location = new System.Drawing.Point(110, 98);
            this.comboBox1_gepjarmuTipusa.Name = "comboBox1_gepjarmuTipusa";
            this.comboBox1_gepjarmuTipusa.Size = new System.Drawing.Size(121, 21);
            this.comboBox1_gepjarmuTipusa.TabIndex = 2;
            // 
            // label1_gepjarmuTipusa
            // 
            this.label1_gepjarmuTipusa.AutoSize = true;
            this.label1_gepjarmuTipusa.Location = new System.Drawing.Point(19, 98);
            this.label1_gepjarmuTipusa.Name = "label1_gepjarmuTipusa";
            this.label1_gepjarmuTipusa.Size = new System.Drawing.Size(85, 13);
            this.label1_gepjarmuTipusa.TabIndex = 3;
            this.label1_gepjarmuTipusa.Text = "Gépjármű típusa";
            // 
            // label2_gyartasiIdo
            // 
            this.label2_gyartasiIdo.AutoSize = true;
            this.label2_gyartasiIdo.Location = new System.Drawing.Point(19, 149);
            this.label2_gyartasiIdo.Name = "label2_gyartasiIdo";
            this.label2_gyartasiIdo.Size = new System.Drawing.Size(62, 13);
            this.label2_gyartasiIdo.TabIndex = 4;
            this.label2_gyartasiIdo.Text = "Gyártási idő";
            // 
            // label3_teljesitmeny
            // 
            this.label3_teljesitmeny.AutoSize = true;
            this.label3_teljesitmeny.Location = new System.Drawing.Point(19, 195);
            this.label3_teljesitmeny.Name = "label3_teljesitmeny";
            this.label3_teljesitmeny.Size = new System.Drawing.Size(67, 13);
            this.label3_teljesitmeny.TabIndex = 6;
            this.label3_teljesitmeny.Text = "Teljesítmény";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Adatok rögzítése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1_rogzitettAdatok
            // 
            this.listBox1_rogzitettAdatok.FormattingEnabled = true;
            this.listBox1_rogzitettAdatok.Location = new System.Drawing.Point(365, 43);
            this.listBox1_rogzitettAdatok.Name = "listBox1_rogzitettAdatok";
            this.listBox1_rogzitettAdatok.Size = new System.Drawing.Size(409, 56);
            this.listBox1_rogzitettAdatok.TabIndex = 9;
            this.listBox1_rogzitettAdatok.SelectedIndexChanged += new System.EventHandler(this.listBox1_rogzitettAdatok_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rögzített adatok";
            // 
            // textBox1_rendszam
            // 
            this.textBox1_rendszam.Location = new System.Drawing.Point(111, 49);
            this.textBox1_rendszam.Name = "textBox1_rendszam";
            this.textBox1_rendszam.Size = new System.Drawing.Size(120, 20);
            this.textBox1_rendszam.TabIndex = 11;
            // 
            // textBox2_gyartasiIdo
            // 
            this.textBox2_gyartasiIdo.Location = new System.Drawing.Point(111, 149);
            this.textBox2_gyartasiIdo.Name = "textBox2_gyartasiIdo";
            this.textBox2_gyartasiIdo.Size = new System.Drawing.Size(120, 20);
            this.textBox2_gyartasiIdo.TabIndex = 12;
            // 
            // textBox3_teljesitmeny
            // 
            this.textBox3_teljesitmeny.Location = new System.Drawing.Point(111, 195);
            this.textBox3_teljesitmeny.Name = "textBox3_teljesitmeny";
            this.textBox3_teljesitmeny.Size = new System.Drawing.Size(120, 20);
            this.textBox3_teljesitmeny.TabIndex = 13;
            // 
            // Form1_rendszam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3_teljesitmeny);
            this.Controls.Add(this.textBox2_gyartasiIdo);
            this.Controls.Add(this.textBox1_rendszam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1_rogzitettAdatok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3_teljesitmeny);
            this.Controls.Add(this.label2_gyartasiIdo);
            this.Controls.Add(this.label1_gepjarmuTipusa);
            this.Controls.Add(this.comboBox1_gepjarmuTipusa);
            this.Controls.Add(this.label1_rendszam);
            this.Name = "Form1_rendszam";
            this.Text = "Gépjármű adatok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1_rendszam;
        private System.Windows.Forms.ComboBox comboBox1_gepjarmuTipusa;
        private System.Windows.Forms.Label label1_gepjarmuTipusa;
        private System.Windows.Forms.Label label2_gyartasiIdo;
        private System.Windows.Forms.Label label3_teljesitmeny;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1_rogzitettAdatok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_rendszam;
        private System.Windows.Forms.TextBox textBox2_gyartasiIdo;
        private System.Windows.Forms.TextBox textBox3_teljesitmeny;
    }
}

