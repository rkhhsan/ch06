// Fig. 6.6: Interest.cs
// Compound-interest calculations with for.
using System;

public class Interest
{
   public static void Main( string[] args )
   {
      decimal amount; // amount on deposit at end of each year
      decimal principal = 2000; // initial amount before interest
      double rate = 0.10; // interest rate

      // display headers
      Console.WriteLine( "Year{0,25}", "Amount on deposit" );

      // calculate amount on deposit for each of ten years
      for ( int year = -10; year <= 10; ++year )
      {
         // calculate new amount for specified year
         amount = principal *
            ( ( decimal ) Math.Pow( 1.0 + rate, year ) );

         // display the year and the amount
         Console.WriteLine( "{0,4}{1,25:C}", year, amount );
      } // end for
      Console.WriteLine("\nTecle qualquer tecla para finalizar...");
      Console.ReadKey();
   } // end Main
} // end class Interest


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
