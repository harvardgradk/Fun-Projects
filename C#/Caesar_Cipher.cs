// Caesar Ciphers

using System;

class CaesarCiphers
{
    public delegate void CaesarShift(string PlainText);

    static void Main()
    {

        CaesarShift one = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 1;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift two = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 2;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift three = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 3;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift four = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 4;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift five = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 5;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift six = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 6;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift seven = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 7;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift eight = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 8;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift nine = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 9;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift ten = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 10;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift eleven = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 11;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift twelve = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 12;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift thirteen = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 13;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift fourteen = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 14;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift fifteen = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 15;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift sixteen = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 16;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift seventeen = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 17;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift eighteen = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 18;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift nineteen = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 19;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift twenty = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 20;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift twentyone = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 21;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift twentytwo = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 22;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift twentythree = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 23;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift twentyfour = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 24;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift twentyfive = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 25;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        CaesarShift twentysix = delegate (string PlainText)
        {
            string EncryptedText = "";

            for (int i = 0; i < PlainText.Length; i++)
            {
                int EncryptChar = PlainText[i];
                EncryptChar = EncryptChar + 26;
                EncryptedText = EncryptedText + ((char)EncryptChar);
            }

            Console.WriteLine();
            Console.WriteLine($"Encrypted Text is: {EncryptedText}");
            Console.WriteLine();
        };

        Console.WriteLine();
        Console.WriteLine("1. Caesar Shift By 1");
        Console.WriteLine("2. Caesar Shift By 2");
        Console.WriteLine("3. Caesar Shift By 3");
        Console.WriteLine("4. Caesar Shift By 4");
        Console.WriteLine("5. Caesar Shift By 5");
        Console.WriteLine("6. Caesar Shift By 6");
        Console.WriteLine("7. Caesar Shift By 7");
        Console.WriteLine("8. Caesar Shift By 8");
        Console.WriteLine("9. Caesar Shift By 9");
        Console.WriteLine("10. Caesar Shift By 10");
        Console.WriteLine("11. Caesar Shift By 11");
        Console.WriteLine("12. Caesar Shift By 12");
        Console.WriteLine("13. Caesar Shift By 13");
        Console.WriteLine("14. Caesar Shift By 14");
        Console.WriteLine("15. Caesar Shift By 15");
        Console.WriteLine("16. Caesar Shift By 16");
        Console.WriteLine("17. Caesar Shift By 17");
        Console.WriteLine("18. Caesar Shift By 18");
        Console.WriteLine("19. Caesar Shift By 19");
        Console.WriteLine("20. Caesar Shift By 20");
        Console.WriteLine("21. Caesar Shift By 21");
        Console.WriteLine("22. Caesar Shift By 22");
        Console.WriteLine("23. Caesar Shift By 23");
        Console.WriteLine("24. Caesar Shift By 24");
        Console.WriteLine("25. Caesar Shift By 25");
        Console.WriteLine("26. Caesar Shift By 26");
        Console.WriteLine();

        Console.Write("Enter a Choice: ");
        if (!int.TryParse(Console.ReadLine(), out int choice))
        {
            Console.WriteLine();
            Console.WriteLine("Please Only Enter Numbers!");
            Console.WriteLine();
            return;
        }

        Console.WriteLine();
        Console.Write("Enter a Text to Encrypt it using Caesar Cipher: ");
        string PlainText = Console.ReadLine();

        if (string.IsNullOrEmpty(PlainText))
        {
            Console.WriteLine();
            Console.WriteLine("Please Enter Some Text To Encrypt It!");
            Console.WriteLine();
            return;
        }

        switch (choice)
            {
                case 1:
                    one(PlainText);
                    break;
                case 2:
                    two(PlainText);
                    break;
                case 3:
                    three(PlainText);
                    break;
                case 4:
                    four(PlainText);
                    break;
                case 5:
                    five(PlainText);
                    break;
                case 6:
                    six(PlainText);
                    break;
                case 7:
                    seven(PlainText);
                    break;
                case 8:
                    eight(PlainText);
                    break;
                case 9:
                    nine(PlainText);
                    break;
                case 10:
                    ten(PlainText);
                    break;
                case 11:
                    eleven(PlainText);
                    break;
                case 12:
                    twelve(PlainText);
                    break;
                case 13:
                    thirteen(PlainText);
                    break;
                case 14:
                    fourteen(PlainText);
                    break;
                case 15:
                    fifteen(PlainText);
                    break;
                case 16:
                    sixteen(PlainText);
                    break;
                case 17:
                    seventeen(PlainText);
                    break;
                case 18:
                    eighteen(PlainText);
                    break;
                case 19:
                    nineteen(PlainText);
                    break;
                case 20:
                    twenty(PlainText);
                    break;
                case 21:
                    twentyone(PlainText);
                    break;
                case 22:
                    twentytwo(PlainText);
                    break;
                case 23:
                    twentythree(PlainText);
                    break;
                case 24:
                    twentyfour(PlainText);
                    break;
                case 25:
                    twentyfive(PlainText);
                    break;
                case 26:
                    twentysix(PlainText);
                    break;
            }
    }
}