using princSegregacionInterfaz.Interfaces;
using System;

namespace princSegregacionInterfaz.Services
{
    public class SimplePrinterService : IPrinter
    {
        public void Print(Document doc)
        {
            // Método creado para imprimir
            Console.WriteLine($"Imprimiendo> {doc.Name}, descripcion: {doc.Description}");
        }
    }
}
