Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

Console.WriteLine("c:\\source\\repos");
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // Unicode

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");
// Nihon no seikyū-sho o seisei suru ni wa
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

String greeting = "Hello";
String firstName = "Bob";
// string message = greeting + " " + firstName + "!";
string message = $"{greeting} {firstName}!";

// $ and @
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");


/*
#Exercise

The projectName variable will be used twice in the desired output.

The russianMessage variable contains the message "View Russian output" in Russian.
You must use this variable in your code that prints the message.

You may not change these two lines of code, but you can add code above and below each line.
You must use these two lines of code to form the desired output.

You may only use either the Console.WriteLine() or the Console.Write() method twice.
You can only create two instructions that actually print output to the console.

Use character escape sequences, verbatim strings, unicode, and string interpolation to generate the output.
To complete this challenge, your code must produce the following output.

Output

View English output:
  c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
  c:\Exercise\ACME\ru-RU\data.txt

*/
projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
    c:\Exercise\{projectName}\data.txt
");

Console.Write($@"{russianMessage}
    c:\Exercise\{projectName}\ru-RU\data.txt");