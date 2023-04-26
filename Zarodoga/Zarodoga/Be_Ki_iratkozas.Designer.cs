namespace Zarodoga
{
    partial class Be_Ki_iratkozas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Be_Ki_iratkozas));
            this.listBox_Lista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IG_szam = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_datum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_isk_nev = new System.Windows.Forms.ComboBox();
            this.comboBox_ki_be = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Szerkeszt = new System.Windows.Forms.Button();
            this.Button_Hozzaadd = new System.Windows.Forms.Button();
            this.Button_Torol = new System.Windows.Forms.Button();
            this.button_kereses = new System.Windows.Forms.Button();
            this.button_keresestorol = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_frissit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Lista
            // 
            this.listBox_Lista.FormattingEnabled = true;
            this.listBox_Lista.Location = new System.Drawing.Point(12, 12);
            this.listBox_Lista.Name = "listBox_Lista";
            this.listBox_Lista.Size = new System.Drawing.Size(194, 368);
            this.listBox_Lista.TabIndex = 0;
            this.listBox_Lista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(230, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diak IG Szam *";
            // 
            // textBox_IG_szam
            // 
            this.textBox_IG_szam.Location = new System.Drawing.Point(359, 70);
            this.textBox_IG_szam.Name = "textBox_IG_szam";
            this.textBox_IG_szam.Size = new System.Drawing.Size(170, 20);
            this.textBox_IG_szam.TabIndex = 2;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(359, 132);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(170, 20);
            this.textBox_nev.TabIndex = 3;
            // 
            // textBox_datum
            // 
            this.textBox_datum.Location = new System.Drawing.Point(359, 301);
            this.textBox_datum.Name = "textBox_datum";
            this.textBox_datum.Size = new System.Drawing.Size(170, 20);
            this.textBox_datum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(230, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nev";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(230, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum";
            // 
            // comboBox_isk_nev
            // 
            this.comboBox_isk_nev.FormattingEnabled = true;
            this.comboBox_isk_nev.Items.AddRange(new object[] {
            "Bardos Lajos Altalános Iskola",
            "Gönczy Pál Református és Két  Tannyelvű Általános Iskola",
            "Thököly Imre Kéttannyelvű Általános Iskola",
            "Nagyrábé Mórincz Zsigmond Általános Iskola",
            "Éltes Lajos Általános Iskola",
            "Arany János Magyar-Angol Két Tanítási Nyelvű Általános Iskola ",
            "Diószegi Lajos Általános Iskola",
            "Kövy Sándor Általános Iskola "});
            this.comboBox_isk_nev.Location = new System.Drawing.Point(359, 184);
            this.comboBox_isk_nev.Name = "comboBox_isk_nev";
            this.comboBox_isk_nev.Size = new System.Drawing.Size(170, 21);
            this.comboBox_isk_nev.TabIndex = 7;
            // 
            // comboBox_ki_be
            // 
            this.comboBox_ki_be.FormattingEnabled = true;
            this.comboBox_ki_be.Items.AddRange(new object[] {
            "Ki iratkozott",
            "Be iratkozott"});
            this.comboBox_ki_be.Location = new System.Drawing.Point(359, 241);
            this.comboBox_ki_be.Name = "comboBox_ki_be";
            this.comboBox_ki_be.Size = new System.Drawing.Size(170, 21);
            this.comboBox_ki_be.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(230, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Iskola Nev";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(230, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ki vagy Be";
            // 
            // Button_Szerkeszt
            // 
            this.Button_Szerkeszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Szerkeszt.Location = new System.Drawing.Point(658, 38);
            this.Button_Szerkeszt.Name = "Button_Szerkeszt";
            this.Button_Szerkeszt.Size = new System.Drawing.Size(97, 27);
            this.Button_Szerkeszt.TabIndex = 11;
            this.Button_Szerkeszt.Text = "Szerkeszt";
            this.Button_Szerkeszt.UseVisualStyleBackColor = true;
            this.Button_Szerkeszt.Click += new System.EventHandler(this.Szerkeszt_Click);
            // 
            // Button_Hozzaadd
            // 
            this.Button_Hozzaadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Hozzaadd.Location = new System.Drawing.Point(658, 85);
            this.Button_Hozzaadd.Name = "Button_Hozzaadd";
            this.Button_Hozzaadd.Size = new System.Drawing.Size(97, 27);
            this.Button_Hozzaadd.TabIndex = 12;
            this.Button_Hozzaadd.Text = "Hozzáadd";
            this.Button_Hozzaadd.UseVisualStyleBackColor = true;
            this.Button_Hozzaadd.Click += new System.EventHandler(this.Hozzáadd_Click);
            // 
            // Button_Torol
            // 
            this.Button_Torol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Torol.Location = new System.Drawing.Point(658, 129);
            this.Button_Torol.Name = "Button_Torol";
            this.Button_Torol.Size = new System.Drawing.Size(97, 27);
            this.Button_Torol.TabIndex = 13;
            this.Button_Torol.Text = "Töröl";
            this.Button_Torol.UseVisualStyleBackColor = true;
            this.Button_Torol.Click += new System.EventHandler(this.Töröl_Click);
            // 
            // button_kereses
            // 
            this.button_kereses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_kereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_kereses.ForeColor = System.Drawing.Color.LightPink;
            this.button_kereses.Image = ((System.Drawing.Image)(resources.GetObject("button_kereses.Image")));
            this.button_kereses.Location = new System.Drawing.Point(359, 341);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(75, 39);
            this.button_kereses.TabIndex = 14;
            this.button_kereses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_kereses.UseVisualStyleBackColor = true;
            this.button_kereses.Click += new System.EventHandler(this.button_kereses_Click);
            // 
            // button_keresestorol
            // 
            this.button_keresestorol.Location = new System.Drawing.Point(440, 341);
            this.button_keresestorol.Name = "button_keresestorol";
            this.button_keresestorol.Size = new System.Drawing.Size(75, 39);
            this.button_keresestorol.TabIndex = 15;
            this.button_keresestorol.Text = "Keresés Törlése";
            this.button_keresestorol.UseVisualStyleBackColor = true;
            this.button_keresestorol.Click += new System.EventHandler(this.button_keresestorol_Click);
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_back.BackgroundImage")));
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_back.Location = new System.Drawing.Point(701, 397);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(87, 41);
            this.button_back.TabIndex = 16;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_frissit
            // 
            this.button_frissit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_frissit.BackgroundImage")));
            this.button_frissit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_frissit.Location = new System.Drawing.Point(608, 397);
            this.button_frissit.Name = "button_frissit";
            this.button_frissit.Size = new System.Drawing.Size(87, 41);
            this.button_frissit.TabIndex = 17;
            this.button_frissit.UseVisualStyleBackColor = true;
            this.button_frissit.Click += new System.EventHandler(this.button_frissit_Click);
            // 
            // Be_Ki_iratkozas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_frissit);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_keresestorol);
            this.Controls.Add(this.button_kereses);
            this.Controls.Add(this.Button_Torol);
            this.Controls.Add(this.Button_Hozzaadd);
            this.Controls.Add(this.Button_Szerkeszt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_ki_be);
            this.Controls.Add(this.comboBox_isk_nev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_datum);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.textBox_IG_szam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Be_Ki_iratkozas";
            this.Text = "Be_Ki_iratkozas";
            this.Load += new System.EventHandler(this.Be_Ki_iratkozas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Szerkeszt;
        private System.Windows.Forms.Button Button_Hozzaadd;
        private System.Windows.Forms.Button Button_Torol;
        public System.Windows.Forms.TextBox textBox_IG_szam;
        public System.Windows.Forms.TextBox textBox_datum;
        public System.Windows.Forms.ComboBox comboBox_isk_nev;
        public System.Windows.Forms.ComboBox comboBox_ki_be;
        public System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.Button button_keresestorol;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_frissit;
    }
}