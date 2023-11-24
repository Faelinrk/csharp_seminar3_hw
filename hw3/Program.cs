namespace hw1{
    class Program{
        public static void Main(string[] args){
            float[] numbers = {5.26f, 62.16f, 8.512f, 623.156f, 7.123f, 12.5235f};
            float resultDiff = GetMax(numbers) - GetMin(numbers);
            Console.WriteLine($"Разница между минимальным и максимальным элементом массива: {resultDiff}");
        }
        private static float GetMax(float[] array){
            float max = array[0];
            for(int i = 1; i < array.Length; i++){
                if (array[i] > max){
                    max = array[i];
                }
            }
            return max;
        }
        private static float GetMin(float[] array){
            float min = array[0];
            for(int i = 1; i < array.Length; i++){
                if (array[i] < min){
                    min = array[i];
                }
            }
            return min;
        }
    }

}