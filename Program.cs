// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());


//  int toPow(int num1, int num2)
//  {
//     int result = 1;
//     for (int i = 1; i <= num2; i++ )
//     {
//         result *= num1;
//     }
//     return result;
//  }

// int res = toPow(A,B);
// Console.WriteLine(res);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Counter(int num)
// {
//     int i = 0;
//     while (num > 0)
//         {
//             num = num/10;
//             i++;
//         }
//     return i;
// }

// int count = Counter(number);

// int Summ(int num)
// {
//     int sum = 0;
//     for  (int j = 0; j < count; j++)
//         {
    
//             sum = sum + num%10;
//             num = num/10;  
    
//         }
//     return sum;
// }

// int s = Summ(number);
// Console.WriteLine(s);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] array = new int[8];
void InputArray()
{
 for(int i = 0; i < 8; i++)
 {
    Console.Write("Введите очередной элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
 }
}
InputArray();
Console.WriteLine(String.Join(", ", array)); 
