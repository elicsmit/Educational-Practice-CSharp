namespace MySetProject
{
    public class MySet<T>
    {
        private List<T> _items = new List<T>();

        public bool Add(T item)
        {
            if (!_items.Contains(item))
            {
                _items.Add(item);
                return true;
            }
            return false;
        }

        public bool Remove(T item)
        {
            return _items.Remove(item);
        }

        public bool Contains(T item)
        {
            return _items.Contains(item);
        }

        public List<T> GetAll() => _items;

        public int Count => _items.Count;
      
        public void Clear() => _items.Clear();
    }
}
