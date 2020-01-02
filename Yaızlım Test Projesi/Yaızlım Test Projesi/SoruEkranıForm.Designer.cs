namespace Yaızlım_Test_Projesi
{
    partial class SoruEkranıForm
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
            this.SoruLabel = new System.Windows.Forms.Label();
            this.radioButtonASIKKI = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.SinaviBaslatButton = new System.Windows.Forms.Button();
            this.KacinicSoruLABEL = new System.Windows.Forms.Label();
            this.buttonBitir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SoruLabel
            // 
            this.SoruLabel.AutoSize = true;
            this.SoruLabel.Location = new System.Drawing.Point(27, 41);
            this.SoruLabel.Name = "SoruLabel";
            this.SoruLabel.Size = new System.Drawing.Size(74, 13);
            this.SoruLabel.TabIndex = 0;
            this.SoruLabel.Text = "SORU LABEL";
            // 
            // radioButtonASIKKI
            // 
            this.radioButtonASIKKI.AutoSize = true;
            this.radioButtonASIKKI.Location = new System.Drawing.Point(109, 206);
            this.radioButtonASIKKI.Name = "radioButtonASIKKI";
            this.radioButtonASIKKI.Size = new System.Drawing.Size(62, 17);
            this.radioButtonASIKKI.TabIndex = 1;
            this.radioButtonASIKKI.TabStop = true;
            this.radioButtonASIKKI.Text = "A SIKKI";
            this.radioButtonASIKKI.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(109, 315);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(62, 17);
            this.radioButtonC.TabIndex = 1;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C SIKKI";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(109, 259);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(62, 17);
            this.radioButtonB.TabIndex = 1;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B SIKKI";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(109, 374);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(63, 17);
            this.radioButtonD.TabIndex = 1;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D SIKKI";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // SinaviBaslatButton
            // 
            this.SinaviBaslatButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SinaviBaslatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinaviBaslatButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SinaviBaslatButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SinaviBaslatButton.Location = new System.Drawing.Point(109, 433);
            this.SinaviBaslatButton.Name = "SinaviBaslatButton";
            this.SinaviBaslatButton.Size = new System.Drawing.Size(142, 59);
            this.SinaviBaslatButton.TabIndex = 2;
            this.SinaviBaslatButton.Text = "Sınavı Başlat Ve Sonraki Soruya Geç";
            this.SinaviBaslatButton.UseVisualStyleBackColor = false;
            this.SinaviBaslatButton.Click += new System.EventHandler(this.CevapButton_Click);
            // 
            // KacinicSoruLABEL
            // 
            this.KacinicSoruLABEL.AutoSize = true;
            this.KacinicSoruLABEL.Location = new System.Drawing.Point(8, 41);
            this.KacinicSoruLABEL.Name = "KacinicSoruLABEL";
            this.KacinicSoruLABEL.Size = new System.Drawing.Size(16, 13);
            this.KacinicSoruLABEL.TabIndex = 3;
            this.KacinicSoruLABEL.Text = "1-";
            this.KacinicSoruLABEL.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonBitir
            // 
            this.buttonBitir.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBitir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBitir.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBitir.Location = new System.Drawing.Point(420, 447);
            this.buttonBitir.Name = "buttonBitir";
            this.buttonBitir.Size = new System.Drawing.Size(120, 31);
            this.buttonBitir.TabIndex = 4;
            this.buttonBitir.Text = "Sınavı Bitir";
            this.buttonBitir.UseVisualStyleBackColor = false;
            this.buttonBitir.Click += new System.EventHandler(this.buttonBitir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 33);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sınav Ekranı";
            // 
            // SoruEkranıForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBitir);
            this.Controls.Add(this.KacinicSoruLABEL);
            this.Controls.Add(this.SinaviBaslatButton);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonASIKKI);
            this.Controls.Add(this.SoruLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoruEkranıForm";
            this.Text = "SoruEkranıForm";
            this.Load += new System.EventHandler(this.SoruEkranıForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SoruLabel;
        private System.Windows.Forms.RadioButton radioButtonASIKKI;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button SinaviBaslatButton;
        private System.Windows.Forms.Label KacinicSoruLABEL;
        private System.Windows.Forms.Button buttonBitir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}