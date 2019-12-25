namespace SoruApp
{
    partial class sınav
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
            this.lbl_soru = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_soru
            // 
            this.lbl_soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soru.Location = new System.Drawing.Point(143, 34);
            this.lbl_soru.Name = "lbl_soru";
            this.lbl_soru.Size = new System.Drawing.Size(694, 143);
            this.lbl_soru.TabIndex = 0;
            this.lbl_soru.Text = "Soru labeliaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" +
    "aa";
            this.lbl_soru.Click += new System.EventHandler(this.lbl_soru_Click);
            // 
            // lbl_b
            // 
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_b.Location = new System.Drawing.Point(565, 208);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(366, 102);
            this.lbl_b.TabIndex = 1;
            this.lbl_b.Text = "B şıkkı";
            this.lbl_b.Click += new System.EventHandler(this.lbl_b_Click);
            // 
            // lbl_c
            // 
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_c.Location = new System.Drawing.Point(99, 359);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(424, 102);
            this.lbl_c.TabIndex = 2;
            this.lbl_c.Text = "C şıkkı";
            // 
            // lbl_a
            // 
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_a.Location = new System.Drawing.Point(99, 208);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(415, 102);
            this.lbl_a.TabIndex = 3;
            this.lbl_a.Text = "A şıkkı";
            this.lbl_a.Click += new System.EventHandler(this.lbl_a_Click);
            // 
            // lbl_d
            // 
            this.lbl_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_d.Location = new System.Drawing.Point(565, 359);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(366, 102);
            this.lbl_d.TabIndex = 4;
            this.lbl_d.Text = "D şıkkı";
            // 
            // sınav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 537);
            this.Controls.Add(this.lbl_d);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.lbl_c);
            this.Controls.Add(this.lbl_b);
            this.Controls.Add(this.lbl_soru);
            this.Name = "sınav";
            this.Text = "sınav";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_soru;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_d;
    }
}