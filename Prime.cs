using System;  
  public class Example  
   {  
     public static void Main(string[] args)  
      {  
          int num1, num2 , i, x=0;    
         Console.Write("Enter a Number1: ");    
        num1 = int.Parse(Console.ReadLine()); 
   Console.Write("Enter a Number2: ");    
        num2 = int.Parse(Console.ReadLine());  
 for(int num=num1; num<=num2; num++)
 {
           x = num/2; 
     
          for(i = 2; i <= x; i++)    
          {    
           if(num % i == 0)    
            {    
            
             break;    
            } 
            else 
             Console.WriteLine(num);
             break;
          }    
 
              
     }  
   }
   }