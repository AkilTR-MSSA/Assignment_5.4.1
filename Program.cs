DisplayDigits_Recursive(1234);
void DisplayDigits_Recursive(int n)
{
    if (n > 0)
    {
        DisplayDigits_Recursive(n / 10);
        Console.Write($"{n % 10} ");
    }
}