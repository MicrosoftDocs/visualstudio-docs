---
title: "How to: Create an Activity Library"
ms.custom: na
ms.date: "10/02/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
ms.assetid: 1eeebe74-7303-4345-8a83-fe37a26bc84b
caps.latest.revision: 12
ms.author: "erikre"
manager: "erikre"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Create an Activity Library
Custom activities are used to model your particular business processes in a workflow. The Activity Library template in [!INCLUDE[vs2010](../codequality/includes/vs2010_md.md)] has been provided to enable you to create such custom activities visually using the [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)].  
  
### To create a Workflow Activity Library  
  
1.  Start [!INCLUDE[vs2010](../codequality/includes/vs2010_md.md)].  
  
2.  On the **File** menu, point to **New**, and then select **Project…**.  
  
     The **New Project** dialog box opens.  
  
3.  In the **Project Types** pane, select **Workflow** from either the **Visual C#** projects or **Visual Basic** groupings depending on your language preference.  
  
4.  In the **Templates** pane, select **Activity Library**.  
  
5.  In the **Name** box, type in a descriptive name for your project to make it easy to identify.  
  
6.  In the **Location** box, type in the directory in which you want to save your project or click **Browse** to navigate to it.  
  
7.  In the **Solution** box, type in a descriptive name for your solution, then click **OK**.  
  
    > [!NOTE]
    >  If you want to add a workflow console application to an existing solution, open that solution in [!INCLUDE[vs2010](../codequality/includes/vs2010_md.md)], right click the solution in **Solution Explorer**, and select **Add**, then **New Project…** to open the **New Project** dialog box. Proceed as described above in this procedure.  
  
8.  The project template creates an activity definition in XAML. [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)] opens and displays the canvas for your custom activity.  
  
9. Drag an activity from the **Toolbox** to the design surface to include it in your custom activity.  
  
    > [!CAUTION]
    >  You are allowed only one child activity in the body of your custom activity; however, that child activity could be a composite activity, such as a \<xref:System.Activities.Statements.Sequence> activity or \<xref:System.Activities.Statements.Flowchart> activity.  
  
## See Also  
 [How to: Create an Activity](../Topic/How%20to:%20Create%20an%20Activity.md)   
 [Creating a Workflow Project](../workflowdesigner/creating-a-workflow-project.md)