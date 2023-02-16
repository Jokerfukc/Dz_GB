System.Console.WriteLine("На вход принимается трёхзначное число и показывается вторая цифра этого числа");
double number;
System.Console.Write("Введите трёхзначное число: ");
while(!double.TryParse(Console.ReadLine(), out number))
    {
        System.Console.Write("Неправильный ввод данных! Введите число: ");
    }
number = Math.Abs(number);
if(((int)number / 100 > 0) && ((int)number / 1000 == 0))
    {
        FindSecondDigit(number);
    }
else
    {
    System.Console.WriteLine("Не верный ввод числа!");
    }

static void FindSecondDigit(double number)
    {
        int result;
        //Math.Abs(number);
        if(number > 99 && number < 1000)
        {
            number = (int)number / 10;
            result = (int)number % 10;
            System.Console.WriteLine($"Вторая цифра трёхзначного числа: {result}");
        }
        else 
        {
            System.Console.WriteLine("Число не трёхзначное!!");
        }
    }