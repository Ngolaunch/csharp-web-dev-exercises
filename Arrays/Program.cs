//Exercises: Control Flow & Collections

//TODO: Write your code for Array Practice below:

int[] arrayPractice = { 1, 1, 2, 3, 5, 8 } ;

//Console.WriteLine(arrayPractice);

//foreach (int i in arrayPractice)
//{
//    Console.WriteLine(arrayPractice[i]);
//}

// ***you can only run one foreach at a time****


foreach (int num in arrayPractice)
{
    if (num % 2 > 0)
    {
        Console.WriteLine(num);
    }
}