/**
This class creates a team member with a name and start date.
It can also return the date in a proper format (mm/dd/yyyy). 
@author Nick Kvigne 
*/
public class TeamMember 
{
   private String name;
   private Date   startDate;
   /**
   Constructor.  Creates a team member with a name and start date.
   @param nm
   @param date 
   */
   public TeamMember(String nm, Date date)
   {
      name = nm;
      startDate = date;
   }
   /**
   Returns the start date of the calling team member.
   @return start date
   */
   public Date getDate()
   {
      return startDate;
   }
   /**
   Team members are equal if the names and start dates are the same.
   @param obj
   @return true if they are equal, false otherwise
   */
   public boolean equals(Object obj)
   {
      if (obj instanceof TeamMember)
      {
         TeamMember t = (TeamMember) obj;
         return startDate.equals(t.startDate) && name.equals(t.name);
      }
      return false;
   }   
   /**
   Returns the name and start date of a team member as a string.
   @return name and start date
   */
   public String toString()
   {
      return name + " " + startDate; 
   }
   /**
   Tests all of the methods and constructor.
   @param args 
   */
   public static void main(String [] args)
   {
      TeamMember t = new TeamMember("Nick", new Date("4/24/1995"));
      System.out.println("t:" + t.toString());
      TeamMember t2 = new TeamMember("Nick", new Date ("4/24/1995"));
      System.out.println("t2:" + t2.toString());
      TeamMember t3 = new TeamMember("Jeff", new Date ("4/25/1995"));
      System.out.println("t3:" + t3.toString());
      if (t.equals(t2))
         System.out.println("t is equal to t2.");
      else
         System.out.println("t is not equal to t2.");
      if (t.equals(t3))
         System.out.println("t is equal to t3.");
      else
         System.out.println("t is not equal to t3.");
      System.out.println(t.getDate());
      //testbed main; you must include test cases that exercise 
	  //the constructor and all methods in this class.
   }
}