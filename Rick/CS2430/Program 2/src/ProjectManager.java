/**
 This class manages the project with teams.  It can add and remove members,
 as well as print out who is on the team.
 @author Nick Kvigne 
 */
import java.util.Scanner;

public class ProjectManager
{
   Scanner stdin;
   Team csse;
   /**
   This method takes in input and calls the proper command on the team.
   Commands can be A, R, P, or Q.  These have to be upper case.
   */
   public void run()
   {
      System.out.println("Let's start a new team!");
      stdin = new Scanner(System.in); 
      csse = new Team();
      boolean done = false;
      while ( !done )
      {
         String command = stdin.next();
         switch (command.charAt(0))  
         {   
            case 'A': add();
               break;
            case 'R': remove();
               break;
            case 'P': print();
               break;
            case 'Q': print();
               System.out.println("The team is ready to go!");
               done = true;
               break;
            default: System.out.println("Command '" + command 
                  + "' not supported!");
               stdin.nextLine();
               break;
         }  
      }
      //write java code before you terminate the program
   } //run()
   
   /**
   This method checks to see if the date is valid.  Then will check if the
   member is already on the team, adding them if they are not.
   */
   private void add()
   {
      String name = stdin.next();
      Date d = new Date(stdin.next());
      TeamMember m = new TeamMember(name, d);
      if (d.isValid())
      {
         if (csse.contains(m))
            System.out.println(m.toString() + " is already in the team.");
         else
         {
            csse.add(m);
            System.out.println(m.toString() + " has joined the team.");
         }
      }
      else
         System.out.println(d.toString() + " is not a valid date!");
     //must check if the date is valid
	  //must call the contains() method to check if a given 
	  //team member is in the team already
   }
   
   /**
   This method checks to see if the date is valid.  Then will remove if the
   date is valid, or give a message if not.
   */
   private void remove()
   {
      String name = stdin.next();
      Date d = new Date(stdin.next());
      TeamMember m = new TeamMember(name, d);
      if (d.isValid())
      {
         if (csse.remove(m))
            System.out.println(m.toString() + " has left the team.");
         else
            System.out.println(m.toString() + " is not a team member.");
      }
//must check if the date is valid
   }
   
   /**
   This method checks to see if the team is empty, printing the members if
   not empty.
   */
   private void print()
   {
      if(csse.isEmpty())
         System.out.println("We have 0 team members!");
      else
      {
      csse.print();
      System.out.println("-- end of the list --");
      }
   }   
} //ProjectManager
