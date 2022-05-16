// See https://aka.ms/new-console-template for more information
LineComparison.LineClass line = new LineComparison.LineClass();
double len1 = line.calculateLength(4, 2, 6, 4);
double len2 = line.calculateLength(4, 1, 5, 3);
Console.WriteLine("Length of first line is " + len1);
Console.WriteLine("Length of second line is " + len2);
line.checkEquality(len1, len2);
line.compareLines(len1, len2);
