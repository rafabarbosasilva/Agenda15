using System;

namespace Agenda15.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Propriedade para calcular a duração do evento em dias
        public int DuracaoEventoEmDias => (DataTermino - DataInicio).Days;

        // Propriedade para calcular o custo total do evento
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}

