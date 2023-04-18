// Задача: Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Console.WriteLine("Заполните массив любыми данными!");
// string size = Convert.ToString(Console.ReadLine());
// string [] array = new string [size];

Console.WriteLine("Заполните массив любыми данными!");
string[] array = Console.ReadLine().Split();
Serch(args);

void Serch(string[] args)
{
    int newSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newSize++;
        }
    }
    string[] litlleArray = new string[newSize];
    int currentIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            litlleArray[currentIndex] = array[i];
            currentIndex++;
        }
    }
    foreach (string item in litlleArray)
        Console.Write($"{item} ");
    Console.WriteLine();
}
