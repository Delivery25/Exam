using Exam.Database;
using System.IO;
using System.Linq;

namespace Exam
{
    internal class Import
    {
        //private void ImportMethod()
        //{
        //    var file = File.ReadAllLines(@"C:\Заказы_import.txt");
        //    using (var context = new ParkEntities())
        //    {
        //        foreach (var line in file)
        //        {
        //            var cells = line.Split('\t').Where(x => x != "").ToArray();
        //            var order = context.Order.Find(int.Parse(cells[0]));

        //            for (var i = 1; i < cells.Length; i++)
        //            {
        //                var service = context.Service.Find(int.Parse(cells[i]));
        //                order.Service.Add(service);
        //            }
        //            context.SaveChanges();
        //        }
        //    }
        //}

        //private void ImportMethod2()
        //{
        //    var file = File.ReadAllLines(@"C:\Users\Diana\College\Демо\Попрыжёнок\Задание\Сессия 1\1.txt");
        //    var image = Directory.GetFiles(@"C:\Users\Diana\College\Демо\Попрыжёнок\Задание\Сессия 1\agents_import\agents");
        //    using (var context = new JumperEntities())
        //    {
        //        foreach (var line in file)
        //        {
        //            var m = line.Split('\t');
        //            var agent = new Agent
        //            {
        //                Title = m[0],
        //                AgentTypeID = int.Parse(m[1]),
        //                Address = m[2],
        //                INN = m[3],
        //                KPP = m[4],
        //                DirectorName = m[5],
        //                Phone = m[6],
        //                Email = m[7],
        //                Logo = File.ReadAllBytes(image.First(x => x.Contains(m[8]))),
        //                Priority = int.Parse(m[9]),
        //            };

        //            context.Agent.Add(agent);
        //        }

        //        context.SaveChanges();
        //    }
        //}

    }
}
