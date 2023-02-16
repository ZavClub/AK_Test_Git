Console.Write("Введите размер массива: ");		// Ввод данных с консоли
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];		// Создание массива под данные

for (int i = 0; i < size; i++)
{
    Console.Write("Введите данные в массив: ");
    string? username = Console.ReadLine();
    array[i] = username.ToString();
}

int tmp = 0;

//  Блок поиска 3-х или нменее символов в введённых массивах и их вывод в консоль
void FindLiterals()
{

    for (int index = 0; index < size; index++)
    {
        if (index == 0) Console.Write("[");

        int num = 0;

        foreach (char c in array[index]) num++;

        if (num > 0 && num <= 3)
        {
            tmp++;
            if (tmp > 1 && (num > 0 && num <= 3)) Console.Write(",");
            Console.Write($"'{array[index]}'");
        }
        if (index == size - 1) Console.Write("]");
    }
}

FindLiterals();