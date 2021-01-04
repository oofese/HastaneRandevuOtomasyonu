namespace WindowsFormsApplication2
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtrecete = new System.Windows.Forms.TextBox();
            this.txtilac = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttarih = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "İlaç Adları:";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(149, 30);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(116, 22);
            this.txttc.TabIndex = 3;
            // 
            // txtrecete
            // 
            this.txtrecete.Location = new System.Drawing.Point(149, 62);
            this.txtrecete.Name = "txtrecete";
            this.txtrecete.Size = new System.Drawing.Size(116, 22);
            this.txtrecete.TabIndex = 4;
            // 
            // txtilac
            // 
            this.txtilac.Location = new System.Drawing.Point(149, 93);
            this.txtilac.Name = "txtilac";
            this.txtilac.Size = new System.Drawing.Size(116, 22);
            this.txtilac.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yazıldığı Tarih:";
            // 
            // txttarih
            // 
            this.txttarih.Location = new System.Drawing.Point(149, 121);
            this.txttarih.Name = "txttarih";
            this.txttarih.Size = new System.Drawing.Size(116, 22);
            this.txttarih.TabIndex = 7;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(391, 197);
            this.Controls.Add(this.txttarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtilac);
            this.Controls.Add(this.txtrecete);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form8";
            this.Text = "E-Reçete";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtrecete;
        private System.Windows.Forms.TextBox txtilac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttarih;
    }
}