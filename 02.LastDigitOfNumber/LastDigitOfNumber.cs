using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class LastDigitOfNumber
{

    static string DigitAsWord(int a)
    {
        string word = "";
        switch (a)
        {
            case 1:
                word = "one";
                break;
            case 2:
                word = "two";
                break;
            case 3:
                word = "three";
                break;
            case 4:
                word = "four";
                break;
            case 5:
                word = "five";
                break;
            case 6:
                word = "six";
                break;
            case 7:
                word = "seven";
                break;
            case 8:
                word = "eight";
                break;
            case 9:
                word = "nine";
                break;


        }
        return word;

    }

    private static string GetLastDigitAsWord(string n)
    {
        string word = "";
        List<string> digits = new List<string>();
        foreach (var item in n)
        {
            digits.Add(Convert.ToString(item));
        }
        int LastDigit = int.Parse(digits[digits.Count - 1]);
        word = DigitAsWord(LastDigit);
        return word;

    }



    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(GetLastDigitAsWord(input));

    }



}
