---
title: "Call Hierarchy | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "VS.CallHierarchy"
helpviewer_keywords:
  - "Call Hierarchy"
ms.assetid: c55bda01-d7de-4823-8f9a-1bcc37dbb74a
caps.latest.revision: 45
author: jillre
ms.author: jillfra
manager: jillfra
---
# Call Hierarchy
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Call Hierarchy enables you to navigate through your code by displaying all calls to and from a selected method, property, or constructor. This enables you to better understand how code flows and to evaluate the effects of changes to code. You can examine several levels of code to view complex chains of method calls and additional entry points to the code, which enables you to explore all possible execution paths.

 Call Hierarchy is available at design time, unlike the call stack that is displayed by the debugger.

## Using Call Hierarchy
 To display the **Call Hierarchy** window, right-click the name of a method, property, or constructor call, and then click **View Call Hierarchy**.

 The member name appears in a tree view pane in the **Call Hierarchy** window. If you expand the member node, **Calls To**_member name_ and **Calls From**_member name_ subnodes appear. The following illustration shows these nodes in the **Call Hierarchy** window.

 ![Call Hierarchy with one node open](../../ide/reference/media/onenode.png "OneNode")
Call Hierarchy window

- If you expand the **Calls To** node, all members that call the selected member are displayed.

- If you expand the **Calls From** node, all members that are called by the selected member are displayed.

  You can then expand each of these subnode members into **Calls To** and **Calls From** nodes. This enables you to navigate into the stack of callers, as shown in the following illustration.

  ![Call Hierarchy Multiple Nodes Open](../../ide/media/multiplenodes.png "MultipleNodes")
  Call Hierarchy window

  For members that are defined as either virtual or abstract, an **Overrides method name** node appears. For interface members, an **Implements method name** node appears. These expandable nodes appear at the same level as the **Calls To** and **Calls From** nodes.

  The **Search Scope** box on the toolbar contains choices for **My Solution**, **Current Project**, and **Current Document**.

  When you select a child member in the **Call Hierarchy** tree view pane:

- The **Call Hierarchy** details pane displays all lines of code in which that child member is called from the parent member.

- The **Code Definition Window**, if open, displays the code for the selected member. This window is available in C# and C++. For more information about this window, see [Viewing the Structure of Code](../../ide/viewing-the-structure-of-code.md).

> [!NOTE]
> Call Hierarchy does not find method group references, which includes places where a method is added as an event handler or is assigned to a delegate. To find all references to a method, you can use the **Find All References** command.

## Shortcut Menu Items
 The following table describes several shortcut menu options that are available when you right-click a node in the tree view pane.

|Context Menu Item|Description|
|-----------------------|-----------------|
|**Add As New Root**|Adds the selected node to the tree view pane as a new root node. This enables you to focus your attention on a specific subtree.|
|**Remove Root**|Removes the selected root node from the tree view pane. This option is available only from a root node.<br /><br /> You can also use the **Remove Root** toolbar button to remove the selected root node.|
|**Go To Definition**|Runs the Go To Definition command on the selected node. This navigates to the original definition for a member call or variable definition.<br /><br /> To run the Go To Definition command, you can also double-click the selected node or press F12 on the selected node.|
|**Find All References**|Runs the Find All References command on the selected node. This finds all the lines of code in your project that reference a class or member.<br /><br /> You can also use SHIFT+F12 to run the Find All References command on the selected node.|
|**Copy**|Copies the contents of the selected node (but not its subnodes).|
|**Refresh**|Collapses the selected node so that re-expanding it displays current information.|
