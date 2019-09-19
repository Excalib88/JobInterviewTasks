using System;

namespace ClockArrowsAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = Convert.ToInt32(Console.ReadLine());
            var minute = Convert.ToInt32(Console.ReadLine());

            var clockArrows = new ClockArrows();

            Console.WriteLine(clockArrows.CalculateAngle(hours, minute));

            Console.ReadKey();
        }
    }
}
