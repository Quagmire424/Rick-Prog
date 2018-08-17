
/**
 GUI that user interacts with for banking details
 */
import javax.swing.*;
import java.io.*;
import java.util.*;
import java.util.logging.Level;
import java.util.logging.Logger;
import jdk.nashorn.internal.parser.TokenType;

public class TransactionManager extends javax.swing.JFrame
{

   ButtonGroup accountType;
   BankDatabase db;
   Account account;
   Vector list = new Vector<Account>();
   String line;
   Date checkDate;

   /**
    Creates new form TransactionManager
    */
   public TransactionManager()
   {
      initComponents();
      accountType = new ButtonGroup();
      addRadio();
      db = new BankDatabase();
      list = new Vector();
   }

   /**
    Creates radio buttons for checking, savings, and money market accounts
    */
   private void addRadio()
   {
      accountType.add(radCheck);
      accountType.add(radSav);
      accountType.add(radMM);
   }

   /**
    Adds an account based on which account type radio button is selected.
    Displays error message if account already exist or a success message when
    a new account is created. Clears entered fields once message box is closed

    @param newName, name of owner for account to be created
    @param newPhone, phone number associated with account
    */
   private void addAccount(String newName, String newPhone)
   {
      if (radPosition())
      {
         if (radCheck.isSelected())
         {
            account = new Checking(newName, newPhone, deposit.isSelected());
         }
         else if (radSav.isSelected())
         {
            account = new Savings(newName, newPhone, specialSav.isSelected());
         }
         else if (radMM.isSelected())
         {
            account = new MoneyMarket(newName, newPhone);
         }
         if (db.contains(account))
         {
            JOptionPane.showMessageDialog(this, "\"" + newName + " "
                  + newPhone + "\"" + " already has " + "an account", "Unsuccessful Add", JOptionPane.ERROR_MESSAGE);
         }
         else
         {
            db.add(account);
            list.add(account);
            accList.setListData(list);
            JOptionPane.showMessageDialog(this, "Account " + "\"" + newName
                  + " " + newPhone + "\"" + " successfully" + " opened!",
                  "Successful Add", JOptionPane.INFORMATION_MESSAGE);
            clear();
         }
      }
   }

   /**
    Clears entered text fields, radio buttons, and check boxes
    */
   private void clear()
   {
      name.setText("");
      phone.setText("");
      accountType.clearSelection();
      deposit.setSelected(false);
      specialSav.setSelected(false);
      openBeforeTxt.setText("");
   }

   /**
    Checks to see if any radio button is selected for an account type and
    displays an error message if none is selected.

    @return true, if an account type has been selected
    @return false, if an account type has not been selected
    */
   private boolean radPosition()
   {
      if (!radCheck.isSelected() && !radSav.isSelected()
            && !radMM.isSelected())
      {
         JOptionPane.showMessageDialog(this, "Please select an account type",
               "Error Message", JOptionPane.ERROR_MESSAGE);
         return false;
      }
      return true;
   }

   /**
    Checks to see if a name and phone is valid to create an account. Displays
    an error message when both or one are not valid

    @param newPhone, phone number associated with account
    @param newName, name of account owner
    @return true, if both a name and phone number are valid
    @return false, if a name, phone number or both are invalid
    */
   private boolean check(String newPhone, String newName)
   {
      if (!isInteger(newPhone))
      {
         JOptionPane.showMessageDialog(this, "Please enter a valid phone "
               + "number!",
               "Error Message", JOptionPane.ERROR_MESSAGE);
         phone.setText("");
         return false;
      }
      if (!isName(newName))
      {
         JOptionPane.showMessageDialog(this, "Please enter a valid name ",
               "Error Message", JOptionPane.ERROR_MESSAGE);
         name.setText("");
         return false;
      }

      return true;
   }

   /**
    Makes sure name entered is a string of letters

    @param input, name to be checked
    @return true, if string is made of letters
    @return false, if string is not made of letters
    */
   private boolean isName(String input)
   {
      try
      {
         Integer.parseInt(input);
         return false;
      }
      catch (NumberFormatException e)
      {
         return true;
      }
   }

