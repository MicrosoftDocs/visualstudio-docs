---
title: "Using Rule Sets to Specify the C++ Rules to Run | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
ms.assetid: ac3877e6-5349-4c03-9541-3d5be259f1e8
caps.latest.revision: 7
author: mikeblome
ms.author: mblome
manager: jillfra
---
# Using Rule Sets to Specify the C++ Rules to Run
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In [!INCLUDE[vsPreShort](../includes/vspreshort-md.md)] and [!INCLUDE[vsUltShort](../includes/vsultshort-md.md)], you can create and modify a custom *rule set* to meet specific project needs associated with code analysis. To create a custom C++ rule set, a C/C++ project must be open in the Visual Studio IDE. You then open a standard rule set in the rule set editor and then add or remove specific rules and optionally change the action that occurs when code analysis determines that a rule has been violated.  
  
 To create a new custom rule set, you save it by using a new file name. The custom rule set is automatically assigned to the project.  
  
## Opening the rule set editor  
  
#### To create a custom rule from a single existing rule set  
  
1. In Solution Explorer, open the shortcut menu for the project and then choose **Properties**.  
  
2. On the **Properties** tab, choose **Code Analysis**.  
  
3. In the **Rule Set** drop-down list, do one of the following:  
  
   - Choose the rule set that you want to customize.  
  
     \- or -  
  
   - Choose **\<Browse...>** to specify an existing rule set that is not in the list.  
  
4. Choose **Open** to display the rules in the rule set editor.  
  
#### To modify a rule set in the rule set editor  
  
- To change the display name of the rule set, on the **View** menu, choose **Properties Window**. Enter the display name in the **Name** box. Notice that the display name can differ from the file name.  
  
- To add all the rules of the group to a custom rule set, select the check box of the group. To remove all the rules of the group, clear the check box.  
  
- To add a specific rule to the custom rule set, select the check box of the rule. To remove the rule from the rule set, clear the check box.  
  
- To change the action taken when a rule is violated in a code analysis, choose the **Action** field for the rule and then choose one of the following values:  
  
     **Warn** - generates a warning.  
  
     **Error** - generates an error.  
  
     **None** - disables the rule. This action is the same as removing the rule from the rule set.  
  
#### To group, filter, or change the fields in the rule set editor by using the rule set editor toolbar  
  
- To expand the rules in all groups, choose **Expand All**.  
  
- To collapse the rules in all groups, choose **Collapse All**.  
  
- To change the field that rules are grouped by, choose the field from the **Group By** list. To display the rules ungrouped, choose **\<None>**.  
  
- To add or remove fields in rule columns, choose **Column Options**.  
  
- To hide rules that do not apply to the current solution, choose **Hide rules that do not apply to the current solution**.  
  
- To switch between showing and hiding rules that are assigned the Error action, choose **Show rules that can generate Code Analysis errors**.  
  
- To switch between showing and hiding rules that are assigned the Warning action, choose **Show rules that can generate Code Analysis warnings**.  
  
- To switch between showing and hiding rules that are assigned the **None** action, choose **Show rules that are not enabled**.  
  
- To add or remove Microsoft default rule sets to the current rule set, choose **Add or remove child rule sets**.
