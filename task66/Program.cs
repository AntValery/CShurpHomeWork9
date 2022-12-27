/*Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumNaturalNumbers(int m, int n){
    if (m < 0 && n < 0) return -1;
    if (m < 0 && n > 0) m = 0;
    else if(n < 0 && m > 0) n = 0;

    if(m == 0) return ((n * (n + 1))/2);
    else if (n == 0) return ((m * (m + 1))/2);
    else if (m == n) return m;
    else if (m < n) return (n + SumNaturalNumbers(m, n - 1));
    else return n + SumNaturalNumbers(m,n + 1);
}

void PrintResult(){
    Console.Write("M = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("N = ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = SumNaturalNumbers(m, n);
    
    if(sum == -1) Console.WriteLine("Нет суммы в таком диапазоне");
    else Console.WriteLine(sum);
}

PrintResult();

