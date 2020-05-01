namespace GenericsExercise
{
    public class Threeuple<T,V,W>
    {
        private T item1;
        private V item2;
        private W item3;

        public Threeuple(T item1, V item2, W item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public string GetInfo()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }
    }
}
