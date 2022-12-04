# Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 

## Примеры:

>["hello", "2", "world", ":-)"] -> ["2", ":-)"] 

>["1234", "1567", "-2", "com.puter science"] -> ["-2"] 

>["Russia", "Deomark", "Кazan"] -> []

## Решение задачи
Выделено два метода: 

1. Первый метод - он же основной - string[] New_array(string[] arr)
> метод получет на вход в качестве аргумента массив строк *arr*. Результатом работы метода является также массив строк *array_new*, но уже отсортированный по условию, что каждая строка должна содержать не менее трёх символов. Для возможности создания нового массива после сортировки, требуется знать количество строк с числом символов не менее трёх. Для этого в цикле *for* проходим по всем строкам массива *arr*, и при помощи счётчика *count* находим число элементов массива. Далее создаём новый массив строк *array_new[count]*. И ещё раз пройдя циклом *for* по всем элементам массива *arr*, записываем все строки, которые меньше или равны трём в массив *array_new[count]*
2. Второй метод - void Print_Array(string[] array)
>метод выводит строки в консоль. Получает на вход в качестве аргумента массив строк *array*. В цикле *for* проходим по всем строкам массива *array* и при помощи команды *System.Console.Write* выводим поочередно элементы массива в консоль. Дополнительно, для первого и последнего элемента массива реализована проверка для добавления скобок *[]* в начало и в конец выводимого сообщения