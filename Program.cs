//  Программа, к-рая на вход принимает число N, а на выходе показывает 
// все целые числа в  промежутке
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

int number = Convert.ToInt32(Console.ReadLine());
// -N = N * (-1)
int negativNumber = number * (-1);

while (negativNumber <= number)
{
    Console.WriteLine(negativNumber);
    negativNumber++; // 
}



Console.WriteLine("Hello, World!");
