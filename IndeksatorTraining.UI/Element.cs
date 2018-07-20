namespace IndeksatorTraining.UI
{
    public class Element<TKey, TValue>
    {
        public TKey Key { get; }

        public TValue Value { get; }

        public Element<TKey, TValue> Next { get; set; }

        public Element(TKey key, TValue value)
        {
            Key = key;

            Value = value;
        }

        public override string ToString()
        {
            return $"Key: {Key}, Value: {Value}";
        }
    }
}
