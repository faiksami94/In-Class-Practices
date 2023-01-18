namespace _17._11._2022_connected.mimari
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
            this.kategoriListesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // kategoriListesi
            // 
            this.kategoriListesi.FormattingEnabled = true;
            this.kategoriListesi.ItemHeight = 16;
            this.kategoriListesi.Location = new System.Drawing.Point(76, 157);
            this.kategoriListesi.Name = "kategoriListesi";
            this.kategoriListesi.Size = new System.Drawing.Size(570, 244);
            this.kategoriListesi.TabIndex = 0;
            this.kategoriListesi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kategoriListesi);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox kategoriListesi;
    }
}