using System;

namespace ex_cs_lista_alunos
{
    class Program
    {
        static void Main()
        {
            string opcao;
            Aluno[] lista = new Aluno[30];
            int x = 0;
            do {
                Console.WriteLine("Bem vindo(a) à listagem de alunos!");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir novo aluno");
                Console.WriteLine("2 - Apresentar lista de alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine("4 - Sair");
                opcao = Console.ReadLine();
                switch (opcao) {
                    case "1":
                        Aluno a = new Aluno();
                        Console.WriteLine("Insira o nome do aluno:");
                        a.nome = Console.ReadLine();
                        Console.WriteLine("Insira a nota do aluno:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota)) {
                            a.nota = nota;
                        } else {
                            throw new ArgumentException("Erro: a nota deve conter apenas números");
                        }
                        lista[x] = a;
                        x++;
                        break;
                    case "2":
                        Console.WriteLine("______________________");
                        Console.WriteLine("Lista de alunos:");
                        for (int i = 0; i < lista.Length; i++) {
                            if (lista[i] != null) {
                                Console.WriteLine($"Aluno {i + 1}: {lista[i].nome} | Nota: {lista[i].nota}");
                            }
                        }
                        Console.WriteLine("______________________");
                        break;
                    case "3":
                        decimal total = 0;
                        decimal n = 0;
                        decimal media = 0;
                        Console.WriteLine("______________________");
                        for (int i = 0; i < lista.Length; i++) {
                            if (lista[i] != null) {
                                total += lista[i].nota;
                                n++;
                            }
                            media = total / n;
                        }
                        Console.WriteLine($"A média geral é {media}");
                        Console.WriteLine("______________________");
                        break;
                    case "4":
                        continue;
                    default:
                        throw new ArgumentOutOfRangeException("Erro: número inválido");

                }
            } while (opcao != "4");
            Console.WriteLine("Até logo!");
        }
    }
}
