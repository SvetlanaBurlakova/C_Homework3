// See https://aka.ms/new-console-template for more information
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}

void Cube(int num)
{
    for (int i=1; i <= num; i++) Console.WriteLine(Math.Pow(i,3));
}
int num=GetNumber("Введите целое число");
Cube(num);
