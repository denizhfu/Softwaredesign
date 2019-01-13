using System;
using System.Collections.Generic;


namespace C_Sharp11 {
   
   public class TestDelegate {
       public delegate int NumberChanger(int n);
      static int num = 10;
      
      public static int AddNum(int p) {
         num += p;
         return num;
      }
      public static int MultNum(int q) {
         num *= q;
         return num;
      }
      public static int getNum() {
         return num;
      }
      
   }
}