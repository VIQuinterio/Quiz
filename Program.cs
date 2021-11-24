using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            iniciar();
        }
        private static void iniciar()
        {
            moldura();
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("Desenvolvido por Victória Cabral");
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("Quiz Star Wars");
            Console.SetCursorPosition(5, 7);
            Console.WriteLine("Deseja iniciar o quiz 1[SIM]...2[NAO]");
            Console.SetCursorPosition(5, 8);
            int iniciar = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(5, 9);
            if (iniciar == 1)
            {
                quiz();
            }
            else
            {
                Console.WriteLine("Talvez na próxima");
                Console.ReadKey();
            }
            /*ConsoleKeyInfo tecla = Console.ReadKey();
            //KeyChar é igual a 13, então usuário apertou ENTER
            if (tecla.KeyChar == 13)
            {
                quiz();
            }
            else if (tecla.KeyChar == 13)
            {

            }
            */
        }
        private static void quiz()
        {
            int perguntas = 1, op, pontos = 0;
            Console.Clear();
            do
            {
                if (perguntas == 1)
                {
                    quiz:
                    moldura();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("Quando lançou o primeiro filme de Star Wars?");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("1. 25 de maio de 1977");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("2. 26 de maio de 1977");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("3. 23 de maio de 1978");
                    Console.SetCursorPosition(5, 9);
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Acertou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            pontos = pontos + 1;
                            break;
                        case 2:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            break;
                        case 3:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            break;
                        default:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("A alternativa não existe [PRESSIONE ENTER]");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            goto quiz;
                    }
                }

                if (perguntas == 2)
                {
                    Console.Clear();
                    quiz:
                    moldura();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("Qual o nome da nave de Han Solo?");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("1. Star Fighter");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("2. Millenium Falcon");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("3. Millennium Falcon");
                    Console.SetCursorPosition(5, 9);
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            break;
                        case 2:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            break;
                        case 3:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Acertou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            pontos = pontos + 1;
                            break;
                        default:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("A alternativa não existe [PRESSIONE ENTER]");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            goto quiz;
                    }
                }

                if (perguntas == 3)
                {
                    Console.Clear();
                    quiz:
                    moldura();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("Em qual filme o mestre Yoda morre?");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("1. A Ameaça Fantasma");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("2. O Retorno de Jedi");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("3. A Vingança dos Sith");
                    Console.SetCursorPosition(5, 9);
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            break;
                        case 2:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Acertou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            pontos = pontos + 1;
                            break;
                        case 3:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            break;
                        default:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("A alternativa não existe [PRESSIONE ENTER]");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            goto quiz;
                    }
                }

                if (perguntas == 4)
                {
                    Console.Clear();
                    quiz:
                    moldura();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("Qual planeta a Estrela da Morte destruiu no episodio 4??");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("1. Naboo");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("2. Hoth");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("3. Alderaan");
                    Console.SetCursorPosition(5, 9);
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            break;
                        case 2:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            break;
                        case 3:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("Acertou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            pontos = pontos + 1;
                            break;
                        default:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("A alternativa não existe [PRESSIONE ENTER]");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            goto quiz;
                    }
                }

                if (perguntas == 5)
                {
                    Console.Clear();
                    quiz:
                    moldura();
                    Console.SetCursorPosition(5, 5);
                    Console.WriteLine("Quem deu as informações sobre a nova");
                    Console.SetCursorPosition(5, 6);
                    Console.WriteLine("Estrela da Morte para os rebeldes no episodio 6 ? ");
                    Console.SetCursorPosition(5, 7);
                    Console.WriteLine("1. Nubianos");
                    Console.SetCursorPosition(5, 8);
                    Console.WriteLine("2. O imperador");
                    Console.SetCursorPosition(5, 9);
                    Console.WriteLine("3. R2-D2");
                    Console.SetCursorPosition(5, 10);
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.SetCursorPosition(5, 11);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 12);
                            break;
                        case 2:
                            Console.SetCursorPosition(5, 11);
                            Console.WriteLine("Acertou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 12);
                            pontos = pontos + 1;
                            break;
                        case 3:
                            Console.SetCursorPosition(5, 11);
                            Console.WriteLine("Errou");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 12);
                            break;
                        default:
                            Console.SetCursorPosition(5, 10);
                            Console.WriteLine("A alternativa não existe [PRESSIONE ENTER]");
                            Console.ReadKey();
                            Console.SetCursorPosition(5, 11);
                            goto quiz;
                    }
                }
                perguntas++;
            } while (perguntas <= 5);

            Console.Clear();
            moldura();
            if (pontos == 0)
            {
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("Você precisa assistir mais star wars " + pontos + " pontos");
                Console.SetCursorPosition(5, 6);
            }
            if (pontos == 1)
            {
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("Mas que pena talvez na proxima " + pontos + " pontos");
                Console.SetCursorPosition(5, 6);
            }
            else if (pontos == 2)
            {
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("Vamos pequeno garfanhoto " + pontos + " pontos");
                Console.SetCursorPosition(5, 6);
            }
            else if (pontos == 3)
            {
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("Vamos pequeno padawan " + pontos + " pontos");
                Console.SetCursorPosition(5, 6);
            }
            else if (pontos == 4)
            {
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("Um passo para se torna Jedi " + pontos + " pontos");
                Console.SetCursorPosition(5, 6);
            }
            else if (pontos == 5)
            {
                Console.SetCursorPosition(5, 5);
                Console.WriteLine("Oww você sabe bastante sobre star wars " + pontos + " pontos");
                Console.SetCursorPosition(5, 6);
            }
            Console.SetCursorPosition(5, 6);
            Console.WriteLine("Quer tentar de novo 1[SIM]...2[NAO]");
            Console.SetCursorPosition(5, 7);
            int iniciarD = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(5, 8);
            if (iniciarD == 1)
            {
                quiz();
            }
            else
            {
                Console.WriteLine("Obrigado por jogar e que a força esteja com você");
                Console.ReadKey();
            }
        }

        private static void moldura()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(3, 0);
            Console.Write("▄▄                                                        ▄▄");
            Console.SetCursorPosition(3, 1);
            Console.Write("▄▄                                                        ▄▄");
            Console.SetCursorPosition(3, 2);
            Console.Write("█                                                          █");
            Console.SetCursorPosition(3, 3);
            Console.Write("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            for (int posicao = 4; posicao <= 13; posicao++)
            {
                Console.SetCursorPosition(3, posicao);
                Console.Write("█                                                          █");
            }
            Console.SetCursorPosition(3, 14);
            Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.SetCursorPosition(3, 15);
            Console.Write("▄█                                                        █▄");
        }
    }
}
