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
using static System.Windows.Forms.DataFormats;

namespace NauSzkol___desktopowa_
{
    public partial class FormularzDodawaniaZadan : Form
    {
        private Exercise _exercise;
        private bool _isEdit;
        private readonly HttpClient _httpClient;
        private readonly string _token = "4b58f23b-2389-4f6e-b105-9269029ad3ac";
        private readonly NauSzkolMainForm _mainForm;
        // Konstruktor do dodawania nowego zadania
        public FormularzDodawaniaZadan(HttpClient client, string token, NauSzkolMainForm mainForm)
        {
            InitializeComponent();
            _httpClient = client;
            _mainForm = mainForm;
            _exercise = new Exercise();
            _isEdit = false;
        }

        // Konstruktor do edycji zadania
        public FormularzDodawaniaZadan(HttpClient client, string token, Exercise exercise, NauSzkolMainForm mainForm)
        {
            InitializeComponent();
            _httpClient = client;
            _token = token;
            _mainForm = mainForm;

            _exercise = exercise;
            _isEdit = true;

            Text = "Edytuj zadanie";
            btnZapiszZadanie.Text = "Zapisz zmiany";
        }

        private async Task<string> PobierzTokenAsync()
        {
            var loginData = new
            {
                Username = "teacher1",
                Password = "hash2"
            };

            var content = new StringContent(
                JsonSerializer.Serialize(loginData),
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PostAsync("https://localhost:7266/user/login", content);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);
            return doc.RootElement.GetProperty("token").GetString();
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
            if (_exercise == null) return; // nic nie rób jeśli brak danych

            txtBoxTytul.Text = _exercise.Title ?? "";
            txtBoxOpis.Text = _exercise.Description ?? "";
            dtpTerminZadania.Value = _exercise.DueDate != default ? _exercise.DueDate : DateTime.Today;

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
            try
            {
                var exercise = new Exercise
                {
                    Id = _exercise.Id,
                    Title = txtBoxTytul.Text,
                    Description = txtBoxOpis.Text,
                    Status = cmbBoxStatus.SelectedItem?.ToString(),
                    Priority = cmbBoxPriorytet.SelectedItem?.ToString(),
                    Tag = cmbBoxPrzedmiot.SelectedItem?.ToString(),
                    DueDate = dtpTerminZadania.Value,
                    OwnerId = int.Parse(cmbBoxWykonawca.SelectedValue.ToString()),
                    CreatorId = int.Parse(cmbBoxAutor.SelectedValue.ToString())
                };

                // Pobierz token nauczyciela
                string token = await PobierzTokenAsync();

                var request = new HttpRequestMessage(
                    _isEdit ? HttpMethod.Put : HttpMethod.Post,
                    _isEdit ? $"https://localhost:7266/exercises/{exercise.Id}" : "https://localhost:7266/exercises"
                );

                request.Content = new StringContent(
                    JsonSerializer.Serialize(exercise),
                    Encoding.UTF8,
                    "application/json"
                );

                request.Headers.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Zapisano pomyślnie!");

                if (_mainForm != null)
                    await _mainForm.LoadExercises();

                this.Close();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Brak połączenia z API lub błąd sieci.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nieoczekiwany błąd: " + ex.Message);
            }
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
