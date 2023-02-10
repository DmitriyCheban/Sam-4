/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

  int g(int num){
    
    int counter = Convert.ToString(num).Length;
    int B = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      B = num - num % 10;
      result = result + (num - B);
      num = num / 10;
    }
   return result;
  }

int s = g(num);
Console.WriteLine("Сумма: " + s);