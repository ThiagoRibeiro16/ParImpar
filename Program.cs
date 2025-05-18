Console.Clear();

double num;
double resultado;

Console.Write("Digite um número: ");
num = Convert.ToDouble(Console.ReadLine());

resultado = num % 2;

if (resultado != 0)
{
    Console.WriteLine("o número é impar");
}

else
{
    Console.WriteLine("o número é par");

}
