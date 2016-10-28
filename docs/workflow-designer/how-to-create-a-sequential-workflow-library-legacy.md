---
title: "How to: Create a Sequential Workflow Library (Legacy)"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "sequential workflows, creating library"
  - "workflows, sequential workflow library"
  - "projects, sequential workflow library"
  - "sequential workflow libraries"
ms.assetid: 9433ccf3-1eab-4d53-90ff-2e7b2341676c
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
# How to: Create a Sequential Workflow Library (Legacy)
Follow these steps to create a Sequential Workflow Library project using the legacy [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] provided by [!INCLUDE[vs2010](../modeling/includes/vs2010_md.md)]. Use the legacy [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] when you need to target either the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
### To create a sequential workflow library project  
  
1.  Start Visual Studio.  
  
2.  On the **File** menu, point to **New**, and then select **Project**.  
  
     The **New Project** dialog box opens.  
  
3.  Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.  
  
    > [!NOTE]
    >  The default option in [!INCLUDE[vs2010](../modeling/includes/vs2010_md.md)] is **.NET Framework 4**. This option is used to create [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications that target the [!INCLUDE[netfx40_short](../workflow-designer/includes/netfx40_short_md.md)] and it does not use the legacy designer.  
  
4.  In the **Project Types** pane, select Visual C# or Visual Basic (under **Other Languages**), and then select **Workflow**.  
  
5.  In the **Templates** pane, select **Sequential Workflow Library**.  
  
6.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.  
  
7.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.  
  
     If you want a solution directory created for the project, select the **Create directory for solution** check box and enter a name in the **Solution Name** box.  
  
8.  Click **OK**.  
  
## See Also  
 [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)   
 [Workflow Authoring Styles](http://msdn.microsoft.com/en-us/aacf4ec6-da05-4974-958a-974769dda739)