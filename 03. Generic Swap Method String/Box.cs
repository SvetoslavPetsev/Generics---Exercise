namespace GenericsExercise

{
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private List<T> boxCollection;
        public Box()
        {
            this.boxCollection = new List<T>();
        }

        public void Add(T box)
        {
            this.boxCollection.Add(box);
        }

        public void Swap(int[] indexes)
        {
            int firstIndex = indexes[0];
            int secondIndex = indexes[1];
            if (firstIndex >= 0 && firstIndex < this.boxCollection.Count &&
                secondIndex >= 0 && secondIndex < this.boxCollection.Count)
            {
                T first = this.boxCollection[firstIndex];
                T second = this.boxCollection[secondIndex];
                this.boxCollection[firstIndex] = second;
                this.boxCollection[secondIndex] = first;
            }       
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var box in this.boxCollection)
            {
                result.AppendLine($"{box.GetType().FullName}: {box}");
            }

            return result.ToString();
        }
    }
}
