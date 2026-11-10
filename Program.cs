//task1
// bool result = IsDivisible(15, 3);
// Console.WriteLine(result);

// bool IsDivisible(int number, int divisor)
// {
//     return number % divisor == 0;
// }

//task2
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(GetNumberType(number));

// string GetNumberType(int number)
// {
//     if (number % 2 == 0)
//     {
//         return "Even";
//     }
//     else
//     {
//         return "Odd";
//     }
// }


//task3
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountNumbers(a, b));

// int CountNumbers(int a, int b)
// {
//     int rakam = a - b;
//     if (rakam < 0)
//     {
//         rakam = -rakam;
//     }
//     if (rakam == 0)
//     {
//         return 0;
//     }
//     return rakam - 1;
// }

//task 4
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumFromOneToN(n));

// int SumFromOneToN(int n)
// {
//     int sum = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }


//task5
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Factorial(n));

// long Factorial(int n)
// {
//     long result = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }  



// classtask 6
// int ReverseNumber(int number)
// {
//     int reversed = 0;

//     for (; number > 0; number /= 10)
//     {
//         int digit = number % 10;
//         reversed = reversed * 10 + digit;
//     }

//     return reversed;
// }

// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine(ReverseNumber(number));


// classtask 7
// int CountDigits(int number)
// {
//     int count = 0;

//     if (number == 0)
//         return 1;

//     if (number < 0)
//         number = -number;

//     for (; number > 0; number /= 10)
//     {
//         count++;
//     }

//     return count;
// }

// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine(CountDigits(number));


// classtask 8
// int SumEvenDigits(int number)
// {
//     int sum = 0;

//     if (number < 0)
//         number = -number;

//     for (; number > 0; number /= 10)
//     {
//         int digit = number % 10;

//         if (digit % 2 == 0)
//         {
//             sum += digit;
//         }
//     }

//     return sum;
// }

// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine(SumEvenDigits(number));



// classtask 9
// int MaxDigit(int number)
// {
//     if (number < 0)
//         number = -number;

//     int max = 0;

//     for (; number > 0; number /= 10)
//     {
//         int digit = number % 10;

//         if (digit > max)
//         {
//             max = digit;
//         }
//     }

//     return max;
// }

// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine(MaxDigit(number));




bool IsPrime(int number)
{
    if (number < 2)
        return false;

    for (int i = 2; i * i <= number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }

    return true;
}

int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(IsPrime(number));
