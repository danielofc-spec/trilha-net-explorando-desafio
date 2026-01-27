namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //feito
            if ( hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw  new ArgumentOutOfRangeException("A quantidade de pessoas excede a capacidade de hospedes.");
                //feito
            }
        }
        public int ObterQuantidadeHospedes()
        {
            //feito
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            //feito
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            //feito
            if (DiasReservados >= 10)
            {
                
                valor = valor - (valor * 0.10m); 
                
            }

            return valor;
        }
    }
}