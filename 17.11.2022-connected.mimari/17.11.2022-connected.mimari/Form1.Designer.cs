namespace _17._11._2022_connected.mimari
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
            this.urunlerListesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // urunlerListesi
            // 
            this.urunlerListesi.FormattingEnabled = true;
            this.urunlerListesi.ItemHeight = 16;
            this.urunlerListesi.Location = new System.Drawing.Point(82, 94);
            this.urunlerListesi.Name = "urunlerListesi";
            this.urunlerListesi.Size = new System.Drawing.Size(273, 372);
            this.urunlerListesi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 508);
            this.Controls.Add(this.urunlerListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox urunlerListesi;
    }
}

