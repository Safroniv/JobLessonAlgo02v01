using System;

namespace JobLessonAlgo02v01Part01
{
    class Program
    {
        static void Main()
        {
        }
    }
    public class NodesFunctions : ILinkedList
    {
        private readonly Node next = new Node();
        private readonly Node prev = new Node();

        public NodesFunctions()
        {
            next.NextNode = prev;
            prev.NextNode = next;
        }
        /// <summary>
        /// Добавление ноды в конец
        /// </summary>
        /// <param name="value">значение ноды</param>
        public void AddNode(int value)
        {
            prev.PrevNode = new Node()
            {
                Value = value,
                PrevNode = prev.PrevNode
            };
        }
        /// <summary>
        /// Добавление ноды после элемента
        /// </summary>
        /// <param name="node">позиция ноды</param>
        /// <param name="value">значение ноды</param>
        /// <exception cref="ArgumentException">Если нода после которой необходимо добавить новую, не найдена, то выдаёт исключение</exception>
        public void AddNodeAfter(Node node, int value)
        {
            Node currentNode = next.NextNode;
            while (currentNode != prev && currentNode != node)
            { currentNode = currentNode.NextNode; }
            if (currentNode != prev)
            {
                currentNode.NextNode = new Node()
                {
                    Value = value,
                    PrevNode = currentNode,
                    NextNode = currentNode.NextNode

                };
            }
            else
            { throw new ArgumentException("Ноды не существует!", nameof(node)); }
        }
        /// <summary>
        /// Поиск ноды по значению
        /// </summary>
        /// <param name="searchValue">значение ноды</param>
        /// <returns>Возвращает значение ноды или null</returns>
        public Node FindNode(int searchValue)
        {
            Node currentNode = next.NextNode;
            while (currentNode != prev && currentNode.Value != searchValue)
            {
                currentNode = currentNode.NextNode;
            }
            if (currentNode != prev)
                return currentNode;
            else
                return null;
        }
        /// <summary>
        /// Определение количества элементов в списке
        /// </summary>
        /// <returns>Количество элемнтов в списке</returns>
        public int GetCount()
        {
            int count = 0;
            Node currentNode = next.NextNode;
            while (currentNode != prev)
            {
                currentNode = currentNode.NextNode;
                count++;
            }
            return count;
        }
        /// <summary>
        /// Удаление ноды по индексу
        /// </summary>
        /// <param name="index">позиция ноды</param>
        /// <exception cref="ArgumentException">В случае отсутствия ноды по указанной позии, выкидывает исключение</exception>
        public void RemoveNode(int index)
        {
            int count = 0;
            Node currentNode = next.NextNode;
            while ((currentNode != prev) && (count < index))
            {
                currentNode = currentNode.NextNode;
                count++;
            }
            if (count == index)
            { RemoveNode(currentNode); }
            else
            { throw new ArgumentException("Ноды в данной позиции не существует", nameof(index)); }
        }
        /// <summary>
        /// Удаление ноды по значнию
        /// </summary>
        /// <param name="node">Значение ноды</param>
        public void RemoveNode(Node node)
        {
            Node next = node.NextNode;
            Node prev = node.PrevNode;
            next.PrevNode = prev;
            prev.NextNode = next;
            node.NextNode = null;
            node.PrevNode = null;
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


