using System;

namespace JobLessonAlgo02v01Part01
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    }
    public class Node
    {
        /// <summary>
        /// Значение ноды
        /// </summary>
        public int Value { get; set; }
        /// <summary>
        /// Следующая нода
        /// </summary>
        public Node NextNode { get; set; }
        /// <summary>
        /// Предыдущая нода
        /// </summary>
        public Node PrevNode { get; set; }
    } //Начальную и конечную ноду нужно хранить в самой реализации интерфейса
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value); // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента

        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }
}


