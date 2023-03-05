// Программа, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3.

string [] array = {"smart" , "123" , "-2" , "clever"};
string [] secondArray = new string [array.Length];
int count = 0 ;

void ArrayMagic(string[] array, string[] secondArray)
{
    for(int i = 0 ; i<array.Length ; i++)
    {
        if (array[i].Length <= 3 )
        {
            secondArray[count] = array[i];
            
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ArrayMagic(array, secondArray);
PrintArray(secondArray);