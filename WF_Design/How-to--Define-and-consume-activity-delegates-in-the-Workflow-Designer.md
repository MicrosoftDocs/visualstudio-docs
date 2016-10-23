---
title: "How to: Define and consume activity delegates in the Workflow Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: c68e42ad-3ec0-4c2d-b104-fe36c6d83b5e
caps.latest.revision: 3
manager: erikre
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Define and consume activity delegates in the Workflow Designer
.NET Framework 4.5 includes a new out-of-box designer for the <xref:System.Activities.Statements.InvokeDelegate?qualifyHint=False> activity. This designer can be used to assign delegates to the activity that derive from <xref:System.Activities.ActivityDelegate?qualifyHint=False>, such as <xref:System.Activities.ActivityAction?qualifyHint=False> or <xref:System.Activities.ActivityFunc`1?qualifyHint=False>.  
  
### Define an activity delegate  
  
1.  In Visual Studio, select **File**, **New**, **Project**. Select the **Workflow** node on the left, and the **Workflow Console Application** template on the right. Name the project (if desired) and click **Ok**.  
  
2.  Right-click on the project in **Solution Explorer** and select **Add**, **New Item…**. Select the **Workflow** node on the left, and the **Activity** template on the right. Name the new activity **MyForEach.xaml** and click **Ok**. The activity will open in the workflow designer.  
  
3.  In the workflow designer, click the **Arguments** tab.  
  
4.  Click **Create Argument**. Name the new argument **Items**.  
  
5.  In the **Argument type** column, select **Array of [T]**.  
  
6.  In the type browser, select  **Object**. Click **Ok**.  
  
7.  Click **Create Argument** again. Name the new argument **Body**. In the **Direction** column for the new argument, select **Property**.  
  
8.  In the Argument Type column, select **Browse for types…**  
  
9. In the type browser, enter **ActivityAction** in the **Type Name** field. Select **ActivityAction<T\>** in the tree view. Select **Object** in the dropdown that appears to assign the type **ActivityAction<Object\>** to the argument.  
  
10. Drag a <xref:System.Activities.Statements.While?qualifyHint=False> activity from the **Control Flow** section of the toolbox to the designer surface.  
  
11. Select the <xref:System.Activities.Statements.While?qualifyHint=False> activity, and select the **Variables** tab.  
  
12. Select **Create Variable**. Name the new variable **Index**.  
  
13. In the **Variable type** column, select **Int32**. Leave the **Scope** as **While**, and the **Default** column blank.  
  
14. Set the **Condition** property of the <xref:System.Activities.Statements.While?qualifyHint=False> activity to **index < Items.Length;**.  
  
15. Drag an <xref:System.Activities.Statements.InvokeDelegate?qualifyHint=False> activity from the **Primitives** section of the toolbox to the **Body** of the <xref:System.Activities.Statements.While?qualifyHint=False> activity.  
  
16. Select **Body** in the delegate drop-down.  
  
17. In the **Properties** grid for the <xref:System.Activities.Statements.InvokeDelegate?qualifyHint=False> activity, click the **…** button in the **Delegate Arguments** property.  
  
18. In the **Value** column of the argument named **Argument**, enter **Items[Index]**. Click **Ok** to close the **DelegateArguments** dialog.  
  
19. Drag an <xref:System.Activities.Statements.Assign?qualifyHint=False> activity onto the horizontal line underneath the <xref:System.Activities.Statements.InvokeDelegate?qualifyHint=False> activity. The  <xref:System.Activities.Statements.Assign?qualifyHint=False> activity will be created, and a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity will be created automatically to contain the two activities in the **Body** section of the **MyForEach** activity. The sequence is needed since the **Body** section can only contain a single activity. Automatically creating a new <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity is a new feature of .NET Framework 4.5.  
  
20. Set the **To** property of the <xref:System.Activities.Statements.Assign?qualifyHint=False> activity to **index**. Set the **Value** property of the **Assign** activity to **index+1**.  
  
 The custom **MyForEach** activity will now invoke an arbitrary activity once for each value passed into it through the **Items** collection, with the values in the collection as inputs for the activity.  
  
### Use the custom activity in a workflow  
  
1.  Build the project by pressing **Ctrl+Shift+B**.  
  
2.  In **Solution Explorer**, open **Workflow1.xaml** in the designer.  
  
3.  Drag a **MyForEach** activity from the toolbox to the designer surface. The activity will be in a section of the toolbox with the same name as the project.  
  
4.  Set the **Items** property of the **MyForEach** activity to **new Object[] {1, "abc"}**.  
  
5.  Drag a <xref:System.Activities.Statements.WriteLine?qualifyHint=False> activity from the **Primitives** section of the toolbox to the **Delegate:Body** section of the **MyForEach** activity.  
  
6.  Set the **Text** property of the <xref:System.Activities.Statements.WriteLine?qualifyHint=False> activity to **Argument.ToString()**.  
  
 When the workflow is executed, the console will show the following:  
  
 **1**   
**abc**