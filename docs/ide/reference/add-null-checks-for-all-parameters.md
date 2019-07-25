--- 

title: Add null checks for all (parameters) 

ms.date: 07/24/2019 

ms.topic: reference 

author: stcahlon 

ms.author: t-shzach

manager: jillfra 

dev_langs: 

  - CSharp 

ms.workload:  

  - "dotnet" 

--- 

# Add null checks for all parameters 

 

This refactoring applies to: 

 

- C# 

 

**What:** Creates and adds `if` statements that check nullity of all the nullable non-checked parameters. 

 

<<<<<<< HEAD
**When:** You want to quickly add null checks for all applicable parameters.

 

**Why:** Writing null checks for many parameters can be time-consuming and repetitive. Using this refactoring is quick and make the program more robust.
=======
**When:** You want to quickly add null checks for all applicable method parameters.

 

**Why:** Writing null checks for many parameters can be time-consuming and repetitive. Using this refactoring is quick and makes the program more robust. 
>>>>>>> 5a28377617e1dc251ea9ace077892f3db8cc72f5

 

## How-to 



1. Place your cursor on any parameter within the method.
2. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   ![Quick actions and refactorings](media/add-null-checks-for-all-parameters.png)
<<<<<<< HEAD
3. Select the option to **Add null checks for all parameters**. 
   ![Add null checks for all](media/add-null-checks-for-all.png)
=======

3. Select the option to **Add null checks for all parameters**. 
   ![Add null checks for all](media/add-null-checks-for-all.png.png)
>>>>>>> 5a28377617e1dc251ea9ace077892f3db8cc72f5

 

## See also 

 

<<<<<<< HEAD
- [Refactoring](../refactoring-in-visual-studio.md)
=======
- [Refactoring](../refactoring-in-visual-studio.md) 
>>>>>>> 5a28377617e1dc251ea9ace077892f3db8cc72f5
