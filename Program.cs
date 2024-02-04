// Задача 1: 
// Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

/*
int m = 1;
int n = 5;


void PrintNumbInRange(int m, int n)
{
    if (m <= n)// 1<=5; 2<=5; 3<=5; 4<=5; 5<=5, 6<=5 
    {
        System.Console.Write(m + ", "); // 1, 2, 3, 4, 5
    
    PrintNumbInRange(m + 1, n); // 1+1, 2+1, 3+1, 4+1, 5+1
    }
    return;
}

PrintNumbInRange(m, n);
*/

// ******************************************************************************

// Задача 2: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

/*
int n = 3;
int m = 2;


int PrintAckermann(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (n > 0 && m == 0)
    {
        return PrintAckermann(n - 1, 1);
    }
    else 
    {
        return PrintAckermann(n - 1, PrintAckermann(n, m - 1));
    }
}

int result = PrintAckermann(n, m);
System.Console.WriteLine(result);
*/

// *****************************************************************************************

// Задача 3: 
// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


int[] array = {1, 2, 5, 0, 10, 34};

void PrintArrRevers(int[] arr, int i)
{
    if (i < 0)
    return;

    System.Console.Write(arr[i] + " "); // вывод текущего элемента
    PrintArrRevers(arr, i - 1); // рекурсия для след. элемента 
}
    PrintArrRevers(array, array.Length - 1);


// ****************************************************************************************