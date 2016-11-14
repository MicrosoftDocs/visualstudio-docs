---
title: "How to: Create an Activity Designer Library | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 5b62e092-63b3-462d-9d77-fb112482f45d
caps.latest.revision: 8
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
# How to: Create an Activity Designer Library
Custom activity designers allow you to create a user interface for a standard or a custom activity. You control the complexity of the user interface and have the ability to create more than one activity designer for an activity. This scenario allows you to create designers that are tailored for multiple audiences.  
  
### To create an Activity Designer Library  
  
1.  Start [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)].  
  
2.  On the **File** menu, point to **New**, and then select **Project…** to open the **New Project** dialog box.  
  
3.  In the **Project Types** pane, select **Workflow** from either the **Visual C#** or **Visual Basic** groupings depending on your preferred language.  
  
4.  In the **Templates** pane, select **Activity Designer Library**.  
  
5.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.  
  
6.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.  
  
7.  In the **Solution** box, type in a descriptive name for your solution, then click **OK**.  
  
    > [!NOTE]
    >  If you want to add a workflow console application to an existing solution, open that solution in [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)], right click on the solution in **Solution Explorer**, and select **Add**, then **New Project…** to open the **New Project** dialog box. Proceed as described above in this procedure.  
  
8.  The project template creates an activity designer definition in XAML and the code-behind implementation file in source code. The [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] opens and displays the canvas for your activity designer.  
  
9. Drag [!INCLUDE[avalon1](../workflow-designer/includes/avalon1_md.md)] controls from the **Toolbox** to the design surface to use them in your custom activity designer.  For an example of how to implement a custom activity designer, see [How to: Create a Custom Activity Designer](../Topic/How%20to:%20Create%20a%20Custom%20Activity%20Designer.md).  
  
    > [!WARNING]
    >  Custom activity designers can be used for custom activities as well as for default [!INCLUDE[netfx40_short](../workflow-designer/includes/netfx40_short_md.md)]activities.  
  
## See Also  
 [Creating a Workflow Project](../workflow-designer/creating-a-workflow-project.md)