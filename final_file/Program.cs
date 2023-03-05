// Программа, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3.

string [] array = {"smart" , "123" , "-2" , "clever"};
string [] secondArray = {};
int count = 0 ;

void ArrayMagic(string[] array, string[] secondArray)
{
    for(int i = 0 ; i<array.Length ; i++)
    {
        if (array[i].Length <= 3 )
        {
            secondArray[count] = array[i];
            
            Console.Write (secondArray[count]);
            count++;
        }
    }
}
ArrayMagic(array, secondArray);