namespace sinWave
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartSygnal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnWyznaczHz = new System.Windows.Forms.Button();
            this.chartHz = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Fazy = new System.Windows.Forms.RichTextBox();
            this.btnGenProsto = new System.Windows.Forms.Button();
            this.btnGenPilo = new System.Windows.Forms.Button();
            this.btnGenLosowy = new System.Windows.Forms.Button();
            this.tbZakres = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSygnal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZakres)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSygnal
            // 
            chartArea13.Name = "ChartArea1";
            this.chartSygnal.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chartSygnal.Legends.Add(legend13);
            this.chartSygnal.Location = new System.Drawing.Point(22, 2);
            this.chartSygnal.Name = "chartSygnal";
            this.chartSygnal.Size = new System.Drawing.Size(819, 300);
            this.chartSygnal.TabIndex = 0;
            this.chartSygnal.Text = "chart1";
            // 
            // btnWyznaczHz
            // 
            this.btnWyznaczHz.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWyznaczHz.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWyznaczHz.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWyznaczHz.Location = new System.Drawing.Point(847, 2);
            this.btnWyznaczHz.Name = "btnWyznaczHz";
            this.btnWyznaczHz.Size = new System.Drawing.Size(415, 131);
            this.btnWyznaczHz.TabIndex = 1;
            this.btnWyznaczHz.Text = "Wyznacz Hz";
            this.btnWyznaczHz.UseVisualStyleBackColor = false;
            this.btnWyznaczHz.Click += new System.EventHandler(this.btnWyznaczHz_Click);
            // 
            // chartHz
            // 
            chartArea14.Name = "ChartArea1";
            this.chartHz.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chartHz.Legends.Add(legend14);
            this.chartHz.Location = new System.Drawing.Point(22, 308);
            this.chartHz.Name = "chartHz";
            this.chartHz.Size = new System.Drawing.Size(819, 300);
            this.chartHz.TabIndex = 2;
            this.chartHz.Text = "chart2";
            // 
            // Fazy
            // 
            this.Fazy.Location = new System.Drawing.Point(847, 350);
            this.Fazy.Name = "Fazy";
            this.Fazy.Size = new System.Drawing.Size(408, 258);
            this.Fazy.TabIndex = 3;
            this.Fazy.Text = "";
            // 
            // btnGenProsto
            // 
            this.btnGenProsto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenProsto.Location = new System.Drawing.Point(847, 139);
            this.btnGenProsto.Name = "btnGenProsto";
            this.btnGenProsto.Size = new System.Drawing.Size(194, 48);
            this.btnGenProsto.TabIndex = 4;
            this.btnGenProsto.Text = "generuj sygnał prostokątny";
            this.btnGenProsto.UseVisualStyleBackColor = true;
            this.btnGenProsto.Click += new System.EventHandler(this.btnGenProsto_Click);
            // 
            // btnGenPilo
            // 
            this.btnGenPilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenPilo.Location = new System.Drawing.Point(1047, 139);
            this.btnGenPilo.Name = "btnGenPilo";
            this.btnGenPilo.Size = new System.Drawing.Size(215, 48);
            this.btnGenPilo.TabIndex = 5;
            this.btnGenPilo.Text = "generuj sygnał piłokształtny";
            this.btnGenPilo.UseVisualStyleBackColor = true;
            this.btnGenPilo.Click += new System.EventHandler(this.btnGenPilo_Click);
            // 
            // btnGenLosowy
            // 
            this.btnGenLosowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenLosowy.Location = new System.Drawing.Point(847, 193);
            this.btnGenLosowy.Name = "btnGenLosowy";
            this.btnGenLosowy.Size = new System.Drawing.Size(415, 48);
            this.btnGenLosowy.TabIndex = 6;
            this.btnGenLosowy.Text = "generuj sygnał o losowych amplitudach";
            this.btnGenLosowy.UseVisualStyleBackColor = true;
            this.btnGenLosowy.Click += new System.EventHandler(this.btnGenLosowy_Click);
            // 
            // tbZakres
            // 
            this.tbZakres.Location = new System.Drawing.Point(867, 271);
            this.tbZakres.Maximum = 111;
            this.tbZakres.Minimum = 1;
            this.tbZakres.Name = "tbZakres";
            this.tbZakres.Size = new System.Drawing.Size(372, 56);
            this.tbZakres.TabIndex = 7;
            this.tbZakres.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(918, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "zakres częstotliwości sygnału [Hz]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(847, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1228, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "111";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1267, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbZakres);
            this.Controls.Add(this.btnGenLosowy);
            this.Controls.Add(this.btnGenPilo);
            this.Controls.Add(this.btnGenProsto);
            this.Controls.Add(this.Fazy);
            this.Controls.Add(this.chartHz);
            this.Controls.Add(this.btnWyznaczHz);
            this.Controls.Add(this.chartSygnal);
            this.Name = "Form1";
            this.Text = "DFFT";
            ((System.ComponentModel.ISupportInitialize)(this.chartSygnal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbZakres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSygnal;
        private System.Windows.Forms.Button btnWyznaczHz;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHz;
        private System.Windows.Forms.RichTextBox Fazy;
        private System.Windows.Forms.Button btnGenProsto;
        private System.Windows.Forms.Button btnGenPilo;
        private System.Windows.Forms.Button btnGenLosowy;
        private System.Windows.Forms.TrackBar tbZakres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

