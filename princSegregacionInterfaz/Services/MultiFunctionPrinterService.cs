using princSegregacionInterfaz.Interfaces;
using System;

namespace princSegregacionInterfaz.Services
{
    public class MultiFunctionPrinterService : IPrinter, IScanner
    {
        public void Print(Document doc)
        {
            // Método creado para imprimir
            Console.WriteLine($"Imprimiendo> {doc.Name}, descripcion: {doc.Description}");
        }

        public void Scan(Document doc)
        {
            // Método creado para escanear
            Console.WriteLine($"Escaneando> {doc.Name}, descripcion: {doc.Description}");
        }
    }
}
