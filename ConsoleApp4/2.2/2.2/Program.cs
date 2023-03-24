using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{

    internal class Program
    {
        class TaskSolution
        {
            private int n = 0;
            public bool setNumber(int num)
            {
                if (n + 1 == num)
                {
                    this.n = num;
                    return true;
                }
                else
                {
                    this.n = 0;
                    return false;
                }
            }
            public void returnExpectedResult()
            {
                Console.WriteLine(n + 1);
            }
        }
        static void Main(string[] args)
        {
            TaskSolution shved = new TaskSolution();
            int n = 0;
            while (true)
            {
                Console.Write("Введите число:");
                shved.returnExpectedResult();
                Console.WriteLine(shved.setNumber(int.Parse(Console.ReadLine())));
            }
        }
    }
}
