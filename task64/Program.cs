/*Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

void PrintNaturalNumbers(int n){
    if (n == 1) Console.Write(n);
    else if (n > 0) {
        Console.Write($"{n}, ");
        n--; 
        PrintNaturalNumbers(n);
    }
    else Console.WriteLine("Введено не натуральное число");
}

Console.Write("Введите число: ");
PrintNaturalNumbers(Convert.ToInt32(Console.ReadLine()));