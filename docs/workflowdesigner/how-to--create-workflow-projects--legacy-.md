---
title: "How to: Create Workflow Projects (Legacy)"
ms.custom: na
ms.date: "10/02/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
helpviewer_keywords: 
  - "workflow projects, creating"
  - "projects, workflow"
ms.assetid: 32299555-662c-469d-a90d-89f4700dc78c
caps.latest.revision: 6
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
# How to: Create Workflow Projects (Legacy)
Follow these steps to create a [!INCLUDE[wf](../workflowdesigner/includes/wf_md.md)] project that targets the [!INCLUDE[netfx35_long](../workflowdesigner/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflowdesigner/includes/vstecwinfx_md.md)]. This procedure uses the legacy [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)] provided by [!INCLUDE[vs2010](../codequality/includes/vs2010_md.md)].  
  
### To create a workflow project  
  
1.  Start [!INCLUDE[vs_current_long](../misc/includes/vs_current_long_md.md)].  
  
2.  On the **File** menu, point to **New**, and then select **Project**.  
  
     The **New Project** dialog box opens.  
  
3.  Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.  
  
    > [!NOTE]
    >  The default option in [!INCLUDE[vs2010](../codequality/includes/vs2010_md.md)] is **.NET Framework 4**. This option is used to create [!INCLUDE[wf](../workflowdesigner/includes/wf_md.md)] applications that target the [!INCLUDE[netfx40_short](../workflowdesigner/includes/netfx40_short_md.md)] and it does not use the legacy designer.  
  
4.  In the **Project Types** pane, select Visual C# projects or Visual Basic projects, and then select **Workflow**.  
  
5.  In the **Templates** pane, select one of the installed project templates:  
  
    -   Sequential Workflow Console Application  
  
    -   Sequential Workflow Library  
  
    -   Workflow Activity Library  
  
    -   State Machine Workflow Console Application  
  
    -   State Machine Workflow Library  
  
    -   Empty Workflow Project  
  
6.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.  
  
7.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to the directory.  
  
     If you want a solution directory created for the project, select the **Create directory for solution** check box and enter a name in the **Solution Name** box.  
  
8.  Click **OK**.  
  
## See Also  
 [Creating Legacy Workflow Projects](../workflowdesigner/creating-legacy-workflow-projects.md)