Console.WriteLine("Введите 3 числа");
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

}
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int fhirdNumber = int.Parse(Console.ReadLine());

int max = Max(firstNumber, secondNumber, fhirdNumber);

Console.WriteLine(max);
