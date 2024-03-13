// Задайте произвольный массив. Выведете его
// элементы, начиная с конца используя рекурсию.


  int [] arr= {3,7,9,10,15,20};
  ShowArray(arr);
  
  
static void ShowArray(int [] array){
    
    if (array.Length==0){
        return;
    }
    else{
        int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < newArray.Length; i++){
        newArray[i]=array[i];
    }
        Console.WriteLine(array[array.Length-1]);
        ShowArray(newArray);
        
    }
    
}
