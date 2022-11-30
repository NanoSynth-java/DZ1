// int result = 0;
// Console.Write("Enter 1st number ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter 2nd number ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2)
//     result = number1;
// else
//     result = number2;
// Console.WriteLine("Число " + result + " наибольшее из двух чисел");



// int newMax = 0;
// Console.WriteLine("Введите первое число");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int numberTwo = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int numberThree = Convert.ToInt32(Console.ReadLine());
// if (numberOne > numberTwo && numberOne > numberThree) 
// {
//     newMax = numberOne;
//     Console.WriteLine("Наибольшее из трёх чисел " + newMax);
// } else if (numberTwo > numberOne && numberTwo > numberThree) 
// {
//     newMax = numberTwo;
//     Console.WriteLine("Наибольшее из трёх чисел " + newMax);
// } else if (numberThree > numberOne && numberThree > numberTwo) 
// {
//     newMax = numberThree;
//     Console.WriteLine("Наибольшее из трёх чисел " + newMax);
// }
// else
//     Console.WriteLine("Попробуйте ещё раз ");



// Console.WriteLine("Введите любое число, что бы определить является ли оно чётным: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0)
// {
//     Console.WriteLine("Число " + number + " является чётным");
// }
// else Console.WriteLine("Число " + " является не чётным");



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}