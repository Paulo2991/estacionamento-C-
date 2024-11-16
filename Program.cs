// See https://aka.ms/new-console-template for more information
using desafio_estacionamento_C_.models;
int op = 0;
decimal precoInicial = 0;
decimal precoHora = 0;
Estacionamento estacionamento = new Estacionamento(precoInicial,precoHora);
do{
  Console.WriteLine("Escolhe as opções abaixo: \n");
  Console.WriteLine("1 - Cadastrar Veiculos: ");
  Console.WriteLine("2 - Listar Veiculos: ");
  Console.WriteLine("3 - Remover Veiculo:");
  Console.WriteLine("4 - Sair Do Menu: ");
  op = int.Parse(Console.ReadLine()!);
  switch(op){
    case 1:
      Console.WriteLine("Informe o preco Incial: ");
      precoInicial = decimal.Parse(Console.ReadLine()!);
      Console.WriteLine("Informe o preço por Hora: ");
      precoHora = decimal.Parse(Console.ReadLine()!);
      Console.WriteLine(precoInicial);
      estacionamento.adicionarEstacionamento();
      break;
     case 2:
      estacionamento.listarVeiculos();
      break;
     case 3:
      estacionamento.removerVeiculo();
      decimal quantidadeHoras = precoInicial * precoHora;
      Console.WriteLine("A quantidade de horas: " + quantidadeHoras);
      break;
      case 4:
        return;      
  }                          
}while(op != 4);
