//Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i
//ES: If our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]
//Asked by Uber

int [] array = {1,2,3,4,5};
ArrayProduct(array);

void ArrayProduct(int[] intArray){
    string outputArray = "";

    for(int i = 0; i < intArray.Length; i++){
        int product = 1;
        for(int j = 0; j < intArray.Length; j++){
            if(i==j)
                continue;
            
            product *= intArray[j];
        }
        outputArray += product.ToString() +",";
    }
    Console.WriteLine(outputArray);
}