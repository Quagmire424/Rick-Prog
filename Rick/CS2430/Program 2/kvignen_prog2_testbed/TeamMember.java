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
      return startDate.equals(obj) && name.equals(obj);
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
      System.out.println(t.toString());
      TeamMember t2 = new TeamMember("Nick", new Date ("4/24/1995"));
      TeamMember t3 = new TeamMember("Jeff", new Date ("4/25/1995"));
      System.out.println(t.equals(t2));
      System.out.println(t.equals(t3));
      System.out.println(t.getDate());
      //testbed main; you must include test cases that exercise 
	  //the constructor and all methods in this class.
   }
}