using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_estacionamento_C_.models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoHora;
        private List<string> veiculos;

        public Estacionamento(decimal precoInicial,decimal precoHora){
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
            this.veiculos = new List<string>();
        }

        public void adicionarEstacionamento(){
            Console.WriteLine("Informe a placa: ");
            string placaUsuario = Console.ReadLine()!;
            veiculos.Add(placaUsuario);
            Console.WriteLine("Veiculo Cadastrado com sucesso: ");
        }

        public void listarVeiculos(){
            if(veiculos.Count > 0){
                foreach(string veiculo in veiculos){
                    Console.WriteLine($"Veiculos cadastrados: {veiculo}");
                }
            }else{
                Console.WriteLine("Não há veículos estacionados:");
            }
        }

        public void removerVeiculo(){
            Console.WriteLine("Informe a placa para ser removida: ");
            string placaUsuario = Console.ReadLine()!;
            if(veiculos.Contains(placaUsuario)){
                veiculos.Remove(placaUsuario);
                Console.WriteLine($"Veiculo {placaUsuario} Removido Com Sucesso:");
            }else{
                Console.WriteLine("Não tem nenhum veiculo cadastrado: ");
            }
        }
    }
}