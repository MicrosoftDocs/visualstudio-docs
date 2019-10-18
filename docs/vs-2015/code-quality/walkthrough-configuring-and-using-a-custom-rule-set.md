---
title: "Walkthrough: Configuring and Using a Custom Rule Set | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
helpviewer_keywords:
  - "code analysis, walkthroughs"
  - "code analysis, rule sets"
ms.assetid: 7fe0a4e3-1ce0-4f38-a87a-7d81238ec7cd
caps.latest.revision: 42
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Walkthrough: Configuring and Using a Custom Rule Set
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough shows how to use code analysis tools that have been configured to use a customized *rule set* on a class library. You can select a rule set that relates to the project type that you specified for your solution, or you can select alternative rule sets to fulfill a specific need such as scanning legacy code for issues that can be fixed in a nonbreaking way. In either case, the rule sets can also be customized to fine tune them to your project requirements.

 In this walkthrough, you will step through these processes:

- Create a class library.

- Select the **Microsoft Basic Design Guideline Rules** Code Analysis rule set.

- Add your own code to the class.

- Run Code Analysis.

- Customize the rule set.

- Run Code Analysis and see how the rule set customization behavior works.

## Prerequisites

- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], or [!INCLUDE[vsPro](../includes/vspro-md.md)]

## Using Rule Sets with Code Analysis
 First, create a simple class library.

#### Create a class library

1. On the **File** menu, click **New** and then click **Project**.

2. In the **New Project** dialog box, under **Project Types**, click **Visual C#**.

3. Under **Visual C#**, select **Class Library**.

4. In the **Name** text box, type **RuleSetSample** and then click **OK**.

   Next, you will select the **Microsoft Basic Design Guideline Rules** rule set and save it with your project.

#### Select a code analysis rule set

1. On the **Analyze** menu, click **Configure Code Analysis for RuleSetSample**.

    The configuration settings for Code Analysis appear.

2. In the **Run this rule set** drop-down list, select **Microsoft All Rules**.

    For more information about the available rule sets, see [Code analysis rule set reference](../code-quality/code-analysis-rule-set-reference.md).

    On the File menu, click **Save Selected Items** to update the project file with information about the rule set that you selected and its settings.

   > [!TIP]
   > In a real-world situation, a good practice to use for prioritizing which issues you want to target with code analysis is to start with the **Minimum Recommended Rules** rule set and correct the desired issues, and then incrementally add more rules or rule sets to find and correct the additional issues.

   Next, you will add some code to the class library which will be used to demonstrate violations of the CA1704 "Identifiers should be spelled correctly" Code Analysis rule. For more information, see [CA1704: Identifiers should be spelled correctly](../code-quality/ca1704-identifiers-should-be-spelled-correctly.md).

#### Add your own code

- In Solution Explorer, open the Class1.cs file and replace the existing code with the following:

  ```
  using System;
  using System.Collections.Generic;
  using System.Text;

  namespace RuleSetSample
  {
      public class Class1
      {
          //The variable parameter names "a" and "b" will cause
          //the warning CA 1704 Microsoft.Naming "Consider
          //providing a more meaningful name" to fire
          public int AddIntegers(int a, int b)
          {

              int sum = a + b;

              return (sum);
          }
      }
  }

  ```

  Now you can run Code Analysis on the RuleSetSample project and look for any errors and warnings generated in the Error List window.

#### Run Code Analysis on the RuleSetSample project

1. On the **Analyze** menu, click **Run Code Analysis on RuleSetSample**.

2. In the Error List window, click **Warnings** and then click the **Description** column header to sort the warnings alphanumerically.

    In a real-world application, you would fix any rule violations worth fixing at this point, or optionally turn off or suppress a rule if you determined that it was not worth fixing. For more information, see [Suppress Warnings By Using the SuppressMessage Attribute](../code-quality/suppress-warnings-by-using-the-suppressmessage-attribute.md).

3. Notice the CA1704 warnings. These violations on this rule indicate that you should " Consider providing a more meaningful name for the parameters." You could correct the issue in your code or you can disable the rule, as explained in the next procedure.

   Next, you will customize the rule set to exclude the CA1704 warning, " Identifiers should be spelled correctly".

#### Customize the rule set for your project to disable a specific rule

1. On the **Analyze** menu, click **Configure Code Analysis for RuleSetSample**.

2. In the **Run this rule set** drop-down list, verify that the **Microsoft All Rules** rule set is still highlighted and then click **Open**. The rule set page is displayed.

3. Expand the Microsoft.Naming category node, and then select the CA1704 warning.

4. Under the **Action** column, select **None.** This prevents CA1704 from displaying as an warning or error in the Error List window.

    Now would be a good time to experiment with the various toolbar buttons and filtering options to become familiar with them. For example, you can use the **Group By** drop-down list to help in locating a specific rule, or category of rules. Another example is that you can use the **Hide Disabled Rules** button in the rule set pages toolbar to hide or show all the rules with the **Action** column set to **None**. This can be useful if you want to scan for any rules that you have turned off to verify that you still want to have them disabled.

5. On the View menu, click Properties Window. Type **My Custom Rule Set** in the Name box of the Properties tool window. This changes the display name of the new rule set in the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] IDE.

6. On the **File** menu, click **Save Microsoft All Rules.ruleset** to save your customized rule set. Navigate to the root folder of your project. In **the FileName** text box, type **MyCustomRuleSet**. The custom rule set can now be selected for use with your project.

   With your new rule set created, now you have to configure your project settings to specify that you want to use your new rule set with it.

#### Specify the new rule set for use with your project

1. In Solution Explorer, right-click the project and then select **Properties**.

2. In the **Properties** tab, click **Code Analysis**.

    In the **Run this rule set** drop-down list, click **\<Browse..>**. Navigate to the root folder of your code project and then select **MyCustomRuleSet.ruleset**. This is the new rule set that you created in the previous procedure.

3. On the **File** menu, click **Save** to save your project configuration. The custom rule set can now be used with your project.

   Finally, you will run Code Analysis again using your MyCustomRuleSet rule set. Notice that the Error List window does not display the CA1704 performance rule violation.

#### Run Code Analysis on the RuleSetSample project for the second time

1. On the **Analyze** menu, click **Run Code Analysis on RuleSetSample**.

2. In the Error List window, notice that when you click **Warnings**, you no longer see the CA1704 warning violations for the "Identifiers should be spelled correctly" rule.

## See Also
 [How to: Configure Code Analysis for a Managed Code Project](../code-quality/how-to-configure-code-analysis-for-a-managed-code-project.md)
 [Code analysis rule set reference](../code-quality/code-analysis-rule-set-reference.md)