   private void grabFile() throws IOException
   {
      try
      {
         BufferedReader input = new BufferedReader(new FileReader("Prog6_1.in"));

         boolean eof = false;
         String special = "";

         while (!eof)
         {
            line = input.readLine();
            if (line == null)
            {
               eof = true;
            }
            else
            {
               StringTokenizer st = new StringTokenizer(line, ",");
               String accType = st.nextToken();
               String name = st.nextToken();
               String phone = st.nextToken();
               Double balance = Double.parseDouble(st.nextToken());
               String openDate = st.nextToken();
               if (st.hasMoreTokens())
               {
                  special = st.nextToken();
               }

               addFromFile(accType, name, phone, balance, openDate, special);
            }
         }
      }
      catch (FileNotFoundException ex)
      {
         JOptionPane.showMessageDialog(this, "No file found!",
               "Error Message", JOptionPane.ERROR_MESSAGE);
      }
   }

   private void addFromFile(String accType, String name, String phone,
         Double balance, String openDate, String special)
   {
      boolean status = false;
      int with;
      switch (accType)
      {
         case "C":
            if (special.startsWith("t"))
            {
               status = true;
            }
            account = new Checking(name, phone, openDate, balance, status);
            break;
         case "S":
            if (special.startsWith("t"))
            {
               status = true;
            }
            account = new Savings(name, phone, openDate, balance, status);
            break;
         case "M":
            with = Integer.parseInt(special);
            account = new MoneyMarket(name, phone, openDate, balance, with);
            break;
      }
      db.add(account);
      list.add(account);
   }

   /**
    Makes sure a phone number entered is a string of integers

    @param input, phone number to be checked
    @return true, if string is made of integers
    @return false, if string is not made of integers
    */
   private boolean isInteger(String input)
   {
      try
      {
         Integer.parseInt(input);
         return true;
      }
      catch (NumberFormatException e)
      {
         return false;
      }
   }

   private void messBadAmount()
   {
      JOptionPane.showMessageDialog(this, "Invalid amount!",
            "Amount Message", JOptionPane.ERROR_MESSAGE);
   }

   private void messNoAccSelect()
   {
      JOptionPane.showMessageDialog(this, "No account selected",
            "Accounts Message", JOptionPane.ERROR_MESSAGE);
   }

   private void messEmptyDatabase()
   {
      JOptionPane.showMessageDialog(this, "No accounts in database",
            "Accounts Message", JOptionPane.ERROR_MESSAGE);
   }

   private void messAccRemove()
   {
      JOptionPane.showMessageDialog(this, "Account removed!",
            "Close Message", JOptionPane.INFORMATION_MESSAGE);
   }

   /**
    This method is called from within the constructor to initialize the form.
    WARNING: Do NOT modify this code. The content of this method is always
    regenerated by the Form Editor.
    */
   @SuppressWarnings("unchecked")
   // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
   private void initComponents()
   {

      jPanel1 = new javax.swing.JPanel();
      jLabel1 = new javax.swing.JLabel();
      jLabel2 = new javax.swing.JLabel();
      name = new javax.swing.JTextField();
      phone = new javax.swing.JTextField();
      jPanel2 = new javax.swing.JPanel();
      radCheck = new javax.swing.JRadioButton();
      deposit = new javax.swing.JCheckBox();
      radSav = new javax.swing.JRadioButton();
      specialSav = new javax.swing.JCheckBox();
      radMM = new javax.swing.JRadioButton();
      open = new javax.swing.JButton();
      close = new javax.swing.JButton();
      withdrawCash = new javax.swing.JButton();
      depositCash = new javax.swing.JButton();
      loadFile = new javax.swing.JButton();
      runInterest = new javax.swing.JButton();
      jScrollPane1 = new javax.swing.JScrollPane();
      bankInfo = new javax.swing.JTextArea();
      accOpenedBefore = new javax.swing.JButton();
      openBeforeTxt = new javax.swing.JTextField();
      jLabel7 = new javax.swing.JLabel();
      jScrollPane2 = new javax.swing.JScrollPane();
      accList = new javax.swing.JList();

      setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
      setTitle("Transaction Manager");

      jPanel1.setBorder(javax.swing.BorderFactory.createEtchedBorder());

      jLabel1.setText("Name");

      jLabel2.setText("Phone");

      javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
      jPanel1.setLayout(jPanel1Layout);
      jPanel1Layout.setHorizontalGroup(
         jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(jPanel1Layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addGroup(jPanel1Layout.createSequentialGroup()
                  .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(name, javax.swing.GroupLayout.PREFERRED_SIZE, 260, javax.swing.GroupLayout.PREFERRED_SIZE))
               .addGroup(jPanel1Layout.createSequentialGroup()
                  .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, 70, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                  .addComponent(phone)))
            .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
      );
      jPanel1Layout.setVerticalGroup(
         jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(jPanel1Layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(jLabel1)
               .addComponent(name, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addGap(28, 28, 28)
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(jLabel2)
               .addComponent(phone, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addContainerGap(23, Short.MAX_VALUE))
      );

      jPanel2.setBorder(javax.swing.BorderFactory.createEtchedBorder());

      radCheck.setText("Checking");
      radCheck.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            radCheckActionPerformed(evt);
         }
      });

