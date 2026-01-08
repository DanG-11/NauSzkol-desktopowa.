using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NauSzkol___desktopowa_
{
    public partial class FormularzDodawaniaZadan : Form
    {
        private Exercise _exercise;
        private bool _isEdit;
        private readonly HttpClient _httpClient;
        //Konstruktor formularza dodawania zadań
        public FormularzDodawaniaZadan(HttpClient client)
        {
            InitializeComponent();
            _httpClient = client;

            _exercise = new Exercise();
            _isEdit = false;
        }

        //Wypełnianie formularza danymi zadania do edycji
        public FormularzDodawaniaZadan(HttpClient client, Exercise exercise)
        {
            InitializeComponent();
            _httpClient = client;

            _exercise = exercise;
            _isEdit = true;

            Text = "Edytuj zadanie";
            btnZapiszZadanie.Text = "Zapisz zmiany";
        }

        private async Task FillComboBoxes()
        {
            var users = await PobierzUzytkownikowAsync();

            cmbBoxWykonawca.DataSource = new List<User>(users);
            cmbBoxWykonawca.DisplayMember = "Username";
            cmbBoxWykonawca.ValueMember = "Id";

            cmbBoxAutor.DataSource = new List<User>(users);
            cmbBoxAutor.DisplayMember = "Username";
            cmbBoxAutor.ValueMember = "Id";

            cmbBoxStatus.Items.AddRange(new[] { "ToDo", "Doing", "Done" });
            cmbBoxPriorytet.Items.AddRange(new[] { "Low", "Medium", "High" });
            cmbBoxPrzedmiot.Items.AddRange(new[] {"Matematyka", "Język polski", "Język angielski", "Historia", "Geografia", "Biologia", "Chemia", "Fizyka", "Informatyka", "WOS", "Religia", "Etyka", "Wychowanie fizyczne" });
        }

        private void FillForm()
        {
            txtBoxTytul.Text = _exercise.Title;
            txtBoxOpis.Text = _exercise.Description;
            dtpTerminZadania.Value = _exercise.DueDate;

            cmbBoxStatus.SelectedItem = _exercise.Status;
            cmbBoxPriorytet.SelectedItem = _exercise.Priority;
            cmbBoxPrzedmiot.SelectedItem = _exercise.Tag;
        }

        private async Task<List<User>> PobierzUzytkownikowAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:7266/users");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<User>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        private async void btnZapiszZadanie_Click(object sender, EventArgs e)
        {
            _exercise.Title = txtBoxTytul.Text;
            _exercise.Description = txtBoxOpis.Text;
            _exercise.DueDate = dtpTerminZadania.Value;
            _exercise.Status = cmbBoxStatus.Text;
            _exercise.Priority = cmbBoxPriorytet.Text;
            _exercise.Tag = cmbBoxPrzedmiot.Text;
            _exercise.OwnerId = (int)cmbBoxAutor.SelectedValue;
            _exercise.CreatorId = (int)cmbBoxAutor.SelectedValue;

            var json = JsonSerializer.Serialize(_exercise);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            if (_isEdit)
            {
                await _httpClient.PutAsync($"https://localhost:7266/exercises/{_exercise.Id}", content);
            }
            else
            {
                await _httpClient.PostAsync("https://localhost:7266/exercises", content);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnAnulujZadanie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormularzDodawaniaZadan_Load(object sender, EventArgs e)
        {
            await FillComboBoxes();

            if (_isEdit)
            {
                FillForm();
                cmbBoxWykonawca.SelectedValue = _exercise.OwnerId;
                cmbBoxAutor.SelectedValue = _exercise.CreatorId;
                cmbBoxWykonawca.Enabled = false;
                cmbBoxAutor.Enabled = false;
            }
        }
    }
}
