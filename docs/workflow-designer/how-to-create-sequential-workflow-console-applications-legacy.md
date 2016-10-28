---
title: "How to: Create Sequential Workflow Console Applications (Legacy)"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "workflows, console applications"
  - "sequential workflows, console applications"
  - "console applications, sequential workflow"
ms.assetid: 9f7be7fa-551f-42c6-a9bb-f5ae8ab83625
caps.latest.revision: 5
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
# How to: Create Sequential Workflow Console Applications (Legacy)
Follow these steps to create a Sequential Workflow Console Application project using the legacy [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] provided by [!INCLUDE[vs2010](../modeling/includes/vs2010_md.md)]. Use the legacy [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] when you need to target either the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
### To create a sequential workflow console application  
  
1.  Start Visual Studio.  
  
2.  On the **File** menu, point to **New**, and then select **Project**.  
  
     The **New Project** dialog box opens.  
  
3.  Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.  
  
    > [!NOTE]
    >  The default option in [!INCLUDE[vs2010](../modeling/includes/vs2010_md.md)] is **.NET Framework 4**. This option is used to create [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications that target the [!INCLUDE[netfx40_short](../workflow-designer/includes/netfx40_short_md.md)] and it does not use the legacy designer.  
  
4.  In the **Project Types** pane, select Visual C# projects or Visual Basic projects (under **Other Languages**), and then select **Workflow**.  
  
5.  In the **Templates** pane, select **Sequential Workflow Console Application**.  
  
6.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.  
  
7.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.  
  
     The Windows Forms Designer opens and displays Form1 of the project you created.  
  
8.  Click **OK**.  
  
     The Workflow Designer opens and displays the workflow design surface of the sequential workflow you created.  
  
9. Drag an activity from the **Toolbox** to the design surface in the **Drop activity** designated area.  
  
## See Also  
 [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)   
 [Developing Workflows](http://msdn.microsoft.com/en-us/557bcb1f-a7ab-49f6-8df7-2706b7001301)