//Задача: 
//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
// ["1234", "1567", "-2", "com.puter science"] -> ["-2"] 
// ["Russia", "Deomark", "Кazan"] -> []

//Задан массив строк
string[] array_str = { "Я", "учу", "ЯП", "в", "Geek", "-302", "Brains", "hello,", "GB" };

//выведем первоначальный и новый массив строк
Print_Array(array_str);
System.Console.Write(" - > ");
Print_Array(New_array(array_str));

//метод, формирующий новый массив из строк длина которых меньше либо равна 3 символа
string[] New_array(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    //Задаём новый массив с вычисленным количеством строк
    string[] array_new = new string[count];
    int k = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3)
        {
            array_new[k] = arr[j];
            k++;
        }
    }
    return array_new;
}

//метод вывода массива строк на экран
void Print_Array(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            System.Console.Write("[" + array[i] + ", ");
        }
        else if (i == array.Length - 1)
        {
            System.Console.Write(array[i] + "]");
        }
        else
        System.Console.Write(array[i] + ", ");
    }
}   