/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
Console.WriteLine("Вы хотите задать массив из строк сами с клавиатуры (вариант 1) или получить случайный массив (вариант 2)?");
Console.Write("Введите 1 или 2: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a<3 && a>0)             // проверка на правильность выбора
{
    Console.Write("Укажите сколько будет элементов в массиве (размерность): ");
    int len = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[len];
    if (a == 1)                // вызов методов заполнения массива, в зависимости от выбора пользователя
    {
        FillArray(array);
    }
    else
    {
        FillArrayRandom(array);
    }
    Console.WriteLine("Исходный массив сформирован:");
    PtintArray(array);          
}
else
{
    Console.WriteLine("Такого варианта ввода массива - нет.");
}
//ArrayStringLength4(array);
PtintArray(array);

void FillArray(string[] array)              // создание массива строк пользователем
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите строку ({i+1} элемент массива):");
        array[i] = Console.ReadLine();
    }
}

void FillArrayRandom(string[] array)        // создание массива строк, случайным образом
{
    int sim;
    char simvol;
    Random ran = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        string str = "";
        int size = ran.Next(1, 10);
        for (int j = 0; j < size; j++)
        {
            sim = ran.Next(0, 26); 
            simvol = Convert.ToChar(sim + 65);      // добавляем к случайному числу 65 и получаем идентификатор символа в Юникоде
            str = str + simvol;
        }
        array[i] = str;
    }
}
    
void PtintArray(string[] array)                     // вывод массива
{
    for (int i = 0; i < array.Length; i++)  
    {
        Console.Write(array[i] + ", ");
    }
}