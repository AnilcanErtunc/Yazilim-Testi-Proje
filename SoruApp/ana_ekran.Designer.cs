namespace SoruApp
{
    partial class ana_ekran
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnsınavagir = new System.Windows.Forms.Button();
            this.grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.isimtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafik)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsınavagir
            // 
            this.btnsınavagir.Location = new System.Drawing.Point(74, 71);
            this.btnsınavagir.Name = "btnsınavagir";
            this.btnsınavagir.Size = new System.Drawing.Size(171, 92);
            this.btnsınavagir.TabIndex = 0;
            this.btnsınavagir.Text = "Sınava Başla";
            this.btnsınavagir.UseVisualStyleBackColor = true;
            // 
            // grafik
            // 
            this.grafik.BackColor = System.Drawing.Color.Transparent;
            this.grafik.BorderlineColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.grafik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafik.Legends.Add(legend1);
            this.grafik.Location = new System.Drawing.Point(363, 247);
            this.grafik.Name = "grafik";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "konuData";
            series1.YValuesPerPoint = 4;
            this.grafik.Series.Add(series1);
            this.grafik.Size = new System.Drawing.Size(584, 300);
            this.grafik.TabIndex = 1;
            this.grafik.Text = "grafik";
            // 
            // btnistatistik
            // 
            this.btnistatistik.Location = new System.Drawing.Point(74, 218);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(171, 92);
            this.btnistatistik.TabIndex = 2;
            this.btnistatistik.Text = "İstatistik Görüntüle";
            this.btnistatistik.UseVisualStyleBackColor = true;
            // 
            // isimtxt
            // 
            this.isimtxt.AutoSize = true;
            this.isimtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimtxt.Location = new System.Drawing.Point(758, 31);
            this.isimtxt.Name = "isimtxt";
            this.isimtxt.Size = new System.Drawing.Size(149, 20);
            this.isimtxt.TabIndex = 3;
            this.isimtxt.Text = "Merhaba Asdasd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(538, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genel Başarım";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ana_ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isimtxt);
            this.Controls.Add(this.btnistatistik);
            this.Controls.Add(this.grafik);
            this.Controls.Add(this.btnsınavagir);
            this.Name = "ana_ekran";
            this.Text = "ana_ekran";
            ((System.ComponentModel.ISupportInitialize)(this.grafik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsınavagir;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafik;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Label isimtxt;
        private System.Windows.Forms.Label label1;
    }
}