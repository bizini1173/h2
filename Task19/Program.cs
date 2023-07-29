// Задача 19
// Напишите программу, которая 
// 1.принимает на вход пятизначное число и 
// 2.проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Введено не пятизначное число.");
    return;
}

bool isPalindrome = IsPalindrome(num);

if (isPalindrome)
{
    Console.WriteLine("Введенное число является палиндромом.");
}
else
{
    Console.WriteLine("Введенное число НЕ является палиндромом.");
}

    static bool IsPalindrome(int number)
{
    int firstDigit = number / 10000; 
    int fifthDigit = number % 10;    
    int secondDigit = (number / 1000) % 10; 
    int fourthDigit = (number / 10) % 10;   

    return (firstDigit == fifthDigit) && (secondDigit == fourthDigit);
}

