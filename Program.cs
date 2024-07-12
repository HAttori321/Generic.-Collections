namespace Generic._Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            int maxInt = MaxOfThree(1, 2, 3);
            Console.WriteLine(maxInt);
            //TASK2
            int minInt = MinOfThree(1, 2, 3);
            Console.WriteLine(minInt);
            //TASK3
            int[] intArray = { 1, 2, 3, 4, 5 };
            int sumInt = SumArray(intArray);
            Console.WriteLine(sumInt);
            //TASK4
            Stack<int> intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(2);
            intStack.Push(3);
            Console.WriteLine("Count : " + intStack.Count);
            Console.WriteLine("Peek : " + intStack.Peek());
            int popped = intStack.Pop();
            Console.WriteLine("Popped : " + popped);
            Console.WriteLine("Count : " + intStack.Count);
            while (intStack.Count > 0)
            {
                Console.WriteLine("Popped : " + intStack.Pop());
            }
        }
        //TASK1
        public static T MaxOfThree<T>(T a, T b, T c) where T : IComparable<T>
        {
            T max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }
        //TASK2
        public static T MinOfThree<T>(T a, T b, T c) where T : IComparable<T>
        {
            T min = a;
            if (b.CompareTo(min) < 0)
            {
                min = b;
            }
            if (c.CompareTo(min) < 0)
            {
                min = c;
            }
            return min;
        }
        //TASK3
        public static T SumArray<T>(T[] array) where T : struct
        {
            dynamic sum = 0;
            foreach (T element in array)
            {
                sum += element;
            }
            return sum;
        }
        //TASK4
        public class Stack<T>
        {
            private T[] elements;
            private int top;
            public Stack()
            {
                elements = new T[10];
                top = -1;
            }
            public void Push(T item)
            {
                elements[++top] = item;
            }
            public T Pop()
            {
                return elements[top--];
            }
            public T Peek()
            {
                return elements[top];
            }
            public int Count
            {
                get { return top + 1; }
            }
        }

    }
}
