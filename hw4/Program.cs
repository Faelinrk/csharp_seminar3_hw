namespace hw1{
    class Program{
        public static void Main(string[] args){
            int number = 12535;
            int[] resultArray = ToArray(number);
            
            for(int i = 0; i < resultArray.Length; i++){
                Console.WriteLine($"{resultArray[i]}");
            }
        }
        private static int[] ToArray(int number){
            int[] array;
            if (number < 10){
                array = new int[1];
            }
            else if (number < 100){
                array = new int[2];
            }
            else if (number < 1000){
                array = new int[3];
            }
            else if (number < 10000){
                array = new int[4];
            }
            else if (number < 100000){
                array = new int[5];
            }
            else{
                array = new int[6];
            }
            for(int i = array.Length - 1; i >= 0; i--){
                array[i] = number % 10;
                number /= 10;
            }
            return array;
        }
    }

}