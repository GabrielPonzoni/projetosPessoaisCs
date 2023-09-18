/*Para manipular elementos na lista em C#, é necessário acessar os elementos usando índices ou chaves,
 * por exemplo. É possível adicionar elementos usando o método Add(), remover elementos usando o método
 * Remove() ou alterar elementos diretamente através do seu índice ou chave. 
 * Confira abaixo:
 * 
 * Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
   };
 *
 * Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores são 
 * quantas vezes esse carro foi vendido por ano, calcule a média de uma chave específica.
 */

//Programa precisa mostrar os nomes dos carros no banco de dados
//Usuário entra com o nome do veiculo desejado
// se veículo n tiver no sistema ele pede novamente o nome do veículo
//veiculo no sistema é calculado a media dos valores do carro escolhido
//



Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

void ListarCarros()
{
    foreach (var car in vendasCarros.Keys)
    {
        Console.WriteLine(car);
    }
}
Console.WriteLine("Consulte a média dos seguintes carros:");
ListarCarros();

