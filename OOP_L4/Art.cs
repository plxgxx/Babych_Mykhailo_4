using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L4
{
    internal class Art
    {
        List<string> arts = new List<string>() { "Успадкування це один з принципів об'єктно-орієнтовного програмування,який дає класу можливість використовувати код іншого класу, доповнюючи його своїми власними деталями.", "Ранок почався спокійно.", "4308" };

        public void Print()
        {
            foreach (var art in arts)
            {
                Console.WriteLine($"Текст {Convert.ToInt32(arts.IndexOf(art) + 1)} - {art}");
                Console.WriteLine();
            }
        }
        public void TextsCount()
        {
            arts.Count();
            Console.WriteLine($"Кількість текстів: {arts.Count()}");
        }

    }
}
