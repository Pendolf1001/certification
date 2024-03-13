// Задача 1:

// Задайте значения M и N. Напишите
// программу , которая выведет все натуральные числа от M до N. использовать рекурсию.


 Console.WriteLine("введите меньшее число");
 int n=Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("введите большее число");
 int m=Convert.ToInt32(Console.ReadLine());
 
CounterOfProgress(m,n);
 

static void CounterOfProgress(int max, int min){
       if(max-1<min){
        Console.WriteLine(max);
    }
    else{
        CounterOfProgress(max-1,min);
        Console.WriteLine(max);
        
    }
    
}  
  
 

