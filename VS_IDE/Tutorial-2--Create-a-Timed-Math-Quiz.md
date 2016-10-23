---
title: "Tutorial 2: Create a Timed Math Quiz"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d7165d08-ace3-457d-b57d-fb8f80760a6f
caps.latest.revision: 17
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Tutorial 2: Create a Timed Math Quiz
In this tutorial, you build a quiz in which the quiz taker must answer four random arithmetic problems within a specified time. You learn how to:  
  
-   Generate random numbers by using the `Random` class.  
  
-   Trigger events to occur at a specific time by using a **Timer** control.  
  
-   Control program flow by using `if else` statements.  
  
-   Perform basic arithmetic operations in code.  
  
 When you finish, your quiz will look like the following picture, except with different numbers.  
  
 ![Math quiz with four problems](../VS_IDE/media/Express_FinishedQuiz.png "Express_FinishedQuiz")  
Quiz that you create in this tutorial  
  
 To download a completed version of the quiz, see [Complete Math Quiz tutorial sample](http://code.msdn.microsoft.com/Complete-Math-Quiz-8581813c).  
  
> [!NOTE]
>  This tutorial covers both Visual C# and Visual Basic, so focus on the information that's specific to the programming language that you're using.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Step 1: Create a Project and Add Labels to Your Form](../VS_IDE/Step-1--Create-a-Project-and-Add-Labels-to-Your-Form.md)|Start by creating the project, changing properties, and adding `Label` controls.|  
|[Step 2: Create a Random Addition Problem](../VS_IDE/Step-2--Create-a-Random-Addition-Problem.md)|Create an addition problem, and use the `Random` class to generate random numbers.|  
|[Step 3: Add a Countdown Timer](../VS_IDE/Step-3--Add-a-Countdown-Timer.md)|Add a countdown timer so that the quiz can be timed.|  
|[Step 4: Add the CheckTheAnswer() Method](../VS_IDE/Step-4--Add-the-CheckTheAnswer---Method.md)|Add a method to check whether the quiz taker entered a correct answer for the problem.|  
|[Step 5: Add Enter Event Handlers for the NumericUpDown Controls](../VS_IDE/Step-5--Add-Enter-Event-Handlers-for-the-NumericUpDown-Controls.md)|Add event handlers that make your quiz easier to take.|  
|[Step 6: Add a Subtraction Problem](../VS_IDE/Step-6--Add-a-Subtraction-Problem.md)|Add a subtraction problem that generates random numbers, uses the timer, and checks for correct answers.|  
|[Step 7: Add Multiplication and Division Problems](../VS_IDE/Step-7--Add-Multiplication-and-Division-Problems.md)|Add multiplication and division problems that generate random numbers, use the timer, and check for correct answers.|  
|[Step 8: Customize the Quiz](../VS_IDE/Step-8--Customize-the-Quiz.md)|Try other features, such as changing colors and adding a hint.|