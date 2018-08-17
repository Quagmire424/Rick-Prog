/**
 This class runs the PostfixEvaluator and catches exceptions from that.
@author Nick Kvigne    
*/
public class Prog3
{
   /**
   Runs an instance of PostfixEvaluator.
   @param args is not used
   */
   public static void main (String args[])
   {
      try
      {
         new PostfixEvaluator().run();
      }
      catch (Exception e)
      {
         System.out.println("Couldn't run PostfixEvaluator! " + e );
      }      
   }
}
