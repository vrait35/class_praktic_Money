using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money=new Money();
            bool isCorrectInsert = false;
            int buf = 0;
            string strbuf;

            while (!isCorrectInsert)
            {
                Console.Write("Введите номинал купюры: ");
                isCorrectInsert = Money.TryParceStrInt(Console.ReadLine(),ref buf);
            }

            money.SetNoteFaceValue(buf);
            isCorrectInsert = false;

            while (!isCorrectInsert)
            {
                Console.Write("Введите количество купюр: ");
                isCorrectInsert = Money.TryParceStrInt(Console.ReadLine(),ref buf);
            }
            isCorrectInsert = false;

            money.SetCount(buf);

            Console.WriteLine("У вас в кошельке "+money.GetSum()+" тенге ");

            int productSum=0;
            int productCount=0;

            while (!isCorrectInsert)
            {
                Console.Write("Введите  стоимость товара: ");
                isCorrectInsert = Money.TryParceStrInt(Console.ReadLine(), ref productSum);
            }
            isCorrectInsert = false;

            while (!isCorrectInsert)
            {
                Console.Write("Введите  количество товара: ");
                isCorrectInsert = Money.TryParceStrInt(Console.ReadLine(), ref productCount);
            }
            isCorrectInsert = false;


            if (!money.IsEnought(productCount * productSum))
            {
                Console.WriteLine("у вас нехватает денег");
            }
            else Console.WriteLine("хватает денег");

            Console.WriteLine("у вас хватит денег на" +money.GetCountProduct(productSum) + " товаров");
        }
    }
}
