Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
MakeReverse(number);

void MakeReverse(int current_number)
{
    int ch1 = current_number / 100;
    int ch2 = (current_number / 10) % 10;
    int ch3 = (current_number % 100) % 10;
    Console.WriteLine(current_number + " >> " + $"{ch3}" + $"{ch2}" + $"{ch1}");
}