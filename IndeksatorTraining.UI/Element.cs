namespace IndeksatorTraining.UI
{
    public class Element<T>
    {
        public T Data { get; set; }

        public Element<T> Next { get; set; }

        public Element(T data)
        {
            Data = data;
        }
    }
}
