namespace ArabaGalerisi
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
            this.lblMarka = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.lblRenk = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtArabalar = new System.Windows.Forms.TextBox();
            this.dgwArabalar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwArabalar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(75, 33);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(128, 30);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(186, 22);
            this.txtMarka.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(128, 57);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(186, 22);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(75, 60);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(128, 85);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(186, 22);
            this.txtRenk.TabIndex = 5;
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(75, 88);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(41, 17);
            this.lblRenk.TabIndex = 4;
            this.lblRenk.Text = "Renk";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(128, 113);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(186, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(78, 170);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(236, 23);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // txtArabalar
            // 
            this.txtArabalar.Location = new System.Drawing.Point(78, 199);
            this.txtArabalar.Multiline = true;
            this.txtArabalar.Name = "txtArabalar";
            this.txtArabalar.Size = new System.Drawing.Size(236, 109);
            this.txtArabalar.TabIndex = 8;
            // 
            // dgwArabalar
            // 
            this.dgwArabalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwArabalar.Location = new System.Drawing.Point(78, 314);
            this.dgwArabalar.Name = "dgwArabalar";
            this.dgwArabalar.RowHeadersWidth = 51;
            this.dgwArabalar.RowTemplate.Height = 24;
            this.dgwArabalar.Size = new System.Drawing.Size(240, 150);
            this.dgwArabalar.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 497);
            this.Controls.Add(this.dgwArabalar);
            this.Controls.Add(this.txtArabalar);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lblMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwArabalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtArabalar;
        private System.Windows.Forms.DataGridView dgwArabalar;
    }
}

