
/**
This class reads in the commands, calculates the validity of the command,
and then calls the proper method for that command.
 @author Timothy Allen and Nick Kvigne
 */
import java.io.*;
import java.util.*;
import java.lang.*;

public class ConsoleSimulator
{
   private String command;
   private boolean quit = false;
   private Simulation sim = new Simulation();
   Scanner stdin = new Scanner (System.in);
   
   /**
   Reads in a command, calling the proper method if command is valid,
   otherwise prints an error message.
   @throws IOException 
   */
   public void run() throws IOException
   {
      while (!quit)
      {
         command = stdin.next();
         if (notValid(command))
         {
            stdin.nextLine();
            System.out.println(command + " is NOT a valid command!");
         }
         else
         {
            optionList(command);
         }
      }
   }

   /**
   A method that calls method based on given command.
   @param command given to call corresponding method
   */
   public void optionList(String command)
   {
      switch (command)
      {
         case "A":
            arrival();
            break;
         case "L":
            leaving();
            break;
         case "C":
            command = stdin.next();
            clock(Integer.parseInt(command));
            break;
         case "S":
            stats();
            break;
         case "Q":
            quit = quit();
            break;
      }
   }

   /**
   A method that determines if the command is valid or not.
   @param command being checked for validity
   @return true if valid, false otherwise
   */
   public boolean notValid(String command)
   {
      char input = command.charAt(0);

      if (command.length() > 1 && command.charAt(1) != ' ')
      {
         return true;
      }
      if (input == 'A' || input == 'L' || input == 'C'
            || input == 'S' || input == 'Q')
      {
         return false;
      }
      return true;
   }

   /**
   A method that deals with the arrival of a customer.
   */
   public void arrival()
   {
      if (sim.lineFull())
      {
         System.out.println("A customer couldn't get in the line @time "
               + sim.getClock() + " because the line was full.");
         sim.newCustomer();
      }
      else
      {
         sim.arrive();
         System.out.println("A customer has arrived @time " + sim.getClock()
               + ". Number of customers waiting in the line: " + sim.size());
      }
   }

   /**
   A method that deals with the leaving of a customer.
   */
   public void leaving()
   {
      boolean place = sim.storeEmpty();
      int lineSize;
      if (sim.size() > 0)
      {
         lineSize = sim.size() - 1;
      }
      else
      {
         lineSize = 0;
      }
      if (place)
      {
         System.out.println("Nobody is being served @time " + sim.getClock()
               + ".");
      }
      else
      {         
         System.out.println(sim.currentCust() + " finished @time "
               + sim.getClock() + ". Number of customers waiting: "
               + Integer.toString(lineSize) + ".");
         sim.leave();
      }
   }

   /**
   A method that deals with updating the clock.
   @param time is added to the clock
   */
   public void clock(int time)
   {
      if (time < 1)
      {
         System.out.println("Time NOT updated with " + time + ".");
      }
      else
      {
         sim.updateClock(time);
         System.out.print("Time updated by " + time);

         if (time == 1)
         {
            System.out.print(" unit");
         }
         else
         {
            System.out.print(" units");
         }
         System.out.println("; current time is " + sim.getClock() + ".");
      }
   }

   /**
   A method that deals with printing out the statistics of the simulation
   at the time.
   */
   public void stats()
   {
      System.out.println();
      System.out.print("The average wait time for the customers who "
            + "finished waiting: ");
      if (sim.getWaited() == 0)
      {
         System.out.println("0.0.");
      }
      else
      {
         System.out.println(sim.average()
               + ".");
      }

      System.out.println("The total wait time is " + sim.getTotalWait()
            + ".");
      System.out.println("The number of customers finished: "
            + sim.getFinished() + ".");
      System.out.println("The number of customers who did not have to "
            + "wait: " + sim.getNoWait() + ".");
      System.out.println();
   }

   /**
   A method that deals with finishing the simulation and printing the 
   proper information from the simulation.
   @return true once completed
   */
   public boolean quit()
   {
      System.out.print("Simulation statistics: ");
      stats();
      System.out.println("Simulation terminated.");
      return true;
   }
}
