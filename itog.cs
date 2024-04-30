using static System.Console;

WriteLine("Введите данные через пробел, затем нажмите Enter: ");
string? input = ReadLine();
string[] all = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
Write("[");
foreach (string part in all)
{
    Write('"');
    Write(part);
    Write('"');
    Write(", ");
}
Write("] → [");
foreach (string part in all)
{
    if (part.Length <= 3)
        {
            Write('"');
            Write(part);
            Write('"');
            Write(", ");
        }
}
Write(']');