using System;

namespace models
{
    public class ExampleGeneric<T>
    {       
        public T Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }

    }
}
