namespace IndeksatorTraining.UI
{
    public class Element<TKey, TValue>
    {
        //public int HashCode { get; set; }

        public TKey Key { get; }

        public TValue Value { get; }

        public Element<TKey, TValue> Next { get; set; }

        public Element(TKey key, TValue value)
        {
            //HashCode = key.GetHashCode();

            Key = key;

            Value = value;
        }

        //public override int GetHashCode()
        //{
        //    return HashCode;
        //}

        //public override bool Equals(object obj)
        //{
        //    if (obj == null || !(obj is Element<TKey, TValue>))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return HashCode == ((Element<TKey, TValue>)obj).Key.GetHashCode();
        //    }
        //}

        public override string ToString()
        {
            return $"Key: {Key}, Value: {Value}";
        }
    }
}
