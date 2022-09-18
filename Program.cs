// ═══════════════════════════════ Главное меню и основные функции ═══════════════════════════════

int choice = 1; // ТЕКУЩИЙ ВЫБРАННЫЙ ЭЛЕМЕНТ
// Список меню
string[] ListMenu = {
    "  Задача 41: Сколько чисел меньше нуля                                    ",
    "  ЗАДАЧА 43: Найти точку пересечения линий (k1,b1) и (k2,b2)              ",
    "  ЗАДАЧА 38: Разница между минимальным и максимальным значением массива   ",
    "  ЗАДАЧА HARD STAT: Массив целых чисел                                    ",
    "  ВЫХОД ИЗ ПРОГРАММЫ                                                      "};
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
void menu() // Функция выводит главное меню на экран консоли
{
    int CurrentLine = 1;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(choice);
    int i = 0;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("═══════════════════════  Г Л А В Н О Е   М Е Н Ю  ════════════════════════\n");
    Console.ForegroundColor = ConsoleColor.White;
    while (i < ListMenu.Length)
    {
        CurrentLine = i + 1;
        if (choice == CurrentLine)
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            Console.Write($"{ListMenu[i].ToUpper()}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.Write($"{ListMenu[i]}\n");
        }
        i++;
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n" +
    "╔════════════════════════════════════════════════════════╤═══════════════╗\n" +
    "║  Используйте [стрелки] для навигации.                  │   ▲ : Вверх   ║\n" +
    "║  [ENTER] - Выбор выделенного пункта                    │   ▼ : Вниз    ║\n" +
    "╚════════════════════════════════════════════════════════╧═══════════════╝\n");
    Console.BackgroundColor = ConsoleColor.Black;
}
int GetNum() // Запрос на ввод целого числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое число... ");
    int result1 = Convert.ToInt32(Console.ReadLine());
    return result1;
}
double GetDouble() // Запрос на ввод Вещественного числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое или дробное число... ");
    double result1 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
    return result1;
}
void ErrorCatch() // Функция обрабатывает ошибку, выдает сообщение и запускает программу с начала
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("" +
    "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
    "  ║  Возможно вы ввели не верные данные.                ║\n" +
    "  ║  Программа будет перезапущена...                    ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    pause();
}
void pause() // Функция паузы, для чтения результатов
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("" +
    "  ╔═════════════════════════════════════════════════════╗\n" +
    "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    try
    {
        main();
    }
    catch
    {
        ErrorCatch();
    }
}
void ext() // Функция задает пользователю вопрос хочет ли он выйти из программы и закрывает ее если ответ да
{
AskAgayn:
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("  ╔═ В Ы Х О Д   И З   П Р О Г Р А М М Ы ═══════════════╗  \n" +
    "  ║      Вы уверены что хотите закрыть программу?       ║  \n" +
    "  ║              [ENTER] Да     [ESC] Нет               ║  \n" +
    "  ╚═════════════════════════════════════════════════════╝  \n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("" +
        "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
        "  ║  Вам нужно нажать [ENTER] или [ESC].                ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("" +
        "  ╔═════════════════════════════════════════════════════╗\n" +
        "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        ConsoleKeyInfo key1;
        key1 = Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
        goto AskAgayn;
    }
    else if (key.Key == ConsoleKey.Escape) main();
    else if (key.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        System.Environment.Exit(0);
    }
    else main();
}
void ShowArray(int[] array1) // Вывести на экран массив
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (i != array1.Length - 1) Console.Write($"{array1[i]}, ");
        else Console.WriteLine($"{array1[i]}.\n");
    }
}
void ShowRealArray(double[] array1) // Вывести на экран вещественный массив
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (i != array1.Length - 1) Console.Write($"{array1[i]}, ");
        else Console.WriteLine($"{array1[i]}.\n");
    }
}

// ═══════════════════════════════ ДОМАШНЕЕ ЗАДАНИЕ ═══════════════════════════════

// 1 Задача //
int HowManyLessZero(int[] array1)
{
    int result = 0;
    for (int ii = 0; ii < array1.Length; ii++)
    {
        if (array1[ii] < 0)
        {
            result = result + 1;
        }
    }
    return (result);
}
int[] FillArrayFromKeyboard(int ArrayLength)
{
    int[] array1 = new int[ArrayLength];
    for (int i = 0; i < ArrayLength; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число");
        array1[i] = GetNum();
    }
    return (array1);
}

