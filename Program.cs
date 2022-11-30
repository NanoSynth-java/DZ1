int result = 0;
Console.Write("Enter 1st number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2nd number ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
result = number1;
else
result = number2;
Console.WriteLine("Число " + result + " наибольшее из двух чисел");
