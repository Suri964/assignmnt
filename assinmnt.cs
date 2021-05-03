using System.Collections.Generic;
using System;
using System.Linq;

public class Program {
   public static void Main() {
      List<int> myList = new List<int>(){1, 2, 3, 5, 8, 9};
      public void getMissingNo(A){
      int a = myList.OrderBy(x => x).First();
      int b = myList.OrderBy(x => x).Last();
      List<int> myList2 = Enumerable.Range(a, b - a + 1).ToList();
      List<int> remaining = myList2.Except(myList).ToList();
      Console.WriteLine("Missing numbers... ");
      foreach (int res in remaining) {
         Console.WriteLine(res);
      }
   }
}
}