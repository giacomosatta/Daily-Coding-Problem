//Asked by whatsapp

//Given an array of integers out of order, determine the bounds of the smallest window that must 
//be sorted in order for the entire array to be sorted. For example, given [3, 7, 5, 6, 9], you should return (2, 4).

var array = new List<int>{1, 3, 2, 7, 5, 6, 4, 8 };
findSubarray(array);

void findSubarray(List<int> arr)
{
    int leftIndex = -1, rightIndex = -1;
 
    // traverse from left to right and keep track of maximum so far
    int max_so_far = -1;
    for (int i = 0; i < arr.Count; i++)
    {
        //Entra quando il massimo valore è minore del valore ciclato e aggiorna il valore
        if (max_so_far < arr[i]) {
            max_so_far = arr[i];
        }
 
        // Entra quando il massimo valore è maggiore del valore ciclato e valorizza il confine di destra con il contatore
        if (arr[i] < max_so_far) {
            rightIndex = i;
        }
    }
 
    // traverse from right to left and keep track of the minimum so far
    int min_so_far = 999999999;
    for (int i = arr.Count - 1; i >= 0; i--)
    {
        if (min_so_far > arr[i]) {
            min_so_far = arr[i];
        }
 
        // find the last position that is more than the minimum so far
        if (arr[i] > min_so_far) {
            leftIndex = i;
        }
    }
 
    if (leftIndex == -1) {
        Console.WriteLine("Array is already sorted");
        return;
    }
 
   Console.WriteLine($"Sort array from index {leftIndex} to {rightIndex}");
}
