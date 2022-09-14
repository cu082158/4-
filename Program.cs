/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число 
A в натуральную степень B.
 */

// Console.Write("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int Exponentiation(int numberA, int numberB)
// {
//   int result = 1;
//   for(int i=1; i <= numberB; i++)
//   {
//     result = result * numberA;
//   }
//     return result;
// }
//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponentiation);


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

//   int GetSumNumber(int number)
//   {
//     int count = Convert.ToString(number).Length;
//     int start = 0;
//     int result = 0;

//     for (int i = 0; i < count; i++)
//     {
//       start = number - number % 10;
//       result = result + (number - start);
//       number = number / 10;
//     }
//    return result;
//   }
// int GetsumNumber = GetSumNumber(number);
// Console.WriteLine("Сумма цифр в числе: " + GetsumNumber);

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
 */

// Console.Write("Введите числа через запятую ");
// int array = Convert.ToInt32(Console.ReadLine());

// int[] GetBinaryArray(int size)
// {
//     int[] result = new int [8];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = array;
//     }
//     return result;
// }
// int[] testArray = GetBinaryArray(8);
// Console.WriteLine($"Массив: [ {String.Join("; ",testArray)} ]");

// Ни фига не разобралась с этой функцией((

