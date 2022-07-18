// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

Console.WriteLine("Etner the number");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number < 100)
{
   Console.WriteLine("There is no third digit"); 
}
if (number > 99 && number < 1000)
{
    Console.WriteLine(number % 10);
}