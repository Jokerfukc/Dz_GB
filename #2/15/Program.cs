System.Console.WriteLine("Проверка на выходной день.");
System.Console.Write("Введите номер дня недели: ");
int number;
while(!int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.Write("Неправильный ввод данных! Введите число: ");
    }
IfHolliday(number);

static void IfHolliday(int dayNumber)
    {
        if(dayNumber >= 1 && dayNumber <= 5) 
        {
            System.Console.WriteLine("Будний день");
        }
        else if(dayNumber >= 6 && dayNumber <= 7)
        {
            System.Console.WriteLine("Выходной день");
        }
        else
        {
            System.Console.WriteLine("Нет такого дня недели!");
        }
    }