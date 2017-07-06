import java.io.*;
import java.util.Scanner;


//I'm unable to sleep, need to code something...  
//Got a problem: https://www.reddit.com/r/programming/comments/as54j/interesting_programming_problems/
//Here it is:
//
//Write a program to convert a number to its textual representation. E.g. 45.03 = "Forty Five point Zero Three" 
//and 3,542,010 = "Three Million Five Hundred and Fourty Two Thousand and Ten.



public class NumToText{

   static String inputNum;
   static String outputTxt;
   public float rawNum;
   //public static String numWord;


   public String word(int x){
      if (x == 0)
         return "zero";
      if (x == 1)
         return "one";
      if (x == 2)
         return "two";
      if (x == 3)
         return "three";
      if (x == 4)
         return "four";
      if (x == 5)
         return "five";
      if (x == 6)
         return "six";
      if (x == 7)
         return "seven";
      if (x == 8)
         return "eight";
      if (x == 9)
         return "nine";
   }

   private String textNumber(String c, int y) {
      
      int numWord = Integer.parseInt(c);
      
      if(y == 4){
         return word(numWord) + "thousand";
      }
      else if(y == 3){
         return word(numWord) + "hundred";
      }
      else if(y == 2){
         //bunch of ifs for teens and twenty thirty etc.
      }
      
   }
         



   private String speakFloat(String x){
   
      int left = x.indexOf(".");
      int right = x.length() - x.indexOf(".");
      
      while(left > 2){
               
         outputTxt = outputTxt + textNumber(x.charAt(0), left);
      
         left--;
      }
      
      outputTxt += textNumber;
      while(right > 0){
      
      }
      System.out.println(left + " , " + right);
      
      return outputTxt;
   }   
   
   private String speakInt(String x){
   
      return outputTxt;
   }


   private float toFloat(String x){
      
       return Float.parseFloat(x);
   }   
         
         


   //Start checks for quality of input, then kicks into translation mode.
   private void start(){
   
      System.out.println(inputNum);
      
      rawNum = toFloat(inputNum);

      if(inputNum.indexOf(".") != -1){
       
         speakFloat(inputNum);
      
      }
      else{
      
         speakInt(inputNum);
      
      }
   }
   


   //Creates objects & calls
   public static void main(String[] args)throws IOException{
      
      NumToText toTxt = new NumToText();
      
      Scanner s = new Scanner(System.in);
      
      System.out.println("\n Please Enter A Number To Be Translated...");
      inputNum = s.nextLine();
      System.out.println();
      
      toTxt.start();
   }
      


}   