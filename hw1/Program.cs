namespace hw1{
    class Program{
        public static void Main(string[] args){
            int[] numbers = {52,63,12,62,71,23,6,2,12,1};
            int resultCount = GetInRangeCount(numbers, 20, 90);
            Console.WriteLine($"Количество чисел в диапазоне: {resultCount}");
        }
        private static int GetInRangeCount(int[] array, int rangeStart, int rangeEnd){
            int count = 0;
            for(int i = 0; i < array.Length; i++){
                if (array[i] >= rangeStart && array[i] <= rangeEnd){
                    count++;
                }
            }
            return count;
        }

    }

}