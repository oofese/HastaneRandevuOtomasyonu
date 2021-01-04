namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.btnAra = new System.Windows.Forms.Button();
            this.btnGecmis = new System.Windows.Forms.Button();
            this.btnRecete = new System.Windows.Forms.Button();
            this.btnAyar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(46, 69);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 46);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "Randevu Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGecmis
            // 
            this.btnGecmis.Location = new System.Drawing.Point(171, 69);
            this.btnGecmis.Margin = new System.Windows.Forms.Padding(4);
            this.btnGecmis.Name = "btnGecmis";
            this.btnGecmis.Size = new System.Drawing.Size(100, 46);
            this.btnGecmis.TabIndex = 1;
            this.btnGecmis.Text = "Randevu Geçmişi";
            this.btnGecmis.UseVisualStyleBackColor = true;
            this.btnGecmis.Click += new System.EventHandler(this.btnGecmis_Click);
            // 
            // btnRecete
            // 
            this.btnRecete.Location = new System.Drawing.Point(46, 144);
            this.btnRecete.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(100, 47);
            this.btnRecete.TabIndex = 2;
            this.btnRecete.Text = "e-Reçete";
            this.btnRecete.UseVisualStyleBackColor = true;
            this.btnRecete.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // btnAyar
            // 
            this.btnAyar.Location = new System.Drawing.Point(171, 144);
            this.btnAyar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAyar.Name = "btnAyar";
            this.btnAyar.Size = new System.Drawing.Size(100, 47);
            this.btnAyar.TabIndex = 3;
            this.btnAyar.Text = "Ayarlar";
            this.btnAyar.UseVisualStyleBackColor = true;
            this.btnAyar.Click += new System.EventHandler(this.btnAyar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(319, 260);
            this.Controls.Add(this.btnAyar);
            this.Controls.Add(this.btnRecete);
            this.Controls.Add(this.btnGecmis);
            this.Controls.Add(this.btnAra);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "İşlem Seçim";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnGecmis;
        private System.Windows.Forms.Button btnRecete;
        private System.Windows.Forms.Button btnAyar;
    }
}