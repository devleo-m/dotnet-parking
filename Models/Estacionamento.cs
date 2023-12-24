namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(string veiculo)
        {
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            veiculos.Add(veiculo);
            Console.WriteLine("Veiculo adicionado :  "+veiculo);
        }

        public void RemoverVeiculo(string placaDoCarro, int horasQuePassou)
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = placaDoCarro;

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = horasQuePassou;
                decimal valorTotal = 0; 
                valorTotal = precoPorHora * horas;
                valorTotal += precoInicial;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var key in veiculos)
                {
                    Console.WriteLine(key);                    
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}