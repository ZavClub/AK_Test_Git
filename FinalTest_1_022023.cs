Console.Write("Введите размер массива: ");		// Ввод данных с консоли
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];		// Создание массива под данные

for (int i = 0; i < size; i++)
{
    Console.Write("Введите данные в массив: ");
    string? username = Console.ReadLine();
    array[i] = username.ToString();
}
