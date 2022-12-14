//Given an array of integers, find the first missing positive integer in linear time and constant space. In other words, find the lowest positive integer that does not exist in the array. The array can contain duplicates and negative numbers as well.
//For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
//Asked by Stripe

 int [] array = {2,1,-1,0};
 int size = array.Length;
CheckLowestPositive(array);

void CheckLowestPositive(int[] arr){

     int shift = segregate(arr, size);
        int[] arr2 = new int[size - shift];
        int j = 0;
 
        for (int i = shift; i < size; i++) {
            arr2[j] = arr[i];
            j++;
        }
 
        // Shift the array and call
        // findMissingPositive for
        // positive part
        int missing= findMissingPositive(arr2, j);
        
        Console.WriteLine("Il numero mancante è:"+missing); 
}
 static int segregate(int[] arr, int size)
    {
        int j = 0, i;
        for (i = 0; i < size; i++) {
            if (arr[i] <= 0) {
                int temp;
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
 
                // increment count of non-positive
                // integers
                j++;
            }
        }
 
        return j;
    }

 static int findMissingPositive(int[] arr, int size){
        int i;
 
        // Mark arr[i] as visited by making
        // arr[arr[i] - 1] negative. Note that
        // 1 is subtracted as index start from
        // 0 and positive numbers start from 1
        for (i = 0; i < size; i++) {
            if (Math.Abs(arr[i]) - 1 < size && arr[ Math.Abs(arr[i]) - 1] > 0)
                arr[ Math.Abs(arr[i]) - 1] = -arr[ Math.Abs(arr[i]) - 1];
        }
 
        // Return the first index value at
        // which is positive
        for (i = 0; i < size; i++)
            if (arr[i] > 0)
                return i + 1;
 
        // 1 is added because indexes
        // start from 0
        return size + 1;
    }