using System;

namespace JobLessonAlgo02v01Part01
{
    class NodesFunctions : ILinkedList
    {
        private Node _firstNode;
        private Node _lastNode;

        /// <summary>
        /// Первая нода
        /// </summary>
        public Node FirstNode
        { get { return _firstNode; } set { _firstNode = value; } }
        /// <summary>
        /// Последня нода
        /// </summary>
        public Node LastNode
        { get { return _lastNode; } set { _lastNode = value; } }

        /// <summary>
        /// Конструктор нод
        /// </summary>
        /// <param name="value">значение первой ноды</param>
        public NodesFunctions(int value)
        {
            FirstNode = new Node()
            {
                Value = value,
                PrevNode = null,
                NextNode = null
            };
            LastNode = FirstNode;
        }

        /// <summary>
        /// Добавление ноды в конец
        /// </summary>
        /// <param name="value">значение ноды</param>
        public void AddNode(int value)
        {
            var newNode = new Node() { Value = value };
            if (FirstNode == null)
            {
                FirstNode = newNode;
                LastNode = newNode;
            }
            else
            {
                Node currentNode = LastNode;
                currentNode.NextNode = newNode;
                newNode.PrevNode = currentNode;
                LastNode = newNode;
            }
        }
        /// <summary>
        /// Добавление ноды после элемента
        /// </summary>
        /// <param name="node">позиция ноды</param>
        /// <param name="value">значение ноды</param>
        public void AddNodeAfter(Node node, int value)
        {
            Node newNode = new Node() { Value = value };
            if (node == LastNode)
                AddNode(value);
            else
            {
                Node nextNode = node.NextNode;
                nextNode.PrevNode = newNode;
                node.NextNode = newNode;
                newNode.NextNode = nextNode;
                newNode.PrevNode = node;
            }
        }
        /// <summary>
        /// Поиск ноды по значению
        /// </summary>
        /// <param name="searchValue">значение ноды</param>
        /// <returns>Возвращает значение ноды или null</returns>
        public Node FindNode(int searchValue)
        {
            var currentNode = FirstNode;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                { 
                    Console.WriteLine(currentNode.Value);
                    return currentNode; 
                }
                currentNode = currentNode.NextNode;
            }
            return null;
        }
        /// <summary>
        /// Определение количества элементов в списке
        /// </summary>
        /// <returns>Количество элемнтов в списке</returns>
        public int GetCount()
        {
            int count = 0;
            Node currentNode = FirstNode;
            while (currentNode != LastNode)
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
        public void RemoveNode(int index)
        {

            int count = 0;
            Node currentNode = FirstNode;
            while ((currentNode != LastNode) && (count < index))
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

        public int[] GetValueNodes()
        {            
            Node currentNode = FirstNode;
            int count = GetCount();
            int[] intArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                intArray[i] = currentNode.Value;
                currentNode = currentNode.NextNode;
                Console.WriteLine(intArray[i]);

            }
            return intArray;
        }
    }
}