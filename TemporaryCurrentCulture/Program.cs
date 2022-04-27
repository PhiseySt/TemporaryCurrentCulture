using System.Globalization;
using TemporaryCurrentCulture;


Thread.CurrentThread.CurrentCulture = new CultureInfo("en-en");

Console.WriteLine(Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencySymbol); 

using (new TemporaryThreadCulture(new CultureInfo("us-us")))
{
    Console.WriteLine(Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencySymbol);
}

Console.WriteLine(Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencySymbol);
