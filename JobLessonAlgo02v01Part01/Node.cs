namespace JobLessonAlgo02v01Part01
{
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
    } 
}