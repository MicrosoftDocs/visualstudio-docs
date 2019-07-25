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

 

**When:** You want to quickly add null checks for all applicable method parameters.

 

**Why:** Writing null checks for many parameters can be time-consuming and repetitive. Using this refactoring is quick and makes the program more robust. 

 

## How-to 



1. Place your cursor on any parameter within the method. Press **Ctrl**+**.** to trigger the **Quick Actions and Refactorings** menu.
   ![Quick actions and refactorings](media/add-null-checks-for-all-parameters.png)

2. Select the option to **Add null checks for all parameters**. 
   ![Add null checks for all](media/add-null-checks-for-all.png.png)

 

## See also 

 

- [Refactoring](../refactoring-in-visual-studio.md) 
