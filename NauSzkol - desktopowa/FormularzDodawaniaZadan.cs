using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NauSzkol___desktopowa_
{
    public partial class FormularzDodawaniaZadan : Form
    {
        private readonly HttpClient _httpClient;
        public FormularzDodawaniaZadan(HttpClient client)
        {
            InitializeComponent();
            _httpClient = client;

            cmbBoxStatus.Items.AddRange(new[] { "ToDo", "Doing", "Done" });
            cmbBoxStatus.SelectedIndex = 0;

            cmbBoxPriorytet.Items.AddRange(new[] { "Low", "Medium", "High" });
            cmbBoxPriorytet.SelectedIndex = 1;

            cmbBoxPrzedmiot.Items.AddRange(new[] { "Matematyka", "Język polski", "Język angielski", "Historia", "Geografia", "Biologia", "Chemia", "Fizyka", "Informatyka", "WOS", "Religia", "Etyka", "Wychowanie fizyczne" });
        }

        private async void btnZapiszZadanie_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(numWykonawca.Text, out int ownerId) || !int.TryParse(numAutor.Text, out int creatorId))
            {
                MessageBox.Show("Wykonawca i autor muszą to id!");
                return;
            }

            var exercise = new Exercise
            {
                Title = txtBoxTytul.Text,
                Description = txtBoxOpis.Text,
                Tag = cmbBoxPrzedmiot.Text,
                Status = cmbBoxStatus.Text,
                Priority = cmbBoxPriorytet.Text,
                DueDate = dtpTerminZadania.Value,
                OwnerId = Convert.ToInt32(numWykonawca.Value),
                CreatorId = Convert.ToInt32(numAutor.Value)
            };

            var response = await _httpClient.PostAsJsonAsync("/exercises", exercise);

            if (response.IsSuccessStatusCode)
            {
                Close();
            }
            else
            {
                MessageBox.Show("Błąd zapisu");
            }
        }

        private void btnAnulujZadanie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
