namespace GenericArrayCreator
{
    public static class ArrayCreator
    {
        public static T[] Create<T>(int length, T element)
        {
            var array = new T[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = element;
            }

            return array;
        }
    }
}