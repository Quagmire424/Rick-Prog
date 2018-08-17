/**
 This class creates a complex number with a real and imaginary integer.
It can also add, subtract, and multiply two complex numbers.  The numbers
can be checked for equality and also printed in the proper format.
 @author Nick Kvigne
 */
public class Complex 
{
   private int real;
   private int imag;
   
   /**
   Default constructor to make a complex number.
   */
   public Complex()
   {
      real = 0;
      imag = 0;
   }
   
   /**
   Constructor that creates a complex number with given real number.
   @param a 
   */
   public Complex (int a)
   {
      real = a;
      imag = 0;
   }
   
   /**
   Constructor that creates a complex number with given real and 
   imaginary numbers.
   @param a
   @param b 
   */
   public Complex (int a, int b)
   {
      real = a;
      imag = b;
   }
   
   /**
   Adds two complex numbers together and returns the result.
   @param cp
   @return 
   */
   public Complex plus (Complex cp)
   {
      return new Complex (this.real + cp.real, this.imag + cp.imag);
   }  
   
   /**
   Subtracts given complex number from original complex number and 
   returns the result.
   @param cp
   @return 
   */
   public Complex minus (Complex cp)
   {
      return new Complex (this.real - cp.real, this.imag - cp.imag);
   }
   
   /**
   Multiplies a complex number with original complex number and 
   returns the result.
   @param cp
   @return 
   */
   public Complex times (Complex cp)
   {
      return new Complex (this.real * cp.real - this.imag * cp.imag,
                          this.real * cp.imag + this.imag * cp.real);
   }
   
   /**
   Returns the complex number with the sign of the imaginary number
   switched.
   @param cp
   @return 
   */
   public Complex conjugate (Complex cp)
   {
      return new Complex (real, -imag);
   }
   
   /**
   Checks to see if the given object is equal to the original complex
   number.
   @param obj
   @return 
   */
   @Override
   public boolean equals (Object obj)
   {
      if (obj instanceof Complex)
      {
         Complex n = (Complex) obj;
         return real == n.real && imag == n.imag;
      }
      return false;
   }
   
   /**
   Returns the integers in proper complex number format.
   @return 
   */
   @Override
   public String toString ()
   {
      if ((real > 0 && imag > 1) || (real < 0 && imag > 1))
         return Integer.toString(real) + "+" + Integer.toString(imag) + "i";
      if ((real > 0 && imag == 1) || (real < 0 && imag == 1))
         return Integer.toString(real) + "+i";
      if ((real > 0 && imag == 0) || (real < 0 && imag == 0))
         return Integer.toString(real);
      if ((real > 0 && imag == -1) || (real < 0 && imag == -1))
         return Integer.toString(real) + "-i";
      if ((real > 0 && imag < -1) || (real < 0 && imag < -1))
         return Integer.toString(real) + Integer.toString(imag) + "i";
      if (real == 0 && imag > 1)
         return Integer.toString(imag) + "i";
      if (real == 0 && imag == 1)
         return "i";
      if (real == 0 && imag == 0)
         return Integer.toString(0);
      if (real == 0 && imag == -1)
         return "-i";
      if (real == 0 && imag < -1)
         return Integer.toString(imag) + "i";
      return null;
   }
}
