namespace damajatek_KKG_SZR_LA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jatekos1_TBOX = new System.Windows.Forms.TextBox();
            this.jatekos2_TBOX = new System.Windows.Forms.TextBox();
            this.start_BTN = new System.Windows.Forms.Button();
            this.ujjatek_BTN = new System.Windows.Forms.Button();
            this.imagelist = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.szabalyok_BTN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjon meg egy nevet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adjon meg egy nevet:";
            // 
            // jatekos1_TBOX
            // 
            this.jatekos1_TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos1_TBOX.Location = new System.Drawing.Point(234, 81);
            this.jatekos1_TBOX.Name = "jatekos1_TBOX";
            this.jatekos1_TBOX.Size = new System.Drawing.Size(100, 26);
            this.jatekos1_TBOX.TabIndex = 2;
            // 
            // jatekos2_TBOX
            // 
            this.jatekos2_TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos2_TBOX.Location = new System.Drawing.Point(234, 121);
            this.jatekos2_TBOX.Name = "jatekos2_TBOX";
            this.jatekos2_TBOX.Size = new System.Drawing.Size(100, 26);
            this.jatekos2_TBOX.TabIndex = 3;
            // 
            // start_BTN
            // 
            this.start_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_BTN.Location = new System.Drawing.Point(62, 175);
            this.start_BTN.Name = "start_BTN";
            this.start_BTN.Size = new System.Drawing.Size(113, 56);
            this.start_BTN.TabIndex = 4;
            this.start_BTN.Text = "Játék indítása";
            this.start_BTN.UseVisualStyleBackColor = true;
            this.start_BTN.Click += new System.EventHandler(this.start_BTN_Click);
            // 
            // ujjatek_BTN
            // 
            this.ujjatek_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujjatek_BTN.Location = new System.Drawing.Point(62, 327);
            this.ujjatek_BTN.Name = "ujjatek_BTN";
            this.ujjatek_BTN.Size = new System.Drawing.Size(113, 56);
            this.ujjatek_BTN.TabIndex = 5;
            this.ujjatek_BTN.Text = "Új játék";
            this.ujjatek_BTN.UseVisualStyleBackColor = true;
            this.ujjatek_BTN.Visible = false;
            // 
            // imagelist
            // 
            this.imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist.ImageStream")));
            this.imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist.Images.SetKeyName(0, "feka.png");
            this.imagelist.Images.SetKeyName(1, "feher.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::damajatek_KKG_SZR_LA.Properties.Resources.tabla;
            this.pictureBox1.Location = new System.Drawing.Point(366, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 395);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // szabalyok_BTN
            // 
            this.szabalyok_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.szabalyok_BTN.Location = new System.Drawing.Point(62, 248);
            this.szabalyok_BTN.Name = "szabalyok_BTN";
            this.szabalyok_BTN.Size = new System.Drawing.Size(113, 56);
            this.szabalyok_BTN.TabIndex = 7;
            this.szabalyok_BTN.Text = "Szabályok";
            this.szabalyok_BTN.UseVisualStyleBackColor = true;
            this.szabalyok_BTN.Click += new System.EventHandler(this.szabalyok_BTN_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 311);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(788, 166);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::damajatek_KKG_SZR_LA.Properties.Resources.nyooo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 477);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.szabalyok_BTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ujjatek_BTN);
            this.Controls.Add(this.start_BTN);
            this.Controls.Add(this.jatekos2_TBOX);
            this.Controls.Add(this.jatekos1_TBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dámajáték";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jatekos1_TBOX;
        private System.Windows.Forms.TextBox jatekos2_TBOX;
        private System.Windows.Forms.Button start_BTN;
        private System.Windows.Forms.Button ujjatek_BTN;
        private System.Windows.Forms.ImageList imagelist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button szabalyok_BTN;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

