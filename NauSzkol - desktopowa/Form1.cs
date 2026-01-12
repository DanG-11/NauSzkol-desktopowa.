using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using System.Windows.Forms;

namespace NauSzkol___desktopowa_
{
    public partial class NauSzkolMainForm : Form
    {
        private readonly HttpClient _httpClient;
        private readonly string _token = "4b58f23b-2389-4f6e-b105-9269029ad3ac";
        private BindingSource _bindingSource = new BindingSource();

        public NauSzkolMainForm()
        {
            InitializeComponent();

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7266");

            LoadExercises();
        }

        public async Task LoadExercises()
        {
            try
            {
                // Wype³nienie ComboBoxów przy pierwszym ³adowaniu
                if (cmbBoxStatus.Items.Count == 0)
                {
                    cmbBoxStatus.Items.AddRange(new[] { "ToDo", "Doing", "Done" });
                    cmbBoxPriorytet.Items.AddRange(new[] { "Low", "Medium", "High" });
                    cmbBoxPrzedmiot.Items.AddRange(new[]
                    {
                        "Matematyka", "Jêzyk polski", "Jêzyk angielski", "Historia", "Geografia",
                        "Biologia", "Chemia", "Fizyka", "Informatyka", "WOS", "Religia", "Etyka", "Wychowanie fizyczne"
                    });
                }

                // Pobranie wybranych filtrów
                string? selectedStatus = cmbBoxStatus.SelectedItem?.ToString();
                string? selectedTag = cmbBoxPrzedmiot.SelectedItem?.ToString();
                string? selectedPriority = cmbBoxPriorytet.SelectedItem?.ToString();

                var url = "https://localhost:7266/exercises/full?";

                if (!string.IsNullOrEmpty(selectedStatus))
                    url += $"status={selectedStatus}&";
                if (!string.IsNullOrEmpty(selectedTag))
                    url += $"tag={selectedTag}&";
                if (!string.IsNullOrEmpty(selectedPriority))
                    url += $"priority={selectedPriority}&";
                if (chkBoxData.Checked)
                    url += $"dueDate={dtpData.Value:yyyy-MM-dd}&";

                // Wywo³anie API z obs³ug¹ b³êdów
                try
                {
                    var response = await _httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    var json = await response.Content.ReadAsStringAsync();
                    var exercises = JsonSerializer.Deserialize<List<Exercise>>(json,
                        new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<Exercise>();

                    // Sortowanie po DueDate - najbli¿sza data na górze
                    var today = DateTime.Today;
                    exercises = exercises.OrderBy(e => Math.Abs((e.DueDate.Date - today).TotalDays)).ToList();

                    // Wyœwietlenie w DataGridView
                    _bindingSource.DataSource = exercises;
                    gridViewPlan.DataSource = _bindingSource;

                    foreach (DataGridViewColumn col in gridViewPlan.Columns)
                    {
                        col.SortMode = DataGridViewColumnSortMode.Automatic;
                    }

                    // Ukrycie kolumn pomocniczych
                    gridViewPlan.Columns["OwnerId"].Visible = false;
                    gridViewPlan.Columns["CreatorId"].Visible = false;
                    gridViewPlan.Columns["Id"].Visible = false;
                }
                catch (HttpRequestException)
                {
                    MessageBox.Show("Brak po³¹czenia z API lub b³¹d sieci.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nieoczekiwany b³¹d: " + ex.Message);
                }
            }
            catch (Exception exOuter)
            {
                MessageBox.Show("B³¹d w metodzie LoadExercises: " + exOuter.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var form = new FormularzDodawaniaZadan(_httpClient, _token, this);
            form.ShowDialog();

            LoadExercises();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            LoadExercises();
        }

        private async void btnUsun_Click(object sender, EventArgs e)
        {
            if (gridViewPlan.CurrentRow == null) return;

            int id = (int)gridViewPlan.CurrentRow.Cells["Id"].Value;

            var confirm = MessageBox.Show("Czy na pewno chcesz usun¹æ zadanie?", "Potwierdzenie", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            using var client = new HttpClient();
            await client.DeleteAsync($"https://localhost:7266/exercises/{id}");

            await LoadExercises();
        }

        private async void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (gridViewPlan.CurrentRow == null)
            {
                MessageBox.Show("Wybierz zadanie do edycji");
                return;
            }

            var exercise = gridViewPlan.CurrentRow.DataBoundItem as Exercise;
            if (exercise == null)
            {
                MessageBox.Show("Nie uda³o siê pobraæ zadania do edycji");
                return;
            }

            var form = new FormularzDodawaniaZadan(_httpClient, _token, exercise, this);
            form.ShowDialog();

            await LoadExercises();
        }

        private async void btnFiltruj_Click(object sender, EventArgs e)
        {
            await LoadExercises();
        }

        private async void btnWyczysc_Click(object sender, EventArgs e)
        {
            cmbBoxStatus.SelectedIndex = -1;
            cmbBoxPriorytet.SelectedIndex = -1;
            cmbBoxPrzedmiot.SelectedIndex = -1;
            chkBoxData.Checked = false;

            await LoadExercises();
        }
    }
}
