// See https://aka.ms/new-console-template for more information
using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

bool ok = false;
double x, y;
do
{
    Console.Write("Enter the first number: ");
    ok = double.TryParse(Console.ReadLine(), out x);
    if (!ok) Console.WriteLine("Please enter a number!");
} while (!ok);
do
{
    Console.Write("Enter the second number: ");
    ok = double.TryParse(Console.ReadLine(), out y);
    if (!ok) Console.WriteLine("Please enter a number!");
} while (!ok);
Console.WriteLine($"Sum: {x + y}");
