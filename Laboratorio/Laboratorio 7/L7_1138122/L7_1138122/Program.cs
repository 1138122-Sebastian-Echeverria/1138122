// Sebastian Echeverria 1138122
Console.WriteLine("Hola pa!");
Console.WriteLine("");
Console.ReadKey();

Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Te llamas: " + nombre);
Console.WriteLine("");

Console.ReadKey();

Console.WriteLine("Ingrese el numero a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Ingrese el numero b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Ingrese el numero c: ");
int c = int.Parse(Console.ReadLine());

Console.ReadKey();
Console.Clear();

int resultado = a + b + c;
Console.WriteLine("a+b+c = " + resultado);

resultado = a * (b + c);
Console.WriteLine("a * (b + c) = " + resultado);


decimal resultado2 = a/(b*c);
Console.WriteLine("a / b*c = " + resultado2);

double resultado1 = (3*a + 2*b)/(Math.Pow(c,2));
Console.WriteLine("3a + 2b / c^2 = " + resultado1);