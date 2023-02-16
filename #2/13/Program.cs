System.Console.WriteLine("Необходимо вывести третью цифру заданного числа или сообщить, что третьей цифры нет.");
double number;
System.Console.Write("Введите любое число: ");
while(!double.TryParse(Console.ReadLine(), out number))
    {
        System.Console.Write("Неправильный ввод данных! Введите число: ");
    }
FindThirdDigit(number); 

static void FindThirdDigit(double number)
    {
        int result;
        number = Math.Abs(number);
        if (number > 99)
        {
            while (number > 999)
            {
                number /= 10;
            }
            result = (int)number % 10;
            System.Console.WriteLine($"Третья цифра в числе: {result}");
        }
        else
        {
            System.Console.WriteLine("Третьей цифры нет");
        }
    }