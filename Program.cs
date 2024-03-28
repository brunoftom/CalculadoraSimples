using CalculadoraSimples.Models;

internal class Program
{
    public static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        while(true)
        {
            Console.WriteLine("\nMENU CALCULADORA!!");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Potência");
            Console.WriteLine("6. Seno");
            Console.WriteLine("7. Coseno");
            Console.WriteLine("8. Tangente");
            Console.WriteLine("9. Raíz Quadrada");
            Console.WriteLine("10. Sair");

            Console.WriteLine("Digite a operação desejada: ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            
            switch(escolha)
            {
            case 1:
                Console.WriteLine("\nDigite o primeiro numero: ");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int B = Convert.ToInt32(Console.ReadLine());
                calc.Somar(A,B);
            break;
            case 2:
                Console.WriteLine("\nDigite o primeiro numero: ");
                int C = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int D = Convert.ToInt32(Console.ReadLine());
                calc.Subtrair(C,D);
            break;
            case 3:
                Console.WriteLine("\nDigite o primeiro numero: ");
                int E = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int F = Convert.ToInt32(Console.ReadLine());
                calc.Multiplicar(E,F);
            break;
            case 4:
                Console.WriteLine("\nDigite o primeiro numero: ");
                int G = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int H = Convert.ToInt32(Console.ReadLine());
                calc.Dividir(G,H);
            break;
            case 5:
                Console.WriteLine("\nDigite o primeiro numero: ");
                int I = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int J = Convert.ToInt32(Console.ReadLine());
                calc.Potencia(I,J);
            break;
            case 6:
                Console.WriteLine("\nDigite o numero: ");
                int K = Convert.ToInt32(Console.ReadLine());
                calc.Seno(K);
            break;
            case 7:
                Console.WriteLine("\nDigite o numero: ");
                int L = Convert.ToInt32(Console.ReadLine());
                calc.Coseno(L);
            break;
            case 8:
                Console.WriteLine("\nDigite o numero: ");
                int M = Convert.ToInt32(Console.ReadLine());
                calc.Tangente(M);
            break;
            case 9:
                Console.WriteLine("\nDigite o numero: ");
                int N = Convert.ToInt32(Console.ReadLine());
                calc.raizQ(N);
            break;
            case 10:
                Console.WriteLine("\nFinalizando o programa!!\n");
                Environment.Exit(0);
            break;
            default:
                Console.WriteLine("Opção inválida!!");
                break;
            }
        }
    }
}