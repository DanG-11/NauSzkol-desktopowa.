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
            ((System.ComponentModel.ISupportInitialize)gridViewPlan).BeginInit();
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
            gridViewPlan.Size = new Size(776, 340);
            gridViewPlan.TabIndex = 0;
            // 
            // btnOdswiez
            // 
            btnOdswiez.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdswiez.Location = new Point(697, 415);
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
            btnDodaj.Location = new Point(12, 415);
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
            btnUsun.Location = new Point(109, 415);
            btnUsun.Name = "btnUsun";
            btnUsun.Size = new Size(91, 23);
            btnUsun.TabIndex = 3;
            btnUsun.Text = "Usuń zadanie";
            btnUsun.UseVisualStyleBackColor = true;
            // 
            // btnEdytuj
            // 
            btnEdytuj.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdytuj.Location = new Point(206, 415);
            btnEdytuj.Name = "btnEdytuj";
            btnEdytuj.Size = new Size(91, 23);
            btnEdytuj.TabIndex = 4;
            btnEdytuj.Text = "Edytuj zadanie";
            btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // NauSzkolMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEdytuj);
            Controls.Add(btnUsun);
            Controls.Add(btnDodaj);
            Controls.Add(btnOdswiez);
            Controls.Add(gridViewPlan);
            Name = "NauSzkolMainForm";
            Text = "NauSzkol";
            ((System.ComponentModel.ISupportInitialize)gridViewPlan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridViewPlan;
        private Button btnOdswiez;
        private Button btnDodaj;
        private Button btnUsun;
        private Button btnEdytuj;
    }
}
