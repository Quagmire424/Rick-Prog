/**
 This class reads in the expressions and then performs it if the expression
is valid.  It then prints out that information, with what type of number
the result is.
 @author Nick Kvigne
 */

import java.io.*;
import java.util.*;

public class PostfixEvaluator 
{
   private static final int STACK_SIZE = 100;
   private Stack operand;
   private String expression;
   private ArrayList<Complex> answers;
   
   /**
   Reads in an expression and computes the result if it is valid.  
   */
   public void run() throws IOException
   {
      boolean EOF = false;
      BufferedReader stdin = new BufferedReader(new InputStreamReader(System.in));
      //BufferedReader stdin = new BufferedReader(new FileReader("Prog3_1.in"));
      operand = new Stack (STACK_SIZE);
      answers = new ArrayList<>();
      int count = 0;
      while ( !EOF)
      {
         expression = stdin.readLine();
         count++;
         if (expression == null)
            EOF = true;
         else
         {
            operand.clear();
            System.out.print("Expression " + count + ": ");
            Complex result = evaluate (expression);
            if (result != null)
            {
               answers.add(result);
               System.out.println("value: " + result.toString());
            }
            else
            {
               System.out.println("Invalid Expression!");
            }
         }
      }
      print();
   }
   
   /**
   Tokenizes the expression and then performs the operations if valid, which
   returns the result as a complex number.  Also prints the tokens used.
   @param expression
   @return 
   */
   private Complex evaluate(String expression)
   {
      boolean valid = true;
      Complex result = new Complex();
      StringTokenizer st = new StringTokenizer (expression);
      if (!st.hasMoreTokens())
      {
         System.out.println("");
         return null;
      }
      while (valid && st.hasMoreTokens())
      {
         String token = st.nextToken();
         System.out.print(token + " ");
         if (token.equals("+") || token.equals("-") || token.equals("*")
               || token.equals("~"))
            valid = operator(token);
         else
            valid = operand(token);
      }
      System.out.println("");
      if (valid)
      {
         if (!operand.isEmpty())
            result = (Complex) operand.pop();
         if (operand.isEmpty())
             return result;
      }
      return null;
   }
   
   /**
   Pops 1 or 2 numbers from the stack, then either conjugates, adds,
   subtracts, or multiplies the popped numbers.  Then returns true if done or
   false if not done.
   @param token
   @return 
   */
   private boolean operator(String token)
   {
      Complex op2;
      if (!operand.isEmpty())
         op2 = (Complex) operand.pop();
      else
         return false;
      if (token.equals("~"))
         {
            operand.push(op2.conjugate(op2));
            return true;
         }
      else
         if (!operand.isEmpty())
         {
            Complex op1 = (Complex) operand.pop();
               if (token.equals("+"))
               {
                  operand.push(op1.plus(op2));
               }
               if (token.equals("-"))
               {
                  operand.push(op1.minus(op2));
               }
               if (token.equals("*"))
               {
                  operand.push(op1.times(op2));
               }
               return true;
         }
      return false;
   }
   
   /**
   This checks to see if the token is "i" and pushes a new complex number
   onto the stack.
   @param token
   @return 
   */
   private boolean operand(String token)
   {
      if (token.equals("i"))
      {
         operand.push(new Complex (0,1));
         return true;
      }
      else
      {
         try
         {
            operand.push (new Complex(Integer.parseInt(token)));
            return true;
         }
         catch (NumberFormatException e)
         {
            return false;
         }
      }
   }
   
   /**
   This prints out whether the answer is real, imaginary, or complex.
   */
   private void print ()
   {
      System.out.println("The list of good answers is:");
      for (int i = 0; i < answers.size(); i++)
      {
         Complex c = answers.get(i);
         if (c.equals(c.conjugate(c)))
            System.out.println(c.toString() + " is real");
         else if (c.plus(c.conjugate(c)).equals (new Complex()))
            System.out.println(c.toString() + " is imaginary");
         else
            System.out.println(c.toString() + " is complex");
      }
      System.out.println("Normal Termination of Program 3.");
   }
}
