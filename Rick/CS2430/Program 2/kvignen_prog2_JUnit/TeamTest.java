/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**

 @author Nick
 */
public class TeamTest
{
   
   public TeamTest()
   {
   }
   
   @BeforeClass
   public static void setUpClass()
   {
   }
   
   @AfterClass
   public static void tearDownClass()
   {
   }
   
   @Before
   public void setUp()
   {
   }
   
   @After
   public void tearDown()
   {
   }

   /**
    * Test of isEmpty method, of class Team.
    */
   @Test
   public void testIsEmpty()
   {
      System.out.println("isEmpty");
      Team instance = new Team();
      boolean expResult = true;
      boolean result = instance.isEmpty();
      assertEquals(expResult, result);
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }

   /**
    * Test of add method, of class Team.
    */
   @Test
   public void testAdd()
   {
      System.out.println("add");
      TeamMember m = new TeamMember("Lily", new Date("11/27/2011"));
      TeamMember a = new TeamMember("Bob", new Date("11/26/2011"));
      TeamMember b = new TeamMember("Nick", new Date("11/25/2011"));
      TeamMember c = new TeamMember("Chase", new Date("11/24/2011"));
      TeamMember d = new TeamMember("Cody", new Date("11/23/2011"));
      Team instance = new Team();
      instance.add(m);
      instance.add(a);
      instance.add(b);
      instance.add(c);
      instance.add(d);
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }

   /**
    * Test of remove method, of class Team.
    */
   @Test
   public void testRemove()
   {
      System.out.println("remove");
      TeamMember m = new TeamMember("Lily", new Date("11/27/2011"));
      Team instance = new Team();
      boolean expResult = true;
      instance.add(m);
      boolean result = instance.remove(m);
      assertEquals(expResult, result);
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }

   /**
    * Test of contains method, of class Team.
    */
   @Test
   public void testContains()
   {
      System.out.println("contains");
      TeamMember m = new TeamMember ("Lily", new Date("11/27/2011"));
      Team instance = new Team();
      boolean expResult = true;
      instance.add(m);
      boolean result = instance.contains(m);
      assertEquals(expResult, result);
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }

   /**
    * Test of print method, of class Team.
    */
   @Test
   public void testPrint()
   {
      System.out.println("print");
      Team instance = new Team();
      TeamMember m = new TeamMember ("Lily", new Date("11/27/2011"));
      instance.add(m);
      instance.print();
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }
   
}
