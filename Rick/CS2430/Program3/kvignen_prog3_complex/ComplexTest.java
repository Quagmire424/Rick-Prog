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
public class ComplexTest
{
   
   public ComplexTest()
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
    * Test of plus method, of class Complex.
    */
   @Test
   public void testPlus()
   {
      System.out.println("plus");
      Complex cp = new Complex (1,1);
      Complex cp2 = new Complex (-5,-5);
      Complex cp3 = new Complex (3,3);
      Complex positive = new Complex (4,4);
      Complex negative = new Complex (-4,-4);
      Complex result = cp.plus(cp3);
      assertEquals(positive, result);
      result = cp.plus(cp2);
      assertEquals(negative, result);
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }

   /**
    * Test of minus method, of class Complex.
    */
   @Test
   public void testMinus()
   {
      System.out.println("minus");
      Complex cp = new Complex (2,2);
      Complex cp2 = new Complex (5,5);
      Complex cp3 = new Complex (1,1);
      Complex positive = new Complex (1,1);
      Complex negative = new Complex (-3,-3);
      Complex result = cp.minus(cp3);
      assertEquals(positive, result);
      result = cp.minus(cp2);
      assertEquals(negative, result);
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }

   /**
    * Test of times method, of class Complex.
    */
   @Test
   public void testTimes()
   {
      System.out.println("times");
      Complex cp = new Complex (7,6);
      Complex cp2 = new Complex (2,2);
      Complex expResult = new Complex (2,26);
      Complex result = cp.times(cp2);
      assertEquals (expResult, result);
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }

   /**
    * Test of conjugate method, of class Complex.
    */
   @Test
   public void testConjugate()
   {
      System.out.println("conjugate");
      Complex cp = new Complex (7,7);
      Complex cp2 = new Complex (7,-7);
      Complex result = cp.conjugate(cp);
      assertEquals(result,cp2);
      result = cp2.conjugate(cp2);
      assertEquals(result,cp);
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }

   /**
    * Test of equals method, of class Complex.
    */
   @Test
   public void testEquals()
   {
      System.out.println("equals");
      Complex cp = new Complex (7,7);
      Complex cp2 = new Complex (1,1);
      Complex cp3 = new Complex (7,7);
      assertTrue(cp.equals(cp3));
      assertFalse(cp.equals(cp2));
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }

   /**
    * Test of toString method, of class Complex.
    */
   @Test
   public void testToString()
   {
      System.out.println("toString");
      Complex cp = new Complex (7,7);
      Complex cp2 = new Complex (7,1);
      Complex cp3 = new Complex (7);
      Complex cp4 = new Complex (7,-1);
      Complex cp5 = new Complex (7,-7);
      Complex cp6 = new Complex (0,7);
      Complex cp7 = new Complex (0,1);
      Complex cp8 = new Complex (0,0);
      Complex cp9 = new Complex (0,-1);
      Complex cp10 = new Complex (0,-7);
      Complex cp11 = new Complex (-7,7);
      Complex cp12 = new Complex (-7,1);
      Complex cp13 = new Complex (-7,0);
      Complex cp14 = new Complex (-7,-1);
      Complex cp15 = new Complex (-7,-7);
      System.out.println(cp.toString());
      System.out.println(cp2.toString());
      System.out.println(cp3.toString());
      System.out.println(cp4.toString());
      System.out.println(cp5.toString());
      System.out.println(cp6.toString());
      System.out.println(cp7.toString());
      System.out.println(cp8.toString());
      System.out.println(cp9.toString());
      System.out.println(cp10.toString());
      System.out.println(cp11.toString());
      System.out.println(cp12.toString());
      System.out.println(cp13.toString());
      System.out.println(cp14.toString());
      System.out.println(cp15.toString());
      // TODO review the generated test code and remove the default call to fail.
      //fail("The test case is a prototype.");
   }
   
}
