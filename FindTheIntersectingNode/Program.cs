//Given two singly linked lists that intersect at some point, find the intersecting node. The lists are non-cyclical.
//For example, given A = 3 -> 7 -> 8 -> 10 and B = 99 -> 1 -> 8 -> 10, return the node with value 8.
//Asked by Google

int[] list1 = {3,7,8,10};
int[] list2 = {99,1,5,7};
FindTheIntersect(list1,list2);

void FindTheIntersect(int[] list1, int[] list2){
    int? output = null;

    output = list1.FirstOrDefault(x => list2.Contains(x));
    // foreach(int number in list1)
    //     if(list2.Contains(number)){    
    //         output = number;   
    //         break;
    //     } 

    if(output == 0)
       Console.WriteLine($"Le due liste non si intersecano");  

    if(output != 0)
    Console.WriteLine($"Le due liste si intersecano con il valore {output}");
}