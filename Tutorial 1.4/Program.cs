int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// Fahrenheit to Celsius
// (F - 32) * 5 / 9 = C
int fahrenheit = 94;
float celsius = (float)(fahrenheit - 32) * 5 / 9;

Console.WriteLine("The temprature is " + celsius + " Celsius.");

Console.WriteLine("Windows " + 1 + 1);  // Outputs Windows 11, not Windows 2