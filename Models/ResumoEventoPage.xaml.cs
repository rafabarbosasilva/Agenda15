using Agenda15.Models;

namespace Agenda15
{
    public partial class ResumoEventoPage : ContentPage
    {
        public Evento Evento { get; set; }

        public ResumoEventoPage(Evento evento)
        {
        
            InitializeComponent();
            Evento = evento;
            BindingContext = this;
        }
    }
}
