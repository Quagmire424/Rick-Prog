/**
 This class runs the ConsoleSimulator and catches exceptions for that.
 @author Timothy Allen and Nick Kvigne
 */
public class Prog4 
{
   /**
   Runs an instance of ConsoleSimulator.
   @param args is not used
   */
   public static void main (String args[])
   {
      try
      {
         new ConsoleSimulator().run();
      }
      catch (Exception e)
      {
         System.out.println(e + " is NOT a valid command!");
      }
   }
}
