namespace MySetProject
{
    public class SetOperations<T>
    {
        public MySet<T> Union(MySet<T> setA, MySet<T> setB)
        {
            MySet<T> result = new MySet<T>();

            foreach (var item in setA.GetAll()) result.Add(item);
            foreach (var item in setB.GetAll()) result.Add(item);

            return result;
        }

        public MySet<T> Intersect(MySet<T> setA, MySet<T> setB)
        {
            MySet<T> result = new MySet<T>();

            foreach (var item in setA.GetAll())
            {
                if (setB.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        public void PrintSet(string name, MySet<T> set)
        {
            Console.Write($"{name}: {{ ");
            Console.Write(string.Join(", ", set.GetAll()));
            Console.WriteLine(" }");
        }
    }
}
