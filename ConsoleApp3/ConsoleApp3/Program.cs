using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone mobile = new Phone();
            while ( mobile.balance>=7)
            { 
                Console.WriteLine("please make ur call in seconds:");
                var second = int.Parse(Console.ReadLine());
                mobile.MakeCall(second);
                if (mobile.balance < 0)
                {
                    Console.WriteLine("you cant make a call,cuz u dont have enough money.");

                }
                else
                {
                    Console.WriteLine("balans:" + mobile.getBalance() + "gepik");
                }
                //int b = (int)deqiqeler.bir;
                //Console.WriteLine((int)deqiqeler.bir);
            }
          
            Console.ReadLine();
        }
      public  enum deqiqeler
        {
            bir=60,
            iki=120,
            uc=180,
            dord=240,
            bew=300,
            alti=360,
            yeddi=420,
            sekkiz=480,
            doqquz=540,
        }
        class Phone
        {
            public double balance = 500;
            public string make;
            public string model;
            public int memory;
            public int cpu;
            public display display;

            public void MakeCall(int s)

            {
                switch (s)
                {
                    case (int)deqiqeler.bir:
                        balance -= (s / 60) * 7;
                        break;
                    case (int)deqiqeler.iki:
                        balance -= (s / 60) * 7;
                        break;
                    case (int)deqiqeler.uc:
                        balance -= (s / 60) * 7;
                        break;
                    case (int)deqiqeler.dord:
                        balance -= (s / 60) * 7;
                        break;
                    case (int)deqiqeler.bew:
                        balance -= (s / 60) * 7;
                        break;
                    case (int)deqiqeler.alti:
                        balance -= (s / 60) * 7;
                        break;
                    case (int)deqiqeler.yeddi:
                        balance -= (s / 60) * 7;
                        break;
                    case (int)deqiqeler.sekkiz:
                        balance -= (s / 60) * 7;
                        break;
                    case (int)deqiqeler.doqquz:
                        balance -= (s / 60) * 7;
                        break;
                    default:
                        balance = (balance - (0.116 * s));
                        break;

                }
  }
            public double getBalance()
            {
                return balance;
            }

        }
        class display
        {
            public int type;
            public double diagonal;
        }
    }
}
