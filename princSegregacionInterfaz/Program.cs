using princSegregacionInterfaz.Services;
using System;

namespace princSegregacionInterfaz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Document doc = new Document("Tarea Programacion II", "Esta es la tarea del principio de Segregacion de interfaz.");

            SimplePrinterService simplePrinter = new SimplePrinterService();
            simplePrinter.Print(doc);

            MultiFunctionPrinterService multiFunctionPrinter = new MultiFunctionPrinterService();
            multiFunctionPrinter.Print(doc);
            multiFunctionPrinter.Scan(doc);
        }
    }
}
