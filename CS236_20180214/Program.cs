using System;

namespace CS236_20180214
{
    class Program
    {
        private static void PrintString(string input)
        {
            Console.WriteLine(input);
            Console.WriteLine(value: input);
        }

        private static int GetSquare(int input)
        {
            return input * input;
        }
        // https://github.com/Agaanii/CPSC236
        class IntValue
        {
            public IntValue(int m1, int m2, int m3)
            {
                member1 = m1;
                member2 = m2;
                Member3 = m3;
            }
            private int member1;
            public int Member1 {
                get {
                    return member1;
                }
                set {
                    member1 = value;
                }
            }

            public int member2;
            public int Member3 { get; set; }
        }

        private static int GetProduct(IntValue inputs)
        {
            return inputs.Member1 * inputs.member2 * inputs.Member3;
        }

        private static void IncrementValue(ref int value)
        {
            value++;
        }

        private static void IncrementValues(IntValue inputs)
        {
            inputs.Member1++;
            inputs.member2++;
            inputs.Member3++;
        }

        class Date
        {
            public Date(int month, int day, int year)
            {

            }

            virtual public void PrintDate()
            {
                Console.WriteLine(month.ToString() + "/" + Day + "/" + Year);
            }

            private int month;
            protected int Month { get { return month; } set {
                    if (value < 1)
                    {
                        month = 1;
                    }
                    else if (value > 12)
                    {
                        month = 12;
                    }
                    else
                    {
                        month = value;
                    }
                } }
            protected int Day { get; set; }
            protected int Year { get; set; }
        }

        class DetailedDate : Date
        {
            public DetailedDate(int hour, int minute, int day, int month, int year)
                : base(day: day, month: month, year: year)
            {
                this.Day = day;
            }

            public override void PrintDate()
            {
                Console.WriteLine(Month.ToString() + "/" + Day + "/" + Year
                    + " " + Hour + ":" + Minute);
            }

            int Hour { get; set; }
            int Minute { get; set; }
        }
        
        static void Main(string[] args)
        {
            int i = 0;
            PrintString("I'm a string");
            PrintString(GetSquare(5).ToString());
            IntValue ints = new IntValue(1,2,3);
            ints.Member1 = 1;
            ints.member2 = 2;
            ints.Member3 = 3;
            PrintString(GetProduct(ints).ToString());
            // IntValue ints2 = new Date(m1: monthIwasBornIn, m2: dayIWasBornIn, m3: 3);
            Date firstDate = new Date(month: 1, day: 12, year: 91);
            DetailedDate secondDate = new DetailedDate(day: 12, month: 1, year: 91, hour: 6, minute: 15);

            Date[] dates = { firstDate, secondDate };
            
            firstDate.PrintDate();
            secondDate.PrintDate();
            // PrintString(GetProduct(ints2).ToString());

            //int i = 0;
            PrintString(i.ToString());
            IncrementValue(ref i);
            PrintString(i.ToString());

            //IncrementValues(ints2);
            //PrintString(GetProduct(ints2).ToString());

            Console.ReadLine();
        }
    }
}
