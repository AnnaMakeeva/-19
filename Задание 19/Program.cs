using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    class Computer
    {
        public int Cod { get; set; }
        public string Mark { get; set; }
        public string Tip { get; set; }
        public int Freq { get; set; }
        public int Оpervolume { get; set; }
        public int Diskvolume { get; set; }
        public int Videovolume { get; set; }
        public int Cost { get; set; }
        public int Numbercopies { get; set; }

    }
     static class Program
     {
        static void Main(string[] args)
        {


            List<Computer> listComputer = new List<Computer>()
            {

                new Computer(){Cod=1, Mark="Intel",Tip="7", Freq=3000, Оpervolume=16, Diskvolume=1000, Videovolume=6, Cost=105,  Numbercopies=25},
                new Computer(){Cod=2, Mark="Intel",Tip="5", Freq=2500, Оpervolume=8, Diskvolume=500, Videovolume=4, Cost=95,  Numbercopies=15},
                new Computer(){Cod=3, Mark="AMD",Tip="5", Freq=3000, Оpervolume=16, Diskvolume=750, Videovolume=6, Cost=88,  Numbercopies=38},
                new Computer(){Cod=4, Mark="Intel",Tip="3", Freq=1500, Оpervolume=8, Diskvolume=500, Videovolume=6, Cost=35,  Numbercopies=35},
                new Computer(){Cod=5, Mark="AMD",Tip="5", Freq=2500, Оpervolume=4, Diskvolume=300, Videovolume=2, Cost=20,  Numbercopies=12},
                new Computer(){Cod=6, Mark="Intel",Tip="7", Freq=3000, Оpervolume=16, Diskvolume=500, Videovolume=6, Cost=75,  Numbercopies=20},
                new Computer(){Cod=7, Mark="Intel",Tip="3", Freq=2000, Оpervolume=4, Diskvolume=300, Videovolume=2, Cost=21,  Numbercopies=11},
                new Computer(){Cod=8, Mark="AMD",Tip="7", Freq=2000, Оpervolume=8, Diskvolume=500, Videovolume=6, Cost=60,  Numbercopies=29},

            };

            //определить все компьютеры с указанным процессором. Название процессора запросить у пользователя;
            Console.WriteLine("ВВедите название процессора ");
            string type_ = Console.ReadLine();

            List<Computer> computers = listComputer
               .Where(d => d.Tip == type_)
              .ToList();

            foreach (Computer d in computers)
                Console.WriteLine($"{d.Cod} {d.Mark} {d.Tip} {d.Freq} {d.Оpervolume} {d.Diskvolume} {d.Videovolume}");

            // определить все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
            Console.WriteLine("ВВедите название ОЗУ ");
           int type_1 = Convert.ToInt32(Console.ReadLine());

            IEnumerable<Computer> computers1 = listComputer
             .Where(d => d.Оpervolume <= type_1).ToList();

            foreach (Computer d in computers1)
                Console.WriteLine($"{d.Cod} {d.Mark} {d.Tip} {d.Freq} {d.Оpervolume} {d.Diskvolume} {d.Videovolume}");


            //вывести весь список, отсортированный по увеличению стоимости;
            Console.WriteLine("Cортировка по увеличению стоимости");
            var computers2 = (from d in listComputer
                              orderby d.Cost ascending
                              select d).ToList();
            foreach (var d in computers2)
            {

                Console.WriteLine($"{d.Cost}");

            }

            //- вывести весь список, сгруппированный по типу процессора;
            Console.WriteLine("Список сгруппированный по типу процессора");
            var computers3 = (from d in listComputer
                              orderby d.Mark, d.Tip
                              select d).ToList();
            foreach (var d in computers3)

            {
                
                Console.WriteLine($"{d.Mark} {d.Tip}");

            }

            //-найти самый дорогой и самый бюджетный компьютер;
            Console.WriteLine("Самый дорогой: ");
            var max = listComputer.Max(d => d.Cost);

            Console.WriteLine($"{max}") ;

            Console.WriteLine("Самый бюджетный: ");
            var min = listComputer.Min(d => d.Cost);

            Console.WriteLine($"{min}");

            //есть ли хотя бы один компьютер в количестве не менее 30 штук?
            Console.WriteLine("В наличии не менее 30шт:  ");
            var computers5 = (from d in listComputer
                             where d.Numbercopies > 30
                           select d).ToList();
            foreach (var d in computers5)
            {
                Console.WriteLine($"{d.Cod}");

            }



            Console.ReadKey();


        }

    }
}
