using System;

namespace JobLessonAlgo02v01Part01
{
    class Program
    {
        static void Main()
        {
            var nodelist = new NodesFunctions(2);
            nodelist.AddNode(50);
            nodelist.AddNode(7328);
            nodelist.AddNode(33);
            nodelist.AddNodeAfter(nodelist.FirstNode, 951);

            Console.Write("Количество элементов:"+nodelist.GetCount()+"\n");

            nodelist.GetValueNodes();
            nodelist.RemoveNode(nodelist.FirstNode.NextNode);
            Console.Write("Поиск ноды. Вывод значения найденной ноды - ");
            nodelist.FindNode(7328); 
            nodelist.RemoveNode(1);
            nodelist.GetValueNodes();
            Console.ReadLine();

        }

         
    }
}