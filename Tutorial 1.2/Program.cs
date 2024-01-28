Console.WriteLine('b');

Console.WriteLine(123);
Console.WriteLine(0.250F);      // Float. F is case insensitive
Console.WriteLine(2.6250);      // Double

Console.WriteLine(12.398160m);  // Decimal (the most precise). M is case insensitive.
                                // The zero at the end of the decimal is written.
Console.WriteLine(true);
Console.WriteLine(false);

// The var keyword tells the C# compiler that the data type is implied by the assigned value.
// The var keyword is used to save on keystrokes when types are lengthy
// or when the type is obvious from the context.
var x = "Hello world!";   // x became a string
Console.WriteLine(x);

/*
#Exercise

Store the following values in variables:
Bob
3
34

These variables should be given names that reflect their purpose.

Make sure you select the correct data type for each of the variables
based on the type of data it will hold.

Finally, you'll combine the variables with literal strings
passed into a series of Console.Write() commands to form a complete message.

Write code in the .NET Editor to display the following message:
Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
*/
String name = "Bob";
int messages= 3;
decimal temperature = 34;
Console.WriteLine(
    "Hello, " + name + "! You have " + messages + " in your inbox. The temperature is " + 
    (temperature+0.4m) + " celsius.");