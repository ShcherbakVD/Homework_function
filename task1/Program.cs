void EnterIntegerNumber()
{
    while (true)
    {
        Console.Write("Введите целое число; для выхода нажмите 'q':");
        string input = Console.ReadLine();
        if (input == "q")
        {
            break;
        }

        int number = Convert.ToInt32(input);
        int sum = 0;
        while (number >= 1)
        {
            sum = sum + number % 10;
            number = number / 10;
        }

        if (sum % 2 == 0)
        {
            break;
        }
    }
}

EnterIntegerNumber();
Console.Write("STOP");
