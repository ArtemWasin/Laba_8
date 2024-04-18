Console.WriteLine("Задание 2");
Console.WriteLine("Создать класс BitString для работы с 64-битовыми строками. Битовая строка должна быть представлена двумя полями типа unsigned long. Должны быть реализованы все традиционные операции для работы с битами: and, or, xor, not. Реализовать сдвиг влево shiftLeft и сдвиг вправо shiftRight на заданное количество битов.");
ulong value1 = 0, value2 = 0;
bool inputSuccess = false;

while (inputSuccess == false)
{
    try
    {
        Console.Write("Введите первое 64-битовое число: ");
        value1 = Convert.ToUInt64(Console.ReadLine());

        Console.Write("Введите второе 64-битовое число: ");
        value2 = Convert.ToUInt64(Console.ReadLine());

        if (value1 != 0 & value2 != 0)
        {
            inputSuccess = true;
        }
    }
    catch
    {
        Console.WriteLine("Ошибка ввода данных. Повторите попытку.");
    }
}

Console.WriteLine("Выберите операцию:");
Console.WriteLine("1 - AND");
Console.WriteLine("2 - OR");
Console.WriteLine("3 - XOR");
Console.WriteLine("4 - NOT");
Console.WriteLine("5 - Сдвиг влево");
Console.WriteLine("6 - Сдвиг вправо");
Console.WriteLine("7 - Выход");

BitString bitString = new BitString(value1, value2);

bool flag = true;
while (flag)
{
    try
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Результат операции AND: " + bitString.And());
                break;
            case 2:
                Console.WriteLine("Результат операции OR: " + bitString.Or());
                break;
            case 3:
                Console.WriteLine("Результат операции XOR: " + bitString.Xor());
                break;
            case 4:
                Console.WriteLine("Результат операции NOT для числа 1: " + bitString.Not1());
                Console.WriteLine("Результат операции NOT для числа 2: " + bitString.Not2());
                break;
            case 5:
                Console.Write("Введите количество битов для сдвига: ");
                int numBitsLeft = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат сдвига влево числа 1: " + bitString.ShiftLeft1(numBitsLeft));
                Console.WriteLine("Результат сдвига влево числа 2: " + bitString.ShiftLeft2(numBitsLeft));
                break;
            case 6:
                Console.Write("Введите количество битов для сдвига: ");
                int numBitsRight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат сдвига вправо числа 1: " + bitString.ShiftRight1(numBitsRight));
                Console.WriteLine("Результат сдвига вправо числа 2: " + bitString.ShiftRight2(numBitsRight));
                break;
            case 7:
                flag = false;
                break;
            default:
                Console.WriteLine("Ошибка: Некорректный выбор операции.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ошибка: Некорректный ввод. Попробуйте еще раз.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Ошибка: Слишком большое число. Попробуйте еще раз.");
    }
}

class BitString
{
    private ulong value1;
    private ulong value2;

    public BitString(ulong value1, ulong value2)
    {
        this.value1 = value1;
        this.value2 = value2;
    }

    public ulong And()
    {
        return value1 & value2;
    }

    public ulong Or()
    {
        return value1 | value2;
    }

    public ulong Xor()
    {
        return value1 ^ value2;
    }

    public ulong Not1()
    {
        return ~value1;
    }

    public ulong Not2()
    {
        return ~value2;
    }

    public ulong ShiftLeft1(int numBits)
    {
        return value1 << numBits;
    }

    public ulong ShiftLeft2(int numBits)
    {
        return value2 << numBits;
    }

    public ulong ShiftRight1(int numBits)
    {
        return value1 >> numBits;
    }

    public ulong ShiftRight2(int numBits)
    {
        return value2 >> numBits;
    }
}