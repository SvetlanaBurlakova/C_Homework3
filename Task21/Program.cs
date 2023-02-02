// See https://aka.ms/new-console-template for more information
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
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

double Distance(int x1,int y1, int z1, int x2,int y2, int z2)
{
    double result=Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
    return result;
}
int x1=GetNumber("введите координату x1");
int y1=GetNumber("введите координату y1");
int z1=GetNumber("введите координату z1");
int x2=GetNumber("введите координату x2");
int y2=GetNumber("введите координату y2");
int z2=GetNumber("введите координату z2");

double dist=Distance(x1,y1,z1,x2,y2,z2);
string str1 ="(" + x1 +"," + y1 + "," + z1 + ")";
string str2 ="(" + x2 +"," + y2 + "," + z2 + ")";

Console.WriteLine($"Расстояние между точками {str1} и {str2} равняется {dist:0.##}");
