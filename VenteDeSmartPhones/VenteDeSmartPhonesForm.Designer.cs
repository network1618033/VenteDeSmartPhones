namespace VenteDeSmartPhones
{
    partial class venteDeSmartphonesForm
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
            this.venteSmartphonesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationClientGroupBox = new System.Windows.Forms.GroupBox();
            this.dateInformationClientMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nomInformationClientMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.dateInformationClientLabel = new System.Windows.Forms.Label();
            this.nomInformationClientLabel = new System.Windows.Forms.Label();
            this.venteGroupBox = new System.Windows.Forms.GroupBox();
            this.modeleVenteComboBox = new System.Windows.Forms.ComboBox();
            this.vendeurVenteComboBox = new System.Windows.Forms.ComboBox();
            this.totalValeurVenteLabel = new System.Windows.Forms.Label();
            this.prixValeurVenteLabel = new System.Windows.Forms.Label();
            this.totalVenteLabel = new System.Windows.Forms.Label();
            this.prixVenteLabel = new System.Windows.Forms.Label();
            this.modeleVenteLabel = new System.Windows.Forms.Label();
            this.vendeurVenteLabel = new System.Windows.Forms.Label();
            this.venteSmartPhonesPictureBox = new System.Windows.Forms.PictureBox();
            this.venteSmartphonesMenuStrip.SuspendLayout();
            this.informationClientGroupBox.SuspendLayout();
            this.venteGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venteSmartPhonesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // venteSmartphonesMenuStrip
            // 
            this.venteSmartphonesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.venteSmartphonesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem});
            this.venteSmartphonesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.venteSmartphonesMenuStrip.Name = "venteSmartphonesMenuStrip";
            this.venteSmartphonesMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.venteSmartphonesMenuStrip.Size = new System.Drawing.Size(504, 25);
            this.venteSmartphonesMenuStrip.TabIndex = 0;
            this.venteSmartphonesMenuStrip.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.imprimerToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrerToolStripMenuItem.Image = global::VenteDeSmartPhones.Properties.Resources.saveHS;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimerToolStripMenuItem.Image = global::VenteDeSmartPhones.Properties.Resources.PrintHS;
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.imprimerToolStripMenuItem.Text = "Imprimer";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // informationClientGroupBox
            // 
            this.informationClientGroupBox.Controls.Add(this.dateInformationClientMaskedTextBox);
            this.informationClientGroupBox.Controls.Add(this.nomInformationClientMaskedTextBox);
            this.informationClientGroupBox.Controls.Add(this.dateInformationClientLabel);
            this.informationClientGroupBox.Controls.Add(this.nomInformationClientLabel);
            this.informationClientGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationClientGroupBox.Location = new System.Drawing.Point(39, 267);
            this.informationClientGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.informationClientGroupBox.Name = "informationClientGroupBox";
            this.informationClientGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.informationClientGroupBox.Size = new System.Drawing.Size(417, 102);
            this.informationClientGroupBox.TabIndex = 1;
            this.informationClientGroupBox.TabStop = false;
            this.informationClientGroupBox.Text = "Information du client";
            // 
            // dateInformationClientMaskedTextBox
            // 
            this.dateInformationClientMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInformationClientMaskedTextBox.Location = new System.Drawing.Point(103, 59);
            this.dateInformationClientMaskedTextBox.Name = "dateInformationClientMaskedTextBox";
            this.dateInformationClientMaskedTextBox.Size = new System.Drawing.Size(273, 22);
            this.dateInformationClientMaskedTextBox.TabIndex = 3;
            this.dateInformationClientMaskedTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dateInformationClientMaskedTextBox_Validating);
            // 
            // nomInformationClientMaskedTextBox
            // 
            this.nomInformationClientMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomInformationClientMaskedTextBox.Location = new System.Drawing.Point(103, 25);
            this.nomInformationClientMaskedTextBox.Name = "nomInformationClientMaskedTextBox";
            this.nomInformationClientMaskedTextBox.Size = new System.Drawing.Size(273, 22);
            this.nomInformationClientMaskedTextBox.TabIndex = 2;
            // 
            // dateInformationClientLabel
            // 
            this.dateInformationClientLabel.AutoSize = true;
            this.dateInformationClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInformationClientLabel.Location = new System.Drawing.Point(46, 62);
            this.dateInformationClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateInformationClientLabel.Name = "dateInformationClientLabel";
            this.dateInformationClientLabel.Size = new System.Drawing.Size(37, 16);
            this.dateInformationClientLabel.TabIndex = 1;
            this.dateInformationClientLabel.Text = "Date";
            // 
            // nomInformationClientLabel
            // 
            this.nomInformationClientLabel.AutoSize = true;
            this.nomInformationClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomInformationClientLabel.Location = new System.Drawing.Point(46, 28);
            this.nomInformationClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomInformationClientLabel.Name = "nomInformationClientLabel";
            this.nomInformationClientLabel.Size = new System.Drawing.Size(37, 16);
            this.nomInformationClientLabel.TabIndex = 0;
            this.nomInformationClientLabel.Text = "Nom";
            // 
            // venteGroupBox
            // 
            this.venteGroupBox.Controls.Add(this.modeleVenteComboBox);
            this.venteGroupBox.Controls.Add(this.vendeurVenteComboBox);
            this.venteGroupBox.Controls.Add(this.totalValeurVenteLabel);
            this.venteGroupBox.Controls.Add(this.prixValeurVenteLabel);
            this.venteGroupBox.Controls.Add(this.totalVenteLabel);
            this.venteGroupBox.Controls.Add(this.prixVenteLabel);
            this.venteGroupBox.Controls.Add(this.modeleVenteLabel);
            this.venteGroupBox.Controls.Add(this.vendeurVenteLabel);
            this.venteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venteGroupBox.Location = new System.Drawing.Point(39, 377);
            this.venteGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.venteGroupBox.Name = "venteGroupBox";
            this.venteGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.venteGroupBox.Size = new System.Drawing.Size(417, 195);
            this.venteGroupBox.TabIndex = 2;
            this.venteGroupBox.TabStop = false;
            this.venteGroupBox.Text = "Vente";
            // 
            // modeleVenteComboBox
            // 
            this.modeleVenteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeleVenteComboBox.FormattingEnabled = true;
            this.modeleVenteComboBox.Location = new System.Drawing.Point(205, 65);
            this.modeleVenteComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.modeleVenteComboBox.Name = "modeleVenteComboBox";
            this.modeleVenteComboBox.Size = new System.Drawing.Size(171, 24);
            this.modeleVenteComboBox.TabIndex = 11;
            this.modeleVenteComboBox.SelectedIndexChanged += new System.EventHandler(this.modeleVenteComboBox_SelectedIndexChanged);
            // 
            // vendeurVenteComboBox
            // 
            this.vendeurVenteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendeurVenteComboBox.FormattingEnabled = true;
            this.vendeurVenteComboBox.Location = new System.Drawing.Point(205, 27);
            this.vendeurVenteComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.vendeurVenteComboBox.Name = "vendeurVenteComboBox";
            this.vendeurVenteComboBox.Size = new System.Drawing.Size(171, 24);
            this.vendeurVenteComboBox.TabIndex = 10;
            // 
            // totalValeurVenteLabel
            // 
            this.totalValeurVenteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalValeurVenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValeurVenteLabel.Location = new System.Drawing.Point(205, 144);
            this.totalValeurVenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalValeurVenteLabel.Name = "totalValeurVenteLabel";
            this.totalValeurVenteLabel.Size = new System.Drawing.Size(79, 23);
            this.totalValeurVenteLabel.TabIndex = 9;
            // 
            // prixValeurVenteLabel
            // 
            this.prixValeurVenteLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prixValeurVenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixValeurVenteLabel.Location = new System.Drawing.Point(205, 104);
            this.prixValeurVenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prixValeurVenteLabel.Name = "prixValeurVenteLabel";
            this.prixValeurVenteLabel.Size = new System.Drawing.Size(79, 23);
            this.prixValeurVenteLabel.TabIndex = 5;
            // 
            // totalVenteLabel
            // 
            this.totalVenteLabel.AutoSize = true;
            this.totalVenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVenteLabel.Location = new System.Drawing.Point(46, 149);
            this.totalVenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalVenteLabel.Name = "totalVenteLabel";
            this.totalVenteLabel.Size = new System.Drawing.Size(39, 16);
            this.totalVenteLabel.TabIndex = 4;
            this.totalVenteLabel.Text = "Total";
            // 
            // prixVenteLabel
            // 
            this.prixVenteLabel.AutoSize = true;
            this.prixVenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixVenteLabel.Location = new System.Drawing.Point(46, 108);
            this.prixVenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prixVenteLabel.Name = "prixVenteLabel";
            this.prixVenteLabel.Size = new System.Drawing.Size(30, 16);
            this.prixVenteLabel.TabIndex = 3;
            this.prixVenteLabel.Text = "Prix";
            // 
            // modeleVenteLabel
            // 
            this.modeleVenteLabel.AutoSize = true;
            this.modeleVenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeleVenteLabel.Location = new System.Drawing.Point(46, 68);
            this.modeleVenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeleVenteLabel.Name = "modeleVenteLabel";
            this.modeleVenteLabel.Size = new System.Drawing.Size(54, 16);
            this.modeleVenteLabel.TabIndex = 2;
            this.modeleVenteLabel.Text = "Modèle";
            // 
            // vendeurVenteLabel
            // 
            this.vendeurVenteLabel.AutoSize = true;
            this.vendeurVenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendeurVenteLabel.Location = new System.Drawing.Point(46, 30);
            this.vendeurVenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vendeurVenteLabel.Name = "vendeurVenteLabel";
            this.vendeurVenteLabel.Size = new System.Drawing.Size(59, 16);
            this.vendeurVenteLabel.TabIndex = 1;
            this.vendeurVenteLabel.Text = "Vendeur";
            // 
            // venteSmartPhonesPictureBox
            // 
            this.venteSmartPhonesPictureBox.Image = global::VenteDeSmartPhones.Properties.Resources.smartphones;
            this.venteSmartPhonesPictureBox.Location = new System.Drawing.Point(39, 40);
            this.venteSmartPhonesPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.venteSmartPhonesPictureBox.Name = "venteSmartPhonesPictureBox";
            this.venteSmartPhonesPictureBox.Size = new System.Drawing.Size(417, 210);
            this.venteSmartPhonesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.venteSmartPhonesPictureBox.TabIndex = 3;
            this.venteSmartPhonesPictureBox.TabStop = false;
            // 
            // venteDeSmartphonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(504, 604);
            this.Controls.Add(this.venteSmartPhonesPictureBox);
            this.Controls.Add(this.venteGroupBox);
            this.Controls.Add(this.informationClientGroupBox);
            this.Controls.Add(this.venteSmartphonesMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.venteSmartphonesMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "venteDeSmartphonesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smartphones - Ventes";
            this.Load += new System.EventHandler(this.venteSmartphonesForm_Load);
            this.venteSmartphonesMenuStrip.ResumeLayout(false);
            this.venteSmartphonesMenuStrip.PerformLayout();
            this.informationClientGroupBox.ResumeLayout(false);
            this.informationClientGroupBox.PerformLayout();
            this.venteGroupBox.ResumeLayout(false);
            this.venteGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venteSmartPhonesPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip venteSmartphonesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.GroupBox informationClientGroupBox;
        private System.Windows.Forms.GroupBox venteGroupBox;
        private System.Windows.Forms.PictureBox venteSmartPhonesPictureBox;
        private System.Windows.Forms.Label dateInformationClientLabel;
        private System.Windows.Forms.Label nomInformationClientLabel;
        private System.Windows.Forms.Label prixValeurVenteLabel;
        private System.Windows.Forms.Label totalVenteLabel;
        private System.Windows.Forms.Label prixVenteLabel;
        private System.Windows.Forms.Label modeleVenteLabel;
        private System.Windows.Forms.Label vendeurVenteLabel;
        private System.Windows.Forms.Label totalValeurVenteLabel;
        private System.Windows.Forms.ComboBox modeleVenteComboBox;
        private System.Windows.Forms.ComboBox vendeurVenteComboBox;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox dateInformationClientMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox nomInformationClientMaskedTextBox;
    }
}

