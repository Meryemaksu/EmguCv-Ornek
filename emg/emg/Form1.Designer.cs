namespace emg
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
            this.ımageBox1 = new Emgu.CV.UI.ImageBox();
            this.gritondnstr = new System.Windows.Forms.Button();
            this.histogramadnstr = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.resimsc = new System.Windows.Forms.Button();
            this.ımagebox2 = new Emgu.CV.UI.ImageBox();
            this.binarydnstr = new System.Windows.Forms.Button();
            this.ımageBox3 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımagebox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageBox1
            // 
            this.ımageBox1.Location = new System.Drawing.Point(336, 70);
            this.ımageBox1.Name = "ımageBox1";
            this.ımageBox1.Size = new System.Drawing.Size(253, 231);
            this.ımageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ımageBox1.TabIndex = 2;
            this.ımageBox1.TabStop = false;
            // 
            // gritondnstr
            // 
            this.gritondnstr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gritondnstr.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gritondnstr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gritondnstr.Location = new System.Drawing.Point(333, 3);
            this.gritondnstr.Name = "gritondnstr";
            this.gritondnstr.Size = new System.Drawing.Size(108, 59);
            this.gritondnstr.TabIndex = 3;
            this.gritondnstr.Text = "Gri Tonlama";
            this.gritondnstr.UseVisualStyleBackColor = false;
            this.gritondnstr.Click += new System.EventHandler(this.button1_Click);
            // 
            // histogramadnstr
            // 
            this.histogramadnstr.BackColor = System.Drawing.Color.Fuchsia;
            this.histogramadnstr.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.histogramadnstr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.histogramadnstr.Location = new System.Drawing.Point(350, 327);
            this.histogramadnstr.Name = "histogramadnstr";
            this.histogramadnstr.Size = new System.Drawing.Size(108, 57);
            this.histogramadnstr.TabIndex = 4;
            this.histogramadnstr.Text = "Histogram";
            this.histogramadnstr.UseVisualStyleBackColor = false;
            this.histogramadnstr.Click += new System.EventHandler(this.button2_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(350, 410);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(252, 231);
            this.histogramBox1.TabIndex = 5;
            this.histogramBox1.Load += new System.EventHandler(this.histogramBox1_Load);
            // 
            // resimsc
            // 
            this.resimsc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resimsc.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimsc.ForeColor = System.Drawing.Color.Indigo;
            this.resimsc.Location = new System.Drawing.Point(13, 5);
            this.resimsc.Name = "resimsc";
            this.resimsc.Size = new System.Drawing.Size(108, 56);
            this.resimsc.TabIndex = 6;
            this.resimsc.Text = "Resim Seç";
            this.resimsc.UseVisualStyleBackColor = false;
            this.resimsc.Click += new System.EventHandler(this.button3_Click);
            // 
            // ımagebox2
            // 
            this.ımagebox2.Location = new System.Drawing.Point(18, 69);
            this.ımagebox2.Name = "ımagebox2";
            this.ımagebox2.Size = new System.Drawing.Size(279, 242);
            this.ımagebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ımagebox2.TabIndex = 2;
            this.ımagebox2.TabStop = false;
            // 
            // binarydnstr
            // 
            this.binarydnstr.BackColor = System.Drawing.Color.Thistle;
            this.binarydnstr.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.binarydnstr.ForeColor = System.Drawing.Color.DarkRed;
            this.binarydnstr.Location = new System.Drawing.Point(18, 325);
            this.binarydnstr.Name = "binarydnstr";
            this.binarydnstr.Size = new System.Drawing.Size(129, 59);
            this.binarydnstr.TabIndex = 7;
            this.binarydnstr.Text = "Binary Dönüştür";
            this.binarydnstr.UseVisualStyleBackColor = false;
            this.binarydnstr.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageBox3
            // 
            this.ımageBox3.Location = new System.Drawing.Point(18, 390);
            this.ımageBox3.Name = "ımageBox3";
            this.ımageBox3.Size = new System.Drawing.Size(257, 251);
            this.ımageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ımageBox3.TabIndex = 2;
            this.ımageBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(621, 655);
            this.Controls.Add(this.ımageBox3);
            this.Controls.Add(this.binarydnstr);
            this.Controls.Add(this.ımagebox2);
            this.Controls.Add(this.resimsc);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.histogramadnstr);
            this.Controls.Add(this.gritondnstr);
            this.Controls.Add(this.ımageBox1);
            this.Name = "Form1";
            this.Text = "RESİM UYGULAMASI";
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımagebox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ımageBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox ımageBox1;
        private System.Windows.Forms.Button gritondnstr;
        private System.Windows.Forms.Button histogramadnstr;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private System.Windows.Forms.Button resimsc;
        private Emgu.CV.UI.ImageBox ımagebox2;
        private System.Windows.Forms.Button binarydnstr;
        private Emgu.CV.UI.ImageBox ımageBox3;
    }
}

