﻿// Fig. 6.13: ContinueTest.cs
// continue statement terminating an iteration of a for statement.
using System;

public class ContinueTest
{
   public static void Main(string[] args)
   {
      for (int count = 1; count <= 10; ++count) // loop 10 times
      {
         if (count == 5) // if count is 5, 
            continue; // skip remaining code in loop

         Console.Write("{0} ", count);
      } // end for

      Console.WriteLine("\nUsed continue to skip displaying 5\n");

      /* In this example, a counter is initialized to count from 1 to 10. By using the continue 
       * statement in conjunction with the expression (i < 9), the statements between continue 
       * and the end of the for body are skipped. */
      for (int i = 1; i <= 10; i++)
      {
         if (i < 9)
         {
            continue;
         }
         Console.WriteLine(i);
      }

      // Keep the console open in debug mode.      
      Console.WriteLine("\nPress any key to exit.");
      Console.ReadKey();

   } // end Main
} // end class ContinueTest


/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
