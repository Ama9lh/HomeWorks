Console.Clear();
while(true)
{
    Console.Write("Введите свое трёхзначное число: ");
    int numb = Convert.ToInt32(Console.ReadLine());

    if(numb >= 99 && numb <= 999)     // && - И,   || - Или,....
    {
        int temp = numb % 10;
        temp = numb / 10;
        temp = temp % 10; 
        Console.WriteLine(temp);
        break;
    }

    else
    {
        Console.WriteLine("Введено неверное число, введите трёхзначное число ");
        

    }
}





