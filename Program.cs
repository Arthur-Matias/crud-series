using System;

namespace DIO.CrudSeries
{
    class Program
    {
        static SeriesRepository repository = new SeriesRepository();
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Pipocar a seu dispor!!!");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Run();
            Console.WriteLine();
        }
        private static void Run(){
            bool running = true;
            while(running){
                string userOption = GetUserOption();
                if (userOption == "X")
                {
                    running = false;
                    Console.WriteLine();
                    Console.WriteLine("Obrigado por utilizar nossos serviços!");
                    Console.WriteLine("-------------------------------");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine();
                    return;
                }
                switch (userOption)
                {
                    case "1":
                        GetSeriesList();
                        break;
                    case "2":
                        AddSeries();
                        break;
                    case "3":
                        UpdateSeries();
                        break;
                    case "4":
                        DeleteSeries();
                        break;
                    case "5":
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine();
            }
        }
        private static void GetSeriesInfo(){
            Console.WriteLine("Ver informações ------------------------------");
            Console.WriteLine();
            Console.WriteLine("Insira o id da série a ser pesquisada");
            Console.WriteLine();
            int currId = int.Parse(Console.ReadLine());
            repository.searchById(currId);
        }
        private static void DeleteSeries(){
            Console.WriteLine("Remover série ------------------------------");
            Console.WriteLine();
            Console.WriteLine("Insira o ID da série a ser deletada");
            string currId = Console.ReadLine();
            Console.WriteLine($"Deletando série: \n {repository.searchById(int.Parse(currId)).ToString()}");
            repository.Delete(int.Parse(currId));
        }
        private static void AddSeries(){
            Console.WriteLine("Adicionar nova série ------------------------------");

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genre), i)}");
            }
            Console.WriteLine("Selecione o gênero");
            int genreEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o título da série?");
            string titleEntry = Console.ReadLine();

            Console.WriteLine("Ano de lançamento:");
            int yearEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série");
            string descriptionEntry = Console.ReadLine();

            Series newSeries = new Series(
                _id: repository.NextId(),
                _genre: (Genre)genreEntry,
                _title: titleEntry,
                _year: yearEntry,
                _description: descriptionEntry
            );
            repository.Add(newSeries);
        }
        private static void UpdateSeries(){
            Console.WriteLine("Atualizar série existente ------------------------------");
            Console.WriteLine();
            int currId = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genre), i)}");
            }
            Console.WriteLine("Selecione o gênero");
            int genreEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o título da série?");
            string titleEntry = Console.ReadLine();

            Console.WriteLine("Ano de lançamento:");
            int yearEntry = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da série");
            string descriptionEntry = Console.ReadLine();

            Series newSeries = new Series(
                _id: currId,
                _genre: (Genre)genreEntry,
                _title: titleEntry,
                _year: yearEntry,
                _description: descriptionEntry
            );
            repository.Update(currId, newSeries);
        }
        private static void GetSeriesList(){
            Console.WriteLine("Listar séries ------------------------------");
            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("No registers.");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine();
                Run();
            }
             foreach (var series in list)
             {
                if (series.isDeleted) return;

                Console.WriteLine($"#ID {series.Id}: {series.Title}");
             }
        }
        private static string GetUserOption(){
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir novo");
            Console.WriteLine("3 - Atualizar informações");
            Console.WriteLine("4 - Deletar Série");
            Console.WriteLine("5 - Ver informações da Série");
            Console.WriteLine("C - Clear Screen");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }

    }
}
