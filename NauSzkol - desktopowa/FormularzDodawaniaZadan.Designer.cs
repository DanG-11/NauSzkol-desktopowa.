namespace NauSzkol___desktopowa_
{
    partial class FormularzDodawaniaZadan
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
            txtBoxTytul = new TextBox();
            lblTytul = new Label();
            lblOpis = new Label();
            txtBoxOpis = new TextBox();
            lblPrzedmiot = new Label();
            cmbBoxPrzedmiot = new ComboBox();
            lblStatus = new Label();
            cmbBoxStatus = new ComboBox();
            lblTermin = new Label();
            dtpTerminZadania = new DateTimePicker();
            lblWykonawca = new Label();
            lblAutor = new Label();
            btnZapiszZadanie = new Button();
            btnAnulujZadanie = new Button();
            lblPriorytet = new Label();
            cmbBoxPriorytet = new ComboBox();
            cmbBoxWykonawca = new ComboBox();
            cmbBoxAutor = new ComboBox();
            SuspendLayout();
            // 
            // txtBoxTytul
            // 
            txtBoxTytul.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxTytul.Location = new Point(12, 27);
            txtBoxTytul.Name = "txtBoxTytul";
            txtBoxTytul.Size = new Size(576, 23);
            txtBoxTytul.TabIndex = 0;
            // 
            // lblTytul
            // 
            lblTytul.AutoSize = true;
            lblTytul.Location = new Point(12, 9);
            lblTytul.Name = "lblTytul";
            lblTytul.Size = new Size(79, 15);
            lblTytul.TabIndex = 1;
            lblTytul.Text = "Tytuł zadania:";
            // 
            // lblOpis
            // 
            lblOpis.AutoSize = true;
            lblOpis.Location = new Point(12, 62);
            lblOpis.Name = "lblOpis";
            lblOpis.Size = new Size(77, 15);
            lblOpis.TabIndex = 2;
            lblOpis.Text = "Opis zadania:";
            // 
            // txtBoxOpis
            // 
            txtBoxOpis.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxOpis.Location = new Point(12, 80);
            txtBoxOpis.Name = "txtBoxOpis";
            txtBoxOpis.Size = new Size(576, 23);
            txtBoxOpis.TabIndex = 3;
            // 
            // lblPrzedmiot
            // 
            lblPrzedmiot.AutoSize = true;
            lblPrzedmiot.Location = new Point(12, 116);
            lblPrzedmiot.Name = "lblPrzedmiot";
            lblPrzedmiot.Size = new Size(64, 15);
            lblPrzedmiot.TabIndex = 4;
            lblPrzedmiot.Text = "Przedmiot:";
            // 
            // cmbBoxPrzedmiot
            // 
            cmbBoxPrzedmiot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbBoxPrzedmiot.FormattingEnabled = true;
            cmbBoxPrzedmiot.Location = new Point(12, 134);
            cmbBoxPrzedmiot.Name = "cmbBoxPrzedmiot";
            cmbBoxPrzedmiot.Size = new Size(576, 23);
            cmbBoxPrzedmiot.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 170);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status:";
            // 
            // cmbBoxStatus
            // 
            cmbBoxStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbBoxStatus.FormattingEnabled = true;
            cmbBoxStatus.Location = new Point(12, 188);
            cmbBoxStatus.Name = "cmbBoxStatus";
            cmbBoxStatus.Size = new Size(576, 23);
            cmbBoxStatus.TabIndex = 7;
            // 
            // lblTermin
            // 
            lblTermin.AutoSize = true;
            lblTermin.Location = new Point(12, 224);
            lblTermin.Name = "lblTermin";
            lblTermin.Size = new Size(90, 15);
            lblTermin.TabIndex = 8;
            lblTermin.Text = "Termin zadania:";
            // 
            // dtpTerminZadania
            // 
            dtpTerminZadania.Location = new Point(12, 242);
            dtpTerminZadania.Name = "dtpTerminZadania";
            dtpTerminZadania.Size = new Size(275, 23);
            dtpTerminZadania.TabIndex = 9;
            // 
            // lblWykonawca
            // 
            lblWykonawca.AutoSize = true;
            lblWykonawca.Location = new Point(12, 277);
            lblWykonawca.Name = "lblWykonawca";
            lblWykonawca.Size = new Size(117, 15);
            lblWykonawca.TabIndex = 10;
            lblWykonawca.Text = "Wykonawca zadania:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(175, 277);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(83, 15);
            lblAutor.TabIndex = 12;
            lblAutor.Text = "Autor zadania:";
            // 
            // btnZapiszZadanie
            // 
            btnZapiszZadanie.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnZapiszZadanie.Location = new Point(12, 341);
            btnZapiszZadanie.Name = "btnZapiszZadanie";
            btnZapiszZadanie.Size = new Size(75, 23);
            btnZapiszZadanie.TabIndex = 14;
            btnZapiszZadanie.Text = "Zapisz";
            btnZapiszZadanie.UseVisualStyleBackColor = true;
            btnZapiszZadanie.Click += btnZapiszZadanie_Click;
            // 
            // btnAnulujZadanie
            // 
            btnAnulujZadanie.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnulujZadanie.Location = new Point(513, 341);
            btnAnulujZadanie.Name = "btnAnulujZadanie";
            btnAnulujZadanie.Size = new Size(75, 23);
            btnAnulujZadanie.TabIndex = 15;
            btnAnulujZadanie.Text = "Anuluj";
            btnAnulujZadanie.UseVisualStyleBackColor = true;
            btnAnulujZadanie.Click += btnAnulujZadanie_Click;
            // 
            // lblPriorytet
            // 
            lblPriorytet.AutoSize = true;
            lblPriorytet.Location = new Point(313, 224);
            lblPriorytet.Name = "lblPriorytet";
            lblPriorytet.Size = new Size(55, 15);
            lblPriorytet.TabIndex = 18;
            lblPriorytet.Text = "Priorytet:";
            // 
            // cmbBoxPriorytet
            // 
            cmbBoxPriorytet.FormattingEnabled = true;
            cmbBoxPriorytet.Location = new Point(313, 242);
            cmbBoxPriorytet.Name = "cmbBoxPriorytet";
            cmbBoxPriorytet.Size = new Size(275, 23);
            cmbBoxPriorytet.TabIndex = 19;
            // 
            // cmbBoxWykonawca
            // 
            cmbBoxWykonawca.FormattingEnabled = true;
            cmbBoxWykonawca.Location = new Point(12, 295);
            cmbBoxWykonawca.Name = "cmbBoxWykonawca";
            cmbBoxWykonawca.Size = new Size(142, 23);
            cmbBoxWykonawca.TabIndex = 20;
            // 
            // cmbBoxAutor
            // 
            cmbBoxAutor.FormattingEnabled = true;
            cmbBoxAutor.Location = new Point(175, 295);
            cmbBoxAutor.Name = "cmbBoxAutor";
            cmbBoxAutor.Size = new Size(142, 23);
            cmbBoxAutor.TabIndex = 21;
            // 
            // FormularzDodawaniaZadan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 376);
            Controls.Add(cmbBoxAutor);
            Controls.Add(cmbBoxWykonawca);
            Controls.Add(cmbBoxPriorytet);
            Controls.Add(lblPriorytet);
            Controls.Add(btnAnulujZadanie);
            Controls.Add(btnZapiszZadanie);
            Controls.Add(lblAutor);
            Controls.Add(lblWykonawca);
            Controls.Add(dtpTerminZadania);
            Controls.Add(lblTermin);
            Controls.Add(cmbBoxStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbBoxPrzedmiot);
            Controls.Add(lblPrzedmiot);
            Controls.Add(txtBoxOpis);
            Controls.Add(lblOpis);
            Controls.Add(lblTytul);
            Controls.Add(txtBoxTytul);
            MaximumSize = new Size(616, 415);
            MinimumSize = new Size(616, 415);
            Name = "FormularzDodawaniaZadan";
            Text = "FormularzDodawaniaZadan";
            Load += FormularzDodawaniaZadan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxTytul;
        private Label lblTytul;
        private Label lblOpis;
        private TextBox txtBoxOpis;
        private Label lblPrzedmiot;
        private ComboBox cmbBoxPrzedmiot;
        private Label lblStatus;
        private ComboBox cmbBoxStatus;
        private Label lblTermin;
        private DateTimePicker dtpTerminZadania;
        private Label lblWykonawca;
        private Label lblAutor;
        private Button btnZapiszZadanie;
        private Button btnAnulujZadanie;
        private Label lblPriorytet;
        private ComboBox cmbBoxPriorytet;
        private ComboBox cmbBoxWykonawca;
        private ComboBox cmbBoxAutor;
    }
}