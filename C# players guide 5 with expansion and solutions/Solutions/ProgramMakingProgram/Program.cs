Console.Write("Enter the C# type you want to use: ");
string type = Console.ReadLine();
Console.Write("Enter the units you want to use: ");
string units = Console.ReadLine();
string program = $$"""
    Console.WriteLine("Enter the width (in {{units}}) of the triangle: ");
    {{type}} width = {{type}}.Parse(Console.ReadLine());
    Console.WriteLine("Enter the height (in {{units}}) of the triangle: ");
    {{type}} height = {{type}}.Parse(Console.ReadLine());
    {{type}} result = width * height / 2;
    Console.WriteLine($"{result} square {{units}}"); 
    """;
Console.WriteLine(program);