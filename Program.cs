string [] array (int n)  // создаем пустой массив и заполняем его
{
    string [] array  = new string[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

Console.WriteLine("Введите элементы массива по порядку: ");
string [] firstarray = array(5);

string [] resultarray(string [] array) // создаем новый массив с элементами первого массива
{
    string [] resultarray = new string [new Random().Next(1,4)]; // задаем рандомный размер <= 3
    for (int i = 0; i < resultarray.Length; i++)
    {
        resultarray[i] = array[i];
    }
    return resultarray;
}

Console.WriteLine("Итоговый массив: " + string.Join(", ",resultarray(firstarray))); // вывод итогового массива

