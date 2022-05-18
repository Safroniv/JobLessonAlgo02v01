using System;

namespace JobLessonAlgo02v01Part01
{
    class Program
    {
        static void Main()
        {
            var nodelist = new NodesFunctions();

            NodeFunc (nodelist);


        }
        static void NodeFunc (NodesFunctions nodelist)
        {
            if (nodelist == null)
            {
                throw new ArgumentNullException(nameof(nodelist));
            } 
            
            nodelist.AddNode(10);
            nodelist.AddNode(20);
            nodelist.AddNode(30);
            nodelist.AddNode(40);
            nodelist.AddNode(50);
            nodelist.GetCount();
            

            Console.WriteLine("Вывод на печать массива нод");
            //foreach (var node in nodelist)
            //    Console.WriteLine(node);

        }
         
    }
}