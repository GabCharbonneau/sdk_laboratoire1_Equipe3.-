using SDK_Laboratoire1_Equipe3;


    
    string choix = "ab";
    ConversionAlphabetiqueToNote C1 = new ConversionAlphabetiqueToNote();

    while (choix != "note")
    {
        Console.Write("Conversion a faire: ");
        choix = Console.ReadLine();
    }

    while (true)
    {
        Console.Write("Convertisseur de note: ");
        ConsoleKeyInfo keyPress = Console.ReadKey(intercept: true);
        Console.WriteLine(C1.TransformationNote(keyPress.KeyChar.ToString().ToUpper()));
    }




