Console.Clear();
Console.Write("Введите число: ");
int k = Convert.ToInt32(Console.ReadLine());

if (k >= 100)
{
    while(k >= 100)
    {
        k /= 10;
        int d = k % 10;
        Console.WriteLine(d);    
    }
    
}
else 
    Console.WriteLine ("Третьей цифры нет. ");
