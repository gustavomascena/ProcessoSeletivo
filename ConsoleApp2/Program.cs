namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ultimoNumero = 1;
            int penultimoNumero = 0;
            int soma = ultimoNumero + penultimoNumero;

            Console.WriteLine("Digite um número inteiro.");
            int numeroDigitado = Int32.Parse(Console.ReadLine());

            while (soma < numeroDigitado)
            {
                penultimoNumero = ultimoNumero;
                ultimoNumero = soma;
                soma = ultimoNumero + penultimoNumero;
            }
            if (soma == numeroDigitado || ultimoNumero == numeroDigitado || penultimoNumero == numeroDigitado)
            {
                Console.WriteLine("O número que você digitou pertence a sequência de Fibonacci!");
            }
            else
            {
                Console.WriteLine("O número que você digitou não pertence a sequência de Fibonacci!");
            }
        }
    }
}

