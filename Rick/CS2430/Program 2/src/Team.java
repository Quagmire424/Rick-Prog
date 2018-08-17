/**
 Creates a team with members and the number of members.
 This class also can find a member, grow the team, check to see if it is
 empty.  It can also add to the team, remove, check if the team contains
 a member, and can print out the members.
 @author Nick Kvigne  
 */
public class Team 
{
   private final int NOT_FOUND = -1;
   private final int GROW_SIZE = 4;
   private TeamMember [] team;
   private int numMembers;
   
   /**
   Constructor. Creates a new team and sets numMembers to 0.
   */
   public Team()
   {
      team = new TeamMember [GROW_SIZE];
      numMembers = 0;
   }
   
   /**
   Finds and returns index of a member.
   @param m member being found
   @return index of member if found, -1 if not found
   */
   private int find(TeamMember m)
   {
      for (int i = 0; i < numMembers; i++)
      {
         if (m.equals(team[i]))
            return i;
      }
      return NOT_FOUND;
   }
   
   /**
   Grows the list by GROW_SIZE.
   */
   private void grow()
   {
      TeamMember temp [] = new TeamMember [team.length + GROW_SIZE];
      for(int i = 0; i < numMembers; i++)
         temp [i] = team [i];
      team = temp;
   }
   /**
   Checks to see if the team is empty.
   @return returns true if team is empty, false otherwise
   */
   public boolean isEmpty()
   {
      return numMembers == 0; 
   }
   
   /**
   Adds a member to the team.
   @param m member being added to team
   */
   public void add(TeamMember m)
   {
      if (numMembers == team.length)
         grow();
      team[numMembers++] = m;
   }
   
   /**
   Removes a member from the team.
   @param m member being removed
   @return true if member is removed, false otherwise
   */
   public boolean remove(TeamMember m)
   {
      int index = find(m);
      if (index == NOT_FOUND)
         return false;
      team[index] = team[--numMembers];
      team[numMembers] = null;
      return true;
   } 
   
   /**
   Checks to see if the member is already in the team.
   @param m member being checked
   @return true if found, false otherwise
   */
   public boolean contains(TeamMember m)
   {
      int index = find (m);
      if (index == NOT_FOUND)
         return false;
      return true;
   } 
   
   /**
   Prints the team members out with the date started.
   */
   public void print()
   {
      System.out.println("We have the following team members:");
      for (int i = 0; i < numMembers; i++)
         System.out.println(team[i].toString());
   } 
}
