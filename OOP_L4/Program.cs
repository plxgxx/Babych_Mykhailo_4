using System;

namespace OOP_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaperBook book = new PaperBook
            { _text = "Успадкування це один з принципів об'єктно-орієнтовного програмування,який дає класу можливість використовувати код іншого класу, доповнюючи його своїми власними деталями.",
                _fontName = "Times new Roman",
                _fontSize = 18,
                _textColor = "Yellow"

            };
            book.PageCount();
            book.ShowInfo();
            book.SymbolCount();
            Console.WriteLine();
            Console.WriteLine();
            ElectrinicBook electrinicBook = new ElectrinicBook
            {
                _text = "Ранок почався спокійно.",
                _fontName = "FranklinGothicBook",
                _fontSize = 12

            };
            electrinicBook.PageCount();
            electrinicBook.ShowInfo();
            electrinicBook.SymbolCount();

            Console.WriteLine();
            Console.WriteLine();

            Graffiti graffiti = new Graffiti
            {
                _text = "4308",
                _fontName = "Arial",
                _fontSize = 56
            };
            graffiti.PageCount();
            graffiti.ShowInfo();
            graffiti.SymbolCount();

            Art art = new Art();
            art.Print();
            art.TextsCount();



        }
    }
}
