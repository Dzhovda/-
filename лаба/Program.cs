using System.Drawing;
using лаба;

namespace лаба
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Class1 class1 = new Class1(Convert.ToInt32(Console.ReadLine()));
            Class2 class2 = new Class2();
            Class3 class3 = new Class3(class1.x);
            Class2 class4 = (Class2)class2.Clone();
            Console.WriteLine("Первый объект - " + class1.x);
            Console.WriteLine("Второй объект - " + class2.x);
            Console.WriteLine("Третий объект, копирующий первый объект - " + class3.x);
            Console.WriteLine("Четвертый объект(клон второго) - " + class4.x);
        }
       

    
        /*static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                numbers.Add(i);
            }
            numbers.Remove(1);
            numbers.Remove(3);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }*/
    }
}
