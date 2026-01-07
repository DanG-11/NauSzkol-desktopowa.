using System.Net.Http.Json;

namespace NauSzkol___desktopowa_
{
    public partial class NauSzkolMainForm : Form
    {
        private readonly HttpClient _httpClient;

        public NauSzkolMainForm()
        {
            InitializeComponent();

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7266");

            LoadExercises();
        }

        private async void LoadExercises()
        {
            try
            {
                var exercises = await _httpClient.GetFromJsonAsync<List<Exercise>>("/exercises");
                gridViewPlan.DataSource = exercises;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var dodajZadanie = new FormularzDodawaniaZadan(_httpClient);
            dodajZadanie.ShowDialog();
            LoadExercises();
        }

        private void btnOdswiez_Click(object sender, EventArgs e)
        {
            LoadExercises();
        }
    }
}
