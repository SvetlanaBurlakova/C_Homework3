// See https://aka.ms/new-console-template for more information
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 10000 && result <100000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Введите 5-значное число. Повторите ввод");
        }
    }

    return result;
}
bool Palindrom(int num)
{
    if ((num / 10000 == num%10) && ((num /1000)%10 == (num%100)/10)) return true;
    else return false;
}

int number=GetNumber("Введите 5-значное число:");
bool result=Palindrom(number);
if (result==true) Console.WriteLine($"число {number} является палиндромом");
else Console.WriteLine($"число {number} не является палиндромом");
//Console.WriteLine(number/10000);
//Console.WriteLine(number%10);
//Console.WriteLine((number/1000)%10);
//Console.WriteLine((number%100)/10);