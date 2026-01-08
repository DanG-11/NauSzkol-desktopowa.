namespace NauSzkol___desktopowa_
{
    partial class NauSzkolMainForm
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
            gridViewPlan = new DataGridView();
            btnOdswiez = new Button();
            btnDodaj = new Button();
            btnUsun = new Button();
            btnEdytuj = new Button();
            grpBoxFiltry = new GroupBox();
            chkBoxData = new CheckBox();
            btnFiltruj = new Button();
            btnWyczysc = new Button();
            dtpData = new DateTimePicker();
            cmbBoxPriorytet = new ComboBox();
            cmbBoxPrzedmiot = new ComboBox();
            cmbBoxStatus = new ComboBox();
            lblPriorytet = new Label();
            lblPrzedmiot = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewPlan).BeginInit();
            grpBoxFiltry.SuspendLayout();
            SuspendLayout();
            // 
            // gridViewPlan
            // 
            gridViewPlan.AllowUserToAddRows = false;
            gridViewPlan.AllowUserToDeleteRows = false;
            gridViewPlan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridViewPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewPlan.Location = new Point(12, 12);
            gridViewPlan.Name = "gridViewPlan";
            gridViewPlan.ReadOnly = true;
            gridViewPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewPlan.Size = new Size(776, 316);
            gridViewPlan.TabIndex = 0;
            // 
            // btnOdswiez
            // 
            btnOdswiez.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdswiez.Location = new Point(697, 432);
            btnOdswiez.Name = "btnOdswiez";
            btnOdswiez.Size = new Size(91, 23);
            btnOdswiez.TabIndex = 1;
            btnOdswiez.Text = "Odśwież";
            btnOdswiez.UseVisualStyleBackColor = true;
            btnOdswiez.Click += btnOdswiez_Click;
            // 
            // btnDodaj
            // 
            btnDodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDodaj.Location = new Point(12, 432);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(91, 23);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj zadanie";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUsun
            // 
            btnUsun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUsun.Location = new Point(109, 432);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(91, 23);
            btnUsun.TabIndex = 3;
            btnUsun.Text = "Usuń zadanie";
            btnUsun.UseVisualStyleBackColor = true;
            btnUsun.Click += btnUsun_Click;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdytuj.Location = new Point(206, 432);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(91, 23);
            btnEdytuj.TabIndex = 4;
            btnEdytuj.Text = "Edytuj zadanie";
            btnEdytuj.UseVisualStyleBackColor = true;
            btnEdytuj.Click += btnEdytuj_Click;
            // 
            // grpBoxFiltry
            // 
            grpBoxFiltry.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpBoxFiltry.Controls.Add(chkBoxData);
            grpBoxFiltry.Controls.Add(btnFiltruj);
            grpBoxFiltry.Controls.Add(btnWyczysc);
            grpBoxFiltry.Controls.Add(dtpData);
            grpBoxFiltry.Controls.Add(cmbBoxPriorytet);
            grpBoxFiltry.Controls.Add(cmbBoxPrzedmiot);
            grpBoxFiltry.Controls.Add(cmbBoxStatus);
            grpBoxFiltry.Controls.Add(lblPriorytet);
            grpBoxFiltry.Controls.Add(lblPrzedmiot);
            grpBoxFiltry.Controls.Add(lblStatus);
            grpBoxFiltry.Location = new Point(12, 334);
            grpBoxFiltry.Name = "grpBoxFiltry";
            grpBoxFiltry.Size = new Size(776, 85);
            grpBoxFiltry.TabIndex = 5;
            grpBoxFiltry.TabStop = false;
            grpBoxFiltry.Text = "Filtry";
            // 
            // chkBoxData
            // 
            chkBoxData.AutoSize = true;
            chkBoxData.CheckAlign = ContentAlignment.MiddleRight;
            chkBoxData.Location = new Point(337, 52);
            chkBoxData.Name = "chkBoxData";
            chkBoxData.Size = new Size(53, 19);
            chkBoxData.TabIndex = 6;
            chkBoxData.Text = "Data:";
            chkBoxData.UseVisualStyleBackColor = true;
            // 
            // btnFiltruj
            // 
            btnFiltruj.Location = new Point(654, 16);
            btnFiltruj.Name = "btnFiltruj";
            btnFiltruj.Size = new Size(87, 23);
            btnFiltruj.TabIndex = 9;
            btnFiltruj.Text = "Filtruj";
            btnFiltruj.UseVisualStyleBackColor = true;
            btnFiltruj.Click += btnFiltruj_Click;
            // 
            // btnWyczysc
            // 
            btnWyczysc.Location = new Point(654, 49);
            btnWyczysc.Name = "btnWyczysc";
            btnWyczysc.Size = new Size(87, 23);
            btnWyczysc.TabIndex = 10;
            btnWyczysc.Text = "Wyczyść filtry";
            btnWyczysc.UseVisualStyleBackColor = true;
            btnWyczysc.Click += btnWyczysc_Click;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(396, 49);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 6;
            // 
            // cmbBoxPriorytet
            // 
            cmbBoxPriorytet.FormattingEnabled = true;
            cmbBoxPriorytet.Location = new Point(396, 17);
            cmbBoxPriorytet.Name = "cmbBoxPriorytet";
            cmbBoxPriorytet.Size = new Size(200, 23);
            cmbBoxPriorytet.TabIndex = 5;
            // 
            // cmbBoxPrzedmiot
            // 
            cmbBoxPrzedmiot.FormattingEnabled = true;
            cmbBoxPrzedmiot.Location = new Point(85, 49);
            cmbBoxPrzedmiot.Name = "cmbBoxPrzedmiot";
            cmbBoxPrzedmiot.Size = new Size(200, 23);
            cmbBoxPrzedmiot.TabIndex = 4;
            // 
            // cmbBoxStatus
            // 
            cmbBoxStatus.FormattingEnabled = true;
            cmbBoxStatus.Location = new Point(85, 16);
            cmbBoxStatus.Name = "cmbBoxStatus";
            cmbBoxStatus.Size = new Size(200, 23);
            cmbBoxStatus.TabIndex = 3;
            // 
            // lblPriorytet
            // 
            lblPriorytet.AutoSize = true;
            lblPriorytet.Location = new Point(337, 20);
            lblPriorytet.Name = "lblPriorytet";
            lblPriorytet.Size = new Size(55, 15);
            lblPriorytet.TabIndex = 2;
            lblPriorytet.Text = "Priorytet:";
            // 
            // lblPrzedmiot
            // 
            lblPrzedmiot.AutoSize = true;
            lblPrzedmiot.Location = new Point(16, 52);
            lblPrzedmiot.Name = "lblPrzedmiot";
            lblPrzedmiot.Size = new Size(64, 15);
            lblPrzedmiot.TabIndex = 1;
            lblPrzedmiot.Text = "Przedmiot:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(16, 19);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status:";
            // 
            // NauSzkolMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 467);
            Controls.Add(grpBoxFiltry);
            Controls.Add(btnEdytuj);
            Controls.Add(btnUsun);
            Controls.Add(btnDodaj);
            Controls.Add(btnOdswiez);
            Controls.Add(gridViewPlan);
            Name = "NauSzkolMainForm";
            Text = "NauSzkol";
            ((System.ComponentModel.ISupportInitialize)gridViewPlan).EndInit();
            grpBoxFiltry.ResumeLayout(false);
            grpBoxFiltry.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridViewPlan;
        private Button btnOdswiez;
        private Button btnDodaj;
        private Button btnUsun;
        private Button btnEdytuj;
        private GroupBox grpBoxFiltry;
        private Button btnWyczysc;
        private Button btnFiltruj;
        private DateTimePicker dtpData;
        private ComboBox cmbBoxPriorytet;
        private ComboBox cmbBoxPrzedmiot;
        private ComboBox cmbBoxStatus;
        private Label lblPriorytet;
        private Label lblPrzedmiot;
        private Label lblStatus;
        private CheckBox chkBoxData;
    }
}
