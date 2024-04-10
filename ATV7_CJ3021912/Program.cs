namespace ATV7_CJ3021912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu
            int exercicio;
            Console.WriteLine("escreva qual exercicio deseja realizar de 1 a 7");
            exercicio = int.Parse(Console.ReadLine());
            switch (exercicio)
            {
                case 1:
                    //exercicio 1
                    Console.WriteLine("exercicio 1");
                    int num, valor = 1;
                    Console.WriteLine("insira um numero");
                    num = int.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine(valor);
                        valor++;
                    } while (valor <= num); break;
                case 2:
                    //exercicio 2
                    Console.WriteLine("exercicio 2");
                    int num1, valor1 = 1;
                    Console.WriteLine("insira um valor");
                    num1 = int.Parse(Console.ReadLine());
                    do
                    {
                        if (valor1 % 2 == 0)
                        {
                            Console.WriteLine(valor1);
                        }
                        valor1++;
                    } while (valor1 < num1); break;
                case 3:
                    //exercicio 3
                    Console.WriteLine("exercicio 3");
                    int num2, valor2 = 1;
                    Console.WriteLine("insira um numero");
                    num2 = int.Parse(Console.ReadLine());
                    do
                    {
                        if (valor2 % 2 == 0)
                        {
                            Console.WriteLine(valor2);
                        }
                        valor2++;
                    } while (valor2 < num2 || num2 > 1000); break;
                case 4:
                    //exercicio 4
                    Console.WriteLine("exercicio 4");
                    int num3, num4, num5, valor3 = 1;
                    do
                    {
                        Console.WriteLine("insira o primeiro numero");
                        num3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o segundo numero");
                        num4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("insira o terceiro numero");
                        num5 = int.Parse(Console.ReadLine());
                        if (num3 > 0)
                        {
                            Console.WriteLine(num3);
                        }
                        if (num4 > 0)
                        {
                            Console.WriteLine(num4);
                        }
                        if (num5 > 0)
                        {
                            Console.WriteLine(num5);
                        }
                    } while (num3 + num4 + num5 < 200);
                    break;
                case 5:
                    //exercicio 5
                    Console.WriteLine("exercicio 5");
                    int num6, valor4 = 1;
                    Console.WriteLine("insira um numero");
                    num6 = int.Parse(Console.ReadLine());
                    do
                    {
                        if (num6 % valor4 == 0)
                        {
                            Console.WriteLine(valor4);
                        }
                        valor4++;

                    } while (valor4 <= num6);
                    break;
                    case 6:
                    //exercicio 6
                    Console.WriteLine("exercicio 6");
                    int num7,num8,num9,num10,num11,num12,num13,num14,num15,num16, valor5 = 0;
                    Console.WriteLine("insira o primeiro numero");
                    num7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("insira o segundo numero");
                    num8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("insira o terceiro numero");
                    num9 = int.Parse(Console.ReadLine());
                    Console.WriteLine("insira o quarto numero");
                    num10 = int.Parse(Console.ReadLine());
                    Console.WriteLine("insira o quinta numero");
                    num11 = int.Parse(Console.ReadLine());
                    Console.WriteLine("insira o sexta numero");
                    num12 = int.Parse(Console.ReadLine());
                    Console.WriteLine("insira o setimo numero");
                    num13 = int.Parse(Console.ReadLine());
                    Console.WriteLine("insira o oitavo numero");
                    num14 = int.Parse(Console.ReadLine());
                    Console.WriteLine("insira o nono numero");
                    num15 = int.Parse(Console.ReadLine());
                    Console.WriteLine("insira o decimo numero");
                    num16 = int.Parse(Console.ReadLine());
                    break;
                    do
                    {
                        valor5++;
                        if (valor5 > num7 || valor5 > num8 || valor5 > num9 || valor5 > num10 || valor5 > num11 || valor5 > num12 || valor5 > num13 || valor5 > num14 || valor5 > num15 || valor5 > num16)
                        {
                            Console.WriteLine(valor5);
                        }

                    }
            }
        }
    }
}
