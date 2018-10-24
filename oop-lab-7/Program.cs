using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace oop_lab_6
{
    class Program
    {
        static void Main(string[] args)
        {

        //Technique headphones = new Headphones("Наушники", "РБ", 44444, "2 года", ConsoleColor.Blue);
        // Technique headphones1 = new Headphones("Наушники", "РБ", 444, "2 года", ConsoleColor.Blue);

        int price = 23545;
            Debug.Assert(price > 30000, "Слишком низкая цена");

            Technique tecniqueExample1 = new Technique("Товар", "РБ", 23333, "2 year");
            Console.WriteLine(tecniqueExample1.Price);
            //Goods PhoneExample = new Smartphone("Sony", "China", 54_555, "2 year", 80_29_89_47_333, true);
            Console.ReadKey();
            #region Lab 6
            //    computerLab Obj = new computerLab();

            //    Obj.Add(headphones);
            //    Obj.Add(headphones1);
            //    Obj.Add(tecniqueExample);
            //    Obj.Add(headphones);
            //    Obj.Add(PhoneExample);

            //    Console.Write("Массив:");
            //    Obj.Print();

            //    classController controller = new classController(Obj);

            //    controller.TotalCost();
            //    controller.SortAndPrint();
            //    controller.Search_to_write_off();

            //    Console.ReadKey();
            //    Obj.Delete(allElements: headphones1);
            //    Obj.Print();

            //    Obj.Delete(numberOfElement: 1);
            //    Obj.Print();

            //    Obj.Delete(allElements: headphones);
            //    Obj.Print();
            //}
            #endregion

            try
            {
                tecniqueExample1.Manufacturer = "new";
            }
            catch(GoodsException ex)
            {
                ex.GetInformation();
            }



            try
            {
                Technique tecniqueExample2 = new Technique(null, "РБ", 23333, "2 year");
            }
            catch (NullTechniqueException ex)
            {
                ex.GetInformation();
            }

            try
            {
                tecniqueExample1.Installment();
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Ошибка: " + fe.Message);
            }
            catch(DivideByZeroException dze)
            {
                Console.WriteLine("Ошибка: " + dze.Message);
            }
            //повторение предъидущего блока для инициализации другой ошибки
            try
            {
                tecniqueExample1.Installment();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка: " + fe.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление но ноль");
            }

            Goods[] goodsArray = new Goods[4];

            try
            {
                goodsArray[5] = tecniqueExample1;
            }
            catch
            {
                Console.WriteLine("Ошибка: не верный индекс");
            }

            StreamReader reader = null;
            try
            {
                reader = File.OpenText("file.txt");
                if (reader.EndOfStream) return;
                Console.WriteLine(reader.ReadToEnd());
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            finally
            {
                if (reader != null) reader.Dispose();
            }

            StringBuilder sb = new StringBuilder(15, 15);
            sb.Append("Substring #1 ");
            try
            {
                sb.Insert(0, "Substring #2 ", 2);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Ошибка:"+e.Message);
            }


        }
    }
}
