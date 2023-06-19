// // Type 1

// // void Method1()
// // {
// //     Console.WriteLine("Author Artyom Melnikov");
// // }
// // Method1();

// // Type 2

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg:"Text of message");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// // Method21("Text", 4);


// // Type 3

// // int Method3()
// // {
// //     return DateTime.Now.Year;
// // }

// // int year = Method3();
// // Console.WriteLine(year);

// // Type 4

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "WU-Tang ");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "WU-Tang ");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} X {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// Задача. 
// Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить
// большими "К", а большие "С" заменить малельники "с"

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
// + "ежели бы вас послали вместо нашего милого Винценгероде"
// + "вы бы взяли приступлм согласие прусского короля. "
// + "Вы так кросноречивы. Вы дадите мне чаю?";

// // string s = "qwerty"
// //             012
// // s[3]  // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int Length = text.Length;
//     for (int i = 0; i < Length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// String newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// Console.WriteLine(newText);


int[] arr = {1, 2, 3, 4, 5, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; i++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);