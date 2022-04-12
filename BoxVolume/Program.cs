Console.WriteLine("Enter a height:");
string heightString = Console.ReadLine();

Console.WriteLine("Enter a width:");
string widthString = Console.ReadLine();

Console.WriteLine("Enter a depth:");
string depthString = Console.ReadLine();

double height = double.Parse(heightString);
double width = double.Parse(widthString);
double depth = double.Parse(depthString);

double volume = height * width * depth;

Console.WriteLine($"The volume of your box is {volume}");
//Console.WriteLine("The volume of your box is " + volume.ToString());
//Console.Write("The volume of your box is ");
//Console.WriteLine(volume);
//Console.WriteLine("Volume:");
//Console.WriteLine(volume);