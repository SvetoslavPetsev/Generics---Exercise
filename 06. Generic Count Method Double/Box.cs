namespace GenericsExercise

{
    using System;
    using System.Collections.Generic;

    public class Box<T>
        where T: IComparable<T>
    {
        private List<T> boxCollection;
        public Box()
        {
            this.boxCollection = new List<T>();
        }
        public void Compare(T item)
        {
            foreach (var box in this.boxCollection)
            {
                if (box.CompareTo(item) > 0)
                {
                    GreaterCounter++;
                }
            }
        }
        public void Add(T box)
        {
            this.boxCollection.Add(box);
        }
        public int GreaterCounter { get; private set; }
        
    }
}
