Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
MakeReverse(number);

void MakeReverse(int current_number)
{
    if (current_number < 100) 
    {
        Console.WriteLine("Вы ввели неверное число, введите заново");
    }
    else
    {
        if (current_number > 1000)
        {
            Console.WriteLine("Вы ввели неверное число, введите заново");
        }
        else 
            {
                int ch1 = current_number / 100;
                int ch2 = (current_number / 10) % 10;
                int ch3 = (current_number % 100) % 10;
                Console.WriteLine(current_number + " >> " + $"{ch3}" + $"{ch2}" + $"{ch1}");
            }
    }

}