using Agenda15.Models;

namespace Agenda15
{
    public partial class MainPage : ContentPage
    {
        public Evento Evento { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Evento = new Evento();
            BindingContext = this;
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            // Navegar para a próxima página com o resumo do evento
            await Navigation.PushAsync(new ResumoEventoPage(Evento));
        }
    }
}

