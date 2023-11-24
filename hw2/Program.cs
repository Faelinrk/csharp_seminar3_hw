namespace hw1{
    class Program{
        public static void Main(string[] args){
            int[] numbers = {52,63,12,62,71,23,6,2,12,1};
            int resultCount = GetEvenCount(numbers);
            Console.WriteLine($"Количество четных чисел в массиве: {resultCount}");
        }
        private static int GetEvenCount(int[] array){
            int count = 0;
            for(int i = 0; i < array.Length; i++){
                if (array[i] %2 == 0){
                    count++;
                }
            }
            return count;
        }

    }

}