using System;

namespace CalculadoraAmiga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, meu nome é Zayn! Hoje serei sua calculadora, vamos começar!!!");
            Console.WriteLine("Primeiro de tudo preciso saber seu nome");
            Console.Write("Digite seu nome: ");
            string nome=Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("Prazer em conhece-lo " + nome + "\nPressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine(nome + " eu tenho uma lista de quatro operações matemáticas que são elas:\nSoma; Subtração; Multiplicação\nDivisão; Raiz Quadrada e Potência");
            Console.WriteLine("Escolha uma das quatro e então poderemos começar a calcular!");
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            
            string sair;
            do
            {
                
                Console.Write(nome + " Digite uma das operações matemáticas da lista: ");
                string operação=Console.ReadLine().ToLower();
                Console.WriteLine("Agora digite dois números que queira calcular");
                Console.Write("1° número: ");
                double valor1=Convert.ToDouble(Console.ReadLine());
                Console.Write("2° número: ");
                double valor2=Convert.ToDouble(Console.ReadLine());
                
                if(operação=="soma")
                Console.WriteLine(valor1 + " + " + valor2 + " = " + (valor1 + valor2));
                else if(operação=="subtração")
                Console.WriteLine(valor1 + " - " + valor2 + " = " + (valor1 - valor2));
                else if(operação=="multiplicação")
                Console.WriteLine(valor1 + " X " + valor2 + " = " + (valor1 * valor2));
                else if(operação=="divisão")
                Console.WriteLine(valor1 + " / " + valor2 + " = " + (valor1 / valor2));
                else if(operação=="raiz quadrada")
                Console.WriteLine(Math.Sqrt(valor1));
                else if(operação=="potência")
                Console.WriteLine(Math.Pow(valor1, valor2));
                else
                Console.WriteLine(nome + " você não digitou nenhuma das operações da lista ou deve ter digitado errado");

                Console.Write("Deseja parar de calcular, SIM ou NÃO: ");
                sair=Console.ReadLine().ToUpper();
                Console.Clear();

            
            } while (sair != "SIM" && sair != "S");

            Console.Clear();
            Console.WriteLine("Obrigrado " + nome + " por usar a calculadora!\nAté a próxima!");
            
        }
    }
}
