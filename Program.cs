// using System;

// using System.Text.RegularExpressions;

// ColorSelector();
// static void ColorSelector()
// {
//     Console.WriteLine("=====Welcome to the ColorSelectionApp====");
//     Console.WriteLine("Input name of the color :");
//     string colorName = Console.ReadLine()!.ToLower();


//     switch (colorName)
//     {
//         case "white":
//             ColorOutput(colorName);
//             break;
//         case "black":
//             ColorOutput(colorName, ConsoleColor.Black);
//             break;
//         case "green":
//             ColorOutput(colorName, ConsoleColor.Green);
//             break;
//         case "blue":
//             ColorOutput(colorName, ConsoleColor.Blue);
//             break;
//         case "red":
//             ColorOutput(colorName, ConsoleColor.Red);
//             break;
//         default:
//             Console.WriteLine("Invalid Color. Please enter a valid color.");
//             break;
//     }
// }

// static void ColorOutput(string colorName, ConsoleColor consoleColor = ConsoleColor.White)
// {
//     string message = $"You have selected color {colorName.ToUpper()}.";

//     if (colorName != "white")
//     {
//         Console.BackgroundColor = ConsoleColor.White;
//         Console.ForegroundColor = consoleColor;
//         Console.WriteLine(message);
//         Console.ResetColor();
//     }
//     else
//     {
//         Console.WriteLine(message);
//     }


//}

Console.WriteLine("Input text of your choice: ");
string text = Console.ReadLine()!;
Console.Clear();

string result = ManipulateString(text);
Console.WriteLine("{0}\n{1}\n{2}\n{3}",text,text.Length,result,result.Length);

  
 string ManipulateString(string str)
 {
    string[] splitedStrs = str.Trim().Split(' ',StringSplitOptions.RemoveEmptyEntries);
    string[] manipulatedStrs = new string[splitedStrs.Length];
    int counter = 0;
    foreach(string splitedStr in  splitedStrs)
    {
        if(splitedStr.Length >= 5)
        {
            string reversedWord = ReverseString(splitedStr);
            manipulatedStrs[counter++] = reversedWord;
        }
                else
                {
                    manipulatedStrs[counter++] = splitedStr;
                    
                }
            }
            return string.Join(' ',manipulatedStrs);
        }
    
 
string ReverseString(string str)
{
    int i, j = 0;
    char[] reversed = new char[str.Length];

    for (i = str.Length -1; i >= 0; i--)
    {
        reversed[j++] = str[i];
    }
    return new string(reversed);
}
//The line reversed[j++] = str[i]; efficiently copies each character from the original string str into the reversed array in reverse order, while //simultaneously incrementing the index j for the next character in the reversed array.