      deposit.setText("Direct Deposit");

      radSav.setText("Savings");
      radSav.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            radSavActionPerformed(evt);
         }
      });

      specialSav.setText("Special Savings Account");

      radMM.setText("Money Market");
      radMM.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            radMMActionPerformed(evt);
         }
      });

      javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
      jPanel2.setLayout(jPanel2Layout);
      jPanel2Layout.setHorizontalGroup(
         jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(jPanel2Layout.createSequentialGroup()
            .addGap(28, 28, 28)
            .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(radMM)
               .addGroup(jPanel2Layout.createSequentialGroup()
                  .addComponent(radSav, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGap(18, 18, 18)
                  .addComponent(specialSav))
               .addGroup(jPanel2Layout.createSequentialGroup()
                  .addComponent(radCheck, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                  .addGap(18, 18, 18)
                  .addComponent(deposit)))
            .addContainerGap(61, Short.MAX_VALUE))
      );
      jPanel2Layout.setVerticalGroup(
         jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(jPanel2Layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(radCheck)
               .addComponent(deposit))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
            .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
               .addComponent(specialSav)
               .addComponent(radSav))
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
            .addComponent(radMM)
            .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
      );

      open.setText("Open New");
      open.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            openActionPerformed(evt);
         }
      });

      close.setText("Close Existing");
      close.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            closeActionPerformed(evt);
         }
      });

      withdrawCash.setText("Withdraw");
      withdrawCash.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            withdrawCashActionPerformed(evt);
         }
      });

      depositCash.setText("Deposit");
      depositCash.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            depositCashActionPerformed(evt);
         }
      });

      loadFile.setText("Load Accounts");
      loadFile.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            loadFileActionPerformed(evt);
         }
      });

      runInterest.setText("Run Monthly Interest and Fee");
      runInterest.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            runInterestActionPerformed(evt);
         }
      });

      bankInfo.setColumns(20);
      bankInfo.setRows(5);
      jScrollPane1.setViewportView(bankInfo);

      accOpenedBefore.setText("List Accounts Opened Before");
      accOpenedBefore.addActionListener(new java.awt.event.ActionListener()
      {
         public void actionPerformed(java.awt.event.ActionEvent evt)
         {
            accOpenedBeforeActionPerformed(evt);
         }
      });

      jLabel7.setText("List of Accounts");

      jScrollPane2.setViewportView(accList);

      javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
      getContentPane().setLayout(layout);
      layout.setHorizontalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addContainerGap()
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
               .addComponent(jScrollPane1)
               .addComponent(jScrollPane2, javax.swing.GroupLayout.Alignment.LEADING)
               .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                  .addComponent(jLabel7)
                  .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                     .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                           .addGroup(layout.createSequentialGroup()
                              .addComponent(open, javax.swing.GroupLayout.PREFERRED_SIZE, 160, javax.swing.GroupLayout.PREFERRED_SIZE)
                              .addGap(41, 41, 41)
                              .addComponent(close, javax.swing.GroupLayout.PREFERRED_SIZE, 160, javax.swing.GroupLayout.PREFERRED_SIZE))
                           .addComponent(loadFile, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                           .addGroup(layout.createSequentialGroup()
                              .addComponent(depositCash, javax.swing.GroupLayout.PREFERRED_SIZE, 160, javax.swing.GroupLayout.PREFERRED_SIZE)
                              .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                              .addComponent(withdrawCash, javax.swing.GroupLayout.PREFERRED_SIZE, 160, javax.swing.GroupLayout.PREFERRED_SIZE))
                           .addComponent(runInterest, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                     .addGroup(layout.createSequentialGroup()
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                  .addGroup(layout.createSequentialGroup()
                     .addComponent(accOpenedBefore, javax.swing.GroupLayout.PREFERRED_SIZE, 183, javax.swing.GroupLayout.PREFERRED_SIZE)
                     .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                     .addComponent(openBeforeTxt, javax.swing.GroupLayout.PREFERRED_SIZE, 172, javax.swing.GroupLayout.PREFERRED_SIZE))))
            .addContainerGap(34, Short.MAX_VALUE))
      );
      layout.setVerticalGroup(
         layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
         .addGroup(layout.createSequentialGroup()
            .addGap(32, 32, 32)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
               .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGap(36, 36, 36)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(open)
               .addComponent(close)
               .addComponent(depositCash)
               .addComponent(withdrawCash))
            .addGap(18, 18, 18)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
               .addComponent(loadFile, javax.swing.GroupLayout.DEFAULT_SIZE, 39, Short.MAX_VALUE)
               .addComponent(runInterest, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGap(18, 18, 18)
            .addComponent(jLabel7)
            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
            .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
            .addGap(19, 19, 19)
            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
               .addComponent(accOpenedBefore)
               .addComponent(openBeforeTxt, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addGap(18, 18, 18)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 159, Short.MAX_VALUE)
            .addContainerGap())
      );

      pack();
   }// </editor-fold>//GEN-END:initComponents

   /**
    Open action button that adds an account by calling addAccount() if valid
    information is given. Displays error message(s) if a name or phone number
    are not entered.

    @param evt
    */
   private void openActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_openActionPerformed
   {//GEN-HEADEREND:event_openActionPerformed
      String newName = name.getText();
      String newPhone = phone.getText();

      if (newName.isEmpty())
      {
         JOptionPane.showMessageDialog(this, "No name entered!",
               "Error Message", JOptionPane.ERROR_MESSAGE);
      }
      if (newPhone.isEmpty())
      {
         JOptionPane.showMessageDialog(this, "No phone number entered!",
               "Error Message", JOptionPane.ERROR_MESSAGE);
      }
      if (!newName.isEmpty() && !newPhone.isEmpty())
      {
         if (check(newPhone, newName) && radPosition())
         {
            addAccount(newName, newPhone);
         }
      }
   }//GEN-LAST:event_openActionPerformed

   /**
    Closes an account if entered name and phone number exist. Displays error
    message if no accounts are opened, if a name and/or phone number are not
    entered, or if the account doesn't exist. Displays a success message once
    the account is closed. Calls clear() when a message box is closed

    @param evt
    */
   private void closeActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_closeActionPerformed
   {//GEN-HEADEREND:event_closeActionPerformed
      String newName = name.getText();
      String newPhone = phone.getText();
      account = new MoneyMarket(newName, newPhone);
      if (db.size() < 1)
      {
         messEmptyDatabase();
      }
      else if (!accList.isSelectionEmpty())
      {
         String selected = accList.getSelectedValue().toString();
         StringTokenizer st = new StringTokenizer(selected, "***");
         String temp = st.nextToken();
         Integer accNum = Integer.parseInt(st.nextToken());
         db.remove(accNum);
         list.remove(accList.getSelectedIndex());
         bankInfo.append(String.valueOf(db.size()) + "\n");
         messAccRemove();
      }
      else if (!newName.isEmpty() && !newPhone.isEmpty())
      {
         db.remove(account);
         list.remove(account);
         messAccRemove();
      }
      else
      {
         JOptionPane.showMessageDialog(this, "Select account\n or\n Enter "
               + "name and phone of an account",
               "Error Message", JOptionPane.ERROR_MESSAGE);
      }
      if (db.size() < 1)
      {
         list.clear();
      }
      accList.setListData(list);
      clear();
   }//GEN-LAST:event_closeActionPerformed

   /**
    Show all accounts action button, displays all current accounts to text
    area

    @param evt
    */
   private void loadFileActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_loadFileActionPerformed
   {//GEN-HEADEREND:event_loadFileActionPerformed
      try
      {
         grabFile();
         accList.setListData(list);
         JOptionPane.showMessageDialog(this, "Accounts loaded!",
               "Successful Add", JOptionPane.INFORMATION_MESSAGE);
      }
      catch (IOException e)
      {
         JOptionPane.showMessageDialog(this, "File Empty!",
               "Error Message", JOptionPane.ERROR_MESSAGE);
      }
   }//GEN-LAST:event_loadFileActionPerformed

   /**
    If checking radio button is checked, sets deposit status to true and
    special savings status to false

    @param evt
    */
   private void radCheckActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_radCheckActionPerformed
   {//GEN-HEADEREND:event_radCheckActionPerformed
      deposit.setEnabled(true);
      specialSav.setEnabled(false);
      specialSav.setSelected(false);
   }//GEN-LAST:event_radCheckActionPerformed

   /**
    If savings radio button is , sets specialsav status to true and deposit
    status to false

    @param evt
    */
   private void radSavActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_radSavActionPerformed
   {//GEN-HEADEREND:event_radSavActionPerformed
      specialSav.setEnabled(true);
      deposit.setEnabled(false);
      deposit.setSelected(false);
   }//GEN-LAST:event_radSavActionPerformed

   /**
    If money market radio button is checked, sets specialSav and deposit
    statues to false

    @param evt
    */
   private void radMMActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_radMMActionPerformed
   {//GEN-HEADEREND:event_radMMActionPerformed
      specialSav.setEnabled(false);
      deposit.setEnabled(false);
      specialSav.setSelected(false);
      deposit.setSelected(false);
   }//GEN-LAST:event_radMMActionPerformed

   private void depositCashActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_depositCashActionPerformed
   {//GEN-HEADEREND:event_depositCashActionPerformed
      if (db.isEmpty())
      {
         messEmptyDatabase();
      }
      else
      {
         if (accList.isSelectionEmpty())
         {
            messNoAccSelect();
         }
         else
         {
            String selected = accList.getSelectedValue().toString();
            StringTokenizer st = new StringTokenizer(selected, "***");
            String temp = st.nextToken();
            Integer accNum = Integer.parseInt(st.nextToken());
            try
            {
               int dep = Integer.parseInt(JOptionPane.showInputDialog("How much would you like to deposit?"));
               if (dep < 0)
               {
                  messBadAmount();
               }
               else
               {
                  int i = accList.getSelectedIndex();
                  list.set(i, db.deposit(accNum, dep));
                  accList.setListData(list);
               }

            }
            catch (NumberFormatException e)
            {
               messBadAmount();
            }
         }
      }
   }//GEN-LAST:event_depositCashActionPerformed

   private void withdrawCashActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_withdrawCashActionPerformed
   {//GEN-HEADEREND:event_withdrawCashActionPerformed
      if (db.isEmpty())
      {
         messEmptyDatabase();
      }
      else
      {
         if (accList.isSelectionEmpty())
         {
            messNoAccSelect();
         }
         else
         {
            String selected = accList.getSelectedValue().toString();
            StringTokenizer st = new StringTokenizer(selected, "***");
            String temp = st.nextToken();
            Integer accNum = Integer.parseInt(st.nextToken());
            try
            {
               int with = Integer.parseInt(JOptionPane.showInputDialog("How"
                     + " much would you like to withdraw?"));
               if (with < 0 || with > db.getAcctBal(accNum))
               {
                  messBadAmount();
               }
               else
               {
                  list.set(accList.getSelectedIndex(),
                        db.withdraw(accNum, with));

                  accList.setListData(list);
               }
            }
            catch (NumberFormatException e)
            {
               messBadAmount();
            }
         }
      }
   }//GEN-LAST:event_withdrawCashActionPerformed

   private void runInterestActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_runInterestActionPerformed
   {//GEN-HEADEREND:event_runInterestActionPerformed
      if (db.isEmpty())
      {
         messEmptyDatabase();
      }
      else
      {
         db.runInterest();
         accList.setListData(list);
      }
   }//GEN-LAST:event_runInterestActionPerformed

   private void accOpenedBeforeActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_accOpenedBeforeActionPerformed
   {//GEN-HEADEREND:event_accOpenedBeforeActionPerformed
      try
      {
         checkDate = new Date(openBeforeTxt.getText());
         int j = 0;
         if (checkDate.isValid())
         {
            bankInfo.setText("");
            for (int i = 0; i < db.size(); i++)
            {
               Date d = db.getStartDate(i);
               // compare d to checkDate
               j = d.compareTo(checkDate);
               // if comparing returns -1
               if (j == -1)
               {
                  bankInfo.append(db.toStringDate(i) + "\n");
               }
            }
         }
         else
         {
            JOptionPane.showMessageDialog(this, "Enter valid date!",
                  "Date Message", JOptionPane.INFORMATION_MESSAGE);
            clear();
         }
      }
      catch (Exception e)
      {
         JOptionPane.showMessageDialog(this, "Enter valid date!",
               "Date Message", JOptionPane.INFORMATION_MESSAGE);
         clear();
      }


   }//GEN-LAST:event_accOpenedBeforeActionPerformed

   /**
    Displays TransactionManager gui

    @param args the command line arguments
    */
   public static void main(String args[])
   {
      /* Set the Nimbus look and feel */
      //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
       * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
       */
      try
      {
         for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels())
         {
            if ("Nimbus".equals(info.getName()))
            {
               javax.swing.UIManager.setLookAndFeel(info.getClassName());
               break;

            }
         }
      }
      catch (ClassNotFoundException ex)
      {
         java.util.logging.Logger.getLogger(TransactionManager.class
               .getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }

      catch (InstantiationException ex)
      {
         java.util.logging.Logger.getLogger(TransactionManager.class
               .getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }

      catch (IllegalAccessException ex)
      {
         java.util.logging.Logger.getLogger(TransactionManager.class
               .getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }

      catch (javax.swing.UnsupportedLookAndFeelException ex)
      {
         java.util.logging.Logger.getLogger(TransactionManager.class
               .getName()).log(java.util.logging.Level.SEVERE, null, ex);
      }
      //</editor-fold>

      /* Create and display the form */
      java.awt.EventQueue.invokeLater(new Runnable()
      {
         public void run()
         {
            new TransactionManager().setVisible(true);
         }
      });
   }

   // Variables declaration - do not modify//GEN-BEGIN:variables
   private javax.swing.JList accList;
   private javax.swing.JButton accOpenedBefore;
   private javax.swing.JTextArea bankInfo;
   private javax.swing.JButton close;
   private javax.swing.JCheckBox deposit;
   private javax.swing.JButton depositCash;
   private javax.swing.JLabel jLabel1;
   private javax.swing.JLabel jLabel2;
   private javax.swing.JLabel jLabel7;
   private javax.swing.JPanel jPanel1;
   private javax.swing.JPanel jPanel2;
   private javax.swing.JScrollPane jScrollPane1;
   private javax.swing.JScrollPane jScrollPane2;
   private javax.swing.JButton loadFile;
   private javax.swing.JTextField name;
   private javax.swing.JButton open;
   private javax.swing.JTextField openBeforeTxt;
   private javax.swing.JTextField phone;
   private javax.swing.JRadioButton radCheck;
   private javax.swing.JRadioButton radMM;
   private javax.swing.JRadioButton radSav;
   private javax.swing.JButton runInterest;
   private javax.swing.JCheckBox specialSav;
   private javax.swing.JButton withdrawCash;
   // End of variables declaration//GEN-END:variables
}
