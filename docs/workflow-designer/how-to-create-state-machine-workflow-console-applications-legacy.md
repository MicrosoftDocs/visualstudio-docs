---
title: "How to: Create State Machine Workflow Console Applications (Legacy) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "console applications, state machine workflows"
  - "state machine workflow console applications"
  - "state machine workflows, console applicationa"
ms.assetid: d6170b5d-5d4f-48e1-8257-c78604f27eac
caps.latest.revision: 5
author: "ErikRe"
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
# How to: Create State Machine Workflow Console Applications (Legacy)
Follow these steps to create a State Machine Workflow Console Application project using the legacy [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] provided by [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)]. Use the legacy [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] when you need to target either the [!INCLUDE[netfx35_long](../workflow-designer/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflow-designer/includes/vstecwinfx_md.md)].  
  
### To create a state machine application project  
  
1.  Start Visual Studio.  
  
2.  On the **File** menu, point to **New**, and then select **Project**.  
  
     The **New Project** dialog box opens.  
  
3.  Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.  
  
    > [!NOTE]
    >  The default option in [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)] is **.NET Framework 4**. This option is used to create [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] applications that target the [!INCLUDE[netfx40_short](../workflow-designer/includes/netfx40_short_md.md)] and it does not use the legacy designer.  
  
4.  In the **Project Types** pane, select Visual C# or Visual Basic (under **Other Languages**) and then select **Workflow**.  
  
5.  In the **Templates** pane, select **State Machine Workflow Console Application**.  
  
6.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.  
  
7.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.  
  
     If you want a solution directory created for the project, select the **Create directory for solution** check box and enter a name in the **Solution Name** box.  
  
8.  Click **OK**.  
  
## See Also  
 [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)   
 [How to: Create a State Machine Workflow Library (Legacy)](../workflow-designer/how-to-create-a-state-machine-workflow-library-legacy.md)