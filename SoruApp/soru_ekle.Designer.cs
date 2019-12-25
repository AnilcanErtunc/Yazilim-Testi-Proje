namespace SoruApp
{
    partial class soru_ekle
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
            this.textBoxSoru = new System.Windows.Forms.TextBox();
            this.comboBoxKonu = new System.Windows.Forms.ComboBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxDogru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSoruEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSoru
            // 
            this.textBoxSoru.Location = new System.Drawing.Point(160, 86);
            this.textBoxSoru.Multiline = true;
            this.textBoxSoru.Name = "textBoxSoru";
            this.textBoxSoru.Size = new System.Drawing.Size(477, 156);
            this.textBoxSoru.TabIndex = 0;
            this.textBoxSoru.TextChanged += new System.EventHandler(this.textBoxSoru_TextChanged);
            // 
            // comboBoxKonu
            // 
            this.comboBoxKonu.FormattingEnabled = true;
            this.comboBoxKonu.Location = new System.Drawing.Point(781, 86);
            this.comboBoxKonu.Name = "comboBoxKonu";
            this.comboBoxKonu.Size = new System.Drawing.Size(185, 24);
            this.comboBoxKonu.TabIndex = 1;
            this.comboBoxKonu.SelectedIndexChanged += new System.EventHandler(this.comboBoxKonu_SelectedIndexChanged);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(115, 309);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(350, 104);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(665, 309);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(350, 104);
            this.textBoxB.TabIndex = 3;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(115, 447);
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(350, 104);
            this.textBoxC.TabIndex = 4;
            // 
            // textBoxDogru
            // 
            this.textBoxDogru.Location = new System.Drawing.Point(665, 447);
            this.textBoxDogru.Multiline = true;
            this.textBoxDogru.Name = "textBoxDogru";
            this.textBoxDogru.Size = new System.Drawing.Size(350, 104);
            this.textBoxDogru.TabIndex = 5;
            this.textBoxDogru.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(682, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Konu :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(110, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şıklar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(155, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Soru :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonSoruEkle
            // 
            this.buttonSoruEkle.Location = new System.Drawing.Point(712, 161);
            this.buttonSoruEkle.Name = "buttonSoruEkle";
            this.buttonSoruEkle.Size = new System.Drawing.Size(202, 81);
            this.buttonSoruEkle.TabIndex = 16;
            this.buttonSoruEkle.Text = "Soruyu Ekle";
            this.buttonSoruEkle.UseVisualStyleBackColor = true;
            this.buttonSoruEkle.Click += new System.EventHandler(this.buttonSoruEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(520, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Doğru Cevap :";
            // 
            // soru_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSoruEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDogru);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.comboBoxKonu);
            this.Controls.Add(this.textBoxSoru);
            this.Name = "soru_ekle";
            this.Text = "Soru Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSoru;
        private System.Windows.Forms.ComboBox comboBoxKonu;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxDogru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSoruEkle;
        private System.Windows.Forms.Label label1;
    }
}