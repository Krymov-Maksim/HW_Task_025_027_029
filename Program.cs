// // Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и 
// // возводит число А в натуральную степень В.

// void PowAToB(int aa, int bb)
// {
//     int result = 1;

//     for (int i = 1; i <= bb; i++)
//         result = (result * aa);

//     Console.WriteLine(result);
// }

// int a = -2;
// int b = 0;

// PowAToB(a, b);


// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// int PowAToB(int aa, int bb)  // метод возведения в степень
// {
//     int result = 1;

//     for (int i = 1; i <= bb; i++)
//         result = (result * aa);
//     return result;
// }


// void SumDigitInNum(int num)     // метод определения суммы цифр в многозначном числе
// {
//     int count = 1;
//     int numtemp = num;
//     int sum = 0;
//     while (numtemp >= 10)        // Определяем количество цифр в числе *count*
//     {
//         numtemp /= 10;
//         count++;
//     }

//     numtemp = num;                 
//     int digit = 0;
//     while (count >= 1)          // отделяем каждую цифру от числа *digit* и суммируем *sum*
//     {
//         digit = numtemp / PowAToB(10,count-1);
//         sum = sum + digit;  
//         numtemp = numtemp - digit * PowAToB(10,count-1);
//         count--;
//     }
//     Console.WriteLine($"Сумма цифр в числе {sum}");

// }

// Console.WriteLine("Please enter the number:");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 0)                                                // проверка на отрицательность и перевод в *+*
// {
//     num *= (-1);
// }
// SumDigitInNum(num);



// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int NumArray)
// {
//     int[] array = new int[NumArray];
//     for (int i = 0; i < NumArray; i++)
//     {
//         array[i] = new Random().Next(0, 100);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ",");
//     }
//     Console.Write("]");
// }

// Console.WriteLine("How array do you need?");
// int NumArray = Convert.ToInt32(Console.ReadLine());
// if (NumArray < 1 || NumArray > 8)
// {
//     Console.WriteLine("Out of range! Need from 1 to 8.");
// }
// else
//     Console.WriteLine("How array do you need?");

// ShowArray(CreateRandomArray(NumArray));

