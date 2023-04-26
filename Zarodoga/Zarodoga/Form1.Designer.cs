namespace Zarodoga
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
            this.button_Dock = new System.Windows.Forms.Button();
            this.Button_Diak = new System.Windows.Forms.Button();
            this.button_ki_be = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Dock
            // 
            this.button_Dock.BackColor = System.Drawing.Color.Tan;
            this.button_Dock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Dock.BackgroundImage")));
            this.button_Dock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Dock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Dock.ForeColor = System.Drawing.Color.IndianRed;
            this.button_Dock.Location = new System.Drawing.Point(25, 44);
            this.button_Dock.Name = "button_Dock";
            this.button_Dock.Size = new System.Drawing.Size(97, 158);
            this.button_Dock.TabIndex = 1;
            this.button_Dock.Text = "Dockumentu-mok";
            this.button_Dock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Dock.UseVisualStyleBackColor = false;
            this.button_Dock.Click += new System.EventHandler(this.button_Dock_Click);
            // 
            // Button_Diak
            // 
            this.Button_Diak.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button_Diak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_Diak.BackgroundImage")));
            this.Button_Diak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button_Diak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Button_Diak.ForeColor = System.Drawing.Color.IndianRed;
            this.Button_Diak.Location = new System.Drawing.Point(535, 240);
            this.Button_Diak.Name = "Button_Diak";
            this.Button_Diak.Size = new System.Drawing.Size(97, 158);
            this.Button_Diak.TabIndex = 2;
            this.Button_Diak.Text = "Diak";
            this.Button_Diak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Diak.UseVisualStyleBackColor = false;
            this.Button_Diak.Click += new System.EventHandler(this.Button_Diak_Click);
            // 
            // button_ki_be
            // 
            this.button_ki_be.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button_ki_be.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ki_be.BackgroundImage")));
            this.button_ki_be.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ki_be.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ki_be.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ki_be.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_ki_be.Location = new System.Drawing.Point(535, 44);
            this.button_ki_be.Name = "button_ki_be";
            this.button_ki_be.Size = new System.Drawing.Size(97, 158);
            this.button_ki_be.TabIndex = 3;
            this.button_ki_be.Text = "Ki/Be Iratkozás";
            this.button_ki_be.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_ki_be.UseVisualStyleBackColor = false;
            this.button_ki_be.Click += new System.EventHandler(this.button_ki_be_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_exit.BackgroundImage")));
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_exit.ForeColor = System.Drawing.Color.Maroon;
            this.button_exit.Location = new System.Drawing.Point(25, 240);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(97, 158);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Kilépés";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_ki_be);
            this.Controls.Add(this.Button_Diak);
            this.Controls.Add(this.button_Dock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kezdőlap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Dock;
        private System.Windows.Forms.Button Button_Diak;
        private System.Windows.Forms.Button button_ki_be;
        private System.Windows.Forms.Button button_exit;
    }
}

