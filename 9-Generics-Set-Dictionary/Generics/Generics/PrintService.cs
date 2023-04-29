namespace Generics
{
    public class PrintService<T>
    {
        private T[] _values = new T[3];
        private int _count = 0;

        public void AddValeu(T value)
        {
            if (_count == 3)
                throw new InvalidOperationException("PrintService is full");

            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            foreach (T value in _values) 
            {
                Console.Write(value + " ");
            }
            Console.Write("]");
        }
    }
}
