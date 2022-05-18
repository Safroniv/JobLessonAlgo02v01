using System;

namespace JobLessonAlgo02v01Part01
{
    public class NodesFunctions : ILinkedList
    {
        private readonly Node first = new Node();
        private readonly Node last = new Node();


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
        
        public NodesFunctions()
        {
            first.NextNode = last;
            last.PrevNode = first;
        }



        /// <summary>
        /// Добавление ноды в конец
        /// </summary>
        /// <param name="value">значение ноды</param>
        public void AddNode(int value)
        {
            last.PrevNode = new Node()
            {
                Value = value,
                PrevNode = last.PrevNode
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
            Node currentNode = first.NextNode;
            while (currentNode != last && currentNode != node)
            { currentNode = currentNode.NextNode; }
            if (currentNode != last)
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
            Node currentNode = first.NextNode;
            while (currentNode != last && currentNode.Value != searchValue)
            {
                currentNode = currentNode.NextNode;
            }
            if (currentNode != last)
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
            Node currentNode = first.NextNode;
            while (currentNode != last)
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
            Node currentNode = first.NextNode;
            while ((currentNode != last) && (count < index))
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

        public void MassiveValues ()
        {

        }

    }
}