// 2 Задача //
double[] FindPoint(double k1, double k2, double b1, double b2)
{
    double[] result = new double[2];
    double x = 0;
    double y = 0;
    // y = k1 * x + b1
    // y = k2 * x + b2
    // k1 * x + b1 = k2 * x + b2
    // - k2 + (k1 * x + b1) = b2
    // (k1 - k2) * x - b1 = b2
    // (k1 - k2) * x = b2 + b1
    x = (b1 - b2) / (k2 - k1);
    y = k1 * x + b1;
    return (result);
}

// 3 Задача //
double[] TriangleCorn(double a, double b, double c)
{
    double[] result = new double[3];
    if (a + b > c && b + c > a && c + a > b)
    {
        double Corna = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
        double Cornb = Math.Acos((b * b + c * c - a * a) / (2 * c * b));
        double Cornc = Math.Acos((c * c + a * a - b * b) / (2 * a * c));
        Corna = Math.Round((Corna * 180 / Math.PI), 2);
        Cornb = Math.Round((Cornb * 180 / Math.PI), 2);
        Cornc = Math.Round((Cornc * 180 / Math.PI), 2);
        result[0] = Corna;
        result[1] = Cornb;
        result[2] = Cornc;
    }
    else
    {
        Console.WriteLine("Это не треугольник");
        pause();
    }
    return (result);
}
string[] Triangle(double a, double b, double c)
{
    string[] result = new string[3];
    if (a + b > c && b + c > a && c + a > b)
    {
        double quada = a * a;
        double quadb = b * b;
        double quadc = c * c;
        if (quada == quadc + quadb ^ quadb == quada + quadc ^ quadc == quada + quadb) result[0] = "Треугольник является прямоугольным";
        else result[0] = "Треугольник не является прямоугольным";
        if (a == b && b == c && c == a) result[1] = "Треугольник является равносторонним";
        else result[1] = "Треугольник не является равносторонним";
        if (a == b ^ b == c ^ c == a) result[2] = "Треугольник является равнобедренным";
        else result[2] = "Треугольник не является равнобедренным";
    }
    else
    {
        Console.WriteLine("Это не треугольник");
        pause();
    }
    return (result);
}

// 4 Задача //
int[,] Fill2dArray(int[,] result, int x, int y)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
        retry:
            int tempnum1 = new Random().Next(x, y);
            for (int i1 = 0; i1 < result.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < result.GetLength(1); j1++)
                {
                    if (tempnum1 == result[i1, j1]) goto retry;
                }
            }
            result[i, j] = tempnum1;
        }
    }
    return (result);
}
void PrintArray(int[,] array1)
{
    for (int k = 0; k < array1.GetLength(1); k++)
    {
        Console.Write("───────────");
    }
    Console.WriteLine();
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (j == array1.GetLength(1) - 1) Console.Write($"    │    {array1[i, j]}    │\n");
            else if (j == 0) Console.Write($"│    {array1[i, j]}");
            else Console.Write($"    │    {array1[i, j]}");
        }
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            Console.Write("───────────");
        }
        Console.WriteLine();
    }
}
int[] Max2dArray(int[,] array1)
{
    int imax = 0;
    int jmax = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (array1[i, j] > array1[imax, jmax])
            {
                imax = i;
                jmax = j;
            }
        }
    }
    int [] result = new int [3];
    result[0] = array1[imax, jmax];
    result[1] = imax;
    result[2] = jmax;
    return (result);
}

int[] Min2dArray(int[,] array1)
{
    int imin = 0;
    int jmin = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (array1[i, j] < array1[imin, jmin])
            {
                imin = i;
                jmin = j;
            }
        }
    }
    int [] result = new int [3];
    result[0] = array1[imin, jmin];
    result[1] = imin;
    result[2] = jmin;
    return (result);
}

// ═════════════════════════════════════════════════════════════════════════════════════════════


// ═══════════════════════════════ Обработка выбранного элемента в меню ═══════════════════════════════

// ВЫПОЛНЕНИЕ ПРОГРАММЫ И ОТСЛЕЖИВАНИЕ НАЖАТИЯ КЛАВИШ
void main()
{
restart:
    menu();
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        if (choice <= ListMenu.Length)
        {
            if (choice == 1)
            {
                choice = ListMenu.Length;
                goto restart;
            }
            else
            {
                choice = choice - 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (choice >= 1)
        {
            if (choice == ListMenu.Length)
            {
                choice = 1;
                goto restart;
            }
            else
            {
                choice = choice + 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        // Здесь объявляются функции которые программа выполнит при выборе того или иного пункта меню
        switch (choice)
        {
            case 1:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\n" +
                "0, 7, 8, -2, -2 -> 2\n" +
                "1, -7, 567, 89, 223-> 3");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Сколько чисел нужно проверить?");
                int num3 = GetNum();
                int[] array5 = FillArrayFromKeyboard(num3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                ShowArray(array5);
                Console.Write($"В ДАННОМ МАССИВЕ {HowManyLessZero(array5)} ЧИСЕЛ МЕНЬШЕ НУЛЯ.\n" +
                "═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                pause();
                goto restart;
            case 2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями\n" +
                "y = k1 * x + b1, y = k2 * x + b2;\n" +
                "значения b1, k1, b2 и k2 задаются пользователем.\n" +
                "b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Введите значение k1");
                double k1 = GetDouble();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Введите значение k2");
                double k2 = GetDouble();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Введите значение b1");
                double b1 = GetDouble();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Введите значение b2");
                double b2 = GetDouble();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                $"ТОЧКА ПЕРЕСЕЧЕНИЯ ЛИНИЙ [{k1},{b1}] и [{k2},{b2}] ИМЕЕТ СЛЕДУЮЩИЕ КООРДИНАТЫ:\n");
                ShowRealArray(FindPoint(k1, k2, b1, b2));
                Console.Write("═══════════════════════════════════════════════════════════════════════════════════════════\n\n");
                pause();
                goto restart;
            case 3:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить,\n" +
                "является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, значения углов\n" +
                "треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Укажите длину стороны a");
                double a = GetDouble();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Укажите длину стороны b");
                double b = GetDouble();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Укажите длину стороны c");
                double c = GetDouble();
                double[] triangle1 = TriangleCorn(a, b, c);
                string[] triangle2 = Triangle(a, b, c);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                "Углы треугольника равны:\n" +
                $"Угол A = {triangle1[0]}      B = {triangle1[1]}      C = {triangle1[2]}\n" +
                $"ПАРАМЕТРЫ ТРЕУГОЛЬНИКА:\n");
                for (int i = 0; i < triangle2.Length; i++)
                {
                    Console.WriteLine(triangle2[i]);
                }
                Console.Write("═══════════════════════════════════════════════════════════════════════════════════════════\n");
                pause();
                goto restart;
            case 4:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n\n" +
                "(размерность вводим с клавиатуры). Вывести на экран красивенько таблицей. Найти минимальное число и его\n" +
                "индекс, найти максимальное число и его индекс. Вывести эту информацию на экран.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Укажите размерность двумерного массива [m, n]");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Укажите размер [m]...");
                int xm = GetNum();
                Console.WriteLine("Укажите размер [n]...");
                int xn = GetNum();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("В каком диапазоне будут генерироваться числа для заполнения массива?");
                Console.WriteLine("Укажите начало диапазона...");
                int xx = GetNum();
                Console.WriteLine("Укажите конец диапазона...");
                int yy = GetNum();
                int[,] array2d = new int[xm, xn];
                array2d = Fill2dArray(array2d, xx, yy);
                int [] max = Max2dArray(array2d);
                int [] min = Min2dArray(array2d);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                $"Сгенерирован массив целых чисел, размером [{xm}, {xn}]\n\n");
                PrintArray(array2d);
                Console.WriteLine($"Максимальное число массива находится по адресу [{max[1]}, {max[2]}] и равно {max[0]}");
                Console.WriteLine($"Минимальное число массива находится по адресу [{min[1]}, {min[2]}] и равно {min[0]}");
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                pause();
                goto restart;
            case 5:
                ext();
                goto restart;
        }
    }
    else goto restart;
}

// ═════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Запуск обработки меню и выбранного элемента ═══════════════════════════════

try
{
    main();
}

catch
{
    ErrorCatch();
}