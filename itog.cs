using static System.Console;
WriteLine("Введите данные через пробел, затем нажмите Enter: ");

string? input = ReadLine();
string[] all = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

foreach (var item in all)
{
    Write(item);
}

foreach (var item in all)
{
    if (item.Length <= 3)
        {
            Write(item);
        }
}
