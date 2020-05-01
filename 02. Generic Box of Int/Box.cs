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
