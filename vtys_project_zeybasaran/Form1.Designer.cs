namespace vtys_project_zeybasaran
{
    partial class girisSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisSayfa));
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            girisButton = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.No;
            label2.Name = "label2";
            // 
            // txtKullaniciAdi
            // 
            resources.ApplyResources(txtKullaniciAdi, "txtKullaniciAdi");
            txtKullaniciAdi.BackColor = Color.Tan;
            txtKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullaniciAdi.CausesValidation = false;
            txtKullaniciAdi.Cursor = Cursors.IBeam;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            // 
            // txtSifre
            // 
            resources.ApplyResources(txtSifre, "txtSifre");
            txtSifre.BackColor = Color.Tan;
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Cursor = Cursors.IBeam;
            txtSifre.Name = "txtSifre";
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.No;
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.No;
            label4.Name = "label4";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Name = "label1";
            // 
            // girisButton
            // 
            resources.ApplyResources(girisButton, "girisButton");
            girisButton.BackColor = Color.Tan;
            girisButton.Cursor = Cursors.Hand;
            girisButton.FlatAppearance.BorderColor = Color.Tan;
            girisButton.Name = "girisButton";
            girisButton.UseVisualStyleBackColor = false;
            girisButton.Click += girisButton_Click;
            // 
            // girisSayfa
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(girisButton);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Name = "girisSayfa";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label label3;
        private Label label4;
        private Label label1;
        private Button girisButton;
    }
}