// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Метод вывода массива на экран
void ShowArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}” ");
    }
    Console.WriteLine("]");
}

// Задание размера массива
Console.Write("Сколько элементов будете вводить?: ");
int size = Convert.ToInt32(Console.ReadLine());

// Создание массива
string[] array = new string[size];

// цикл на заполнение массива и поиска количества элементов с длиной меньше или равной 3 символов
int newsize = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1} элемент: ");
    array[i] = Console.ReadLine() ?? "";
    if (array[i].Length <= 3) newsize++;
}

// Создание нового массива размером равному количеству элементов с длиной меньше или равной 3 элементов
string[] newArray = new string[newsize];

// Цикл на заполнение нового массива элементами удовлетворяющими условию задачи
int j = 0;
for (int i = 0; i < size; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}

// Вывод результатов на экран
Console.WriteLine("Вы ввели массив:");
ShowArray(array);
Console.WriteLine("Новый массив:");
ShowArray(newArray);