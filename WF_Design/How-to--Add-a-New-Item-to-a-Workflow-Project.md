---
title: "How to: Add a New Item to a Workflow Project"
ms.custom: na
ms.date: 10/04/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 5c6180ca-af10-4513-b0cb-7d478fd84eab
caps.latest.revision: 14
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
# How to: Add a New Item to a Workflow Project
After you have created a workflow project, you can add workflow activities, designers, and other familiar Visual Studio items to your project.  
  
 The following table lists the Windows Workflow Foundation (WF) items that you can add to a workflow project.  
  
|Name|Description|  
|----------|-----------------|  
|Activity|An activity to be composed of other activities. Selecting this item adds the same XAML file to the project as you would obtain when selecting the **Activity Library** template for a new project. For more information about on this procedure, see [How to: Create an Activity Library](../WF_Design/How-to--Create-an-Activity-Library.md).|  
|Activity Designer|A designer to customize the design-time experience of an activity. Selecting this item adds the same files to the project as you would obtain when selecting the **Activity Designer Library** template for a new project. For more information about on this procedure, see [How to: Create an Activity Designer Library](../WF_Design/How-to--Create-an-Activity-Designer-Library.md).|  
|Code Activity|An activity with execution logic written in code. A source code file with an override of the <xref:System.Activities.CodeActivity.Execute?qualifyHint=False> method is already generated for you.|  
|WCF Workflow Service|A WCF service built using workflow activities. Selecting this item adds the same files to the project as you would obtain when selecting the **WCF Workflow Service Application** template for a new project. For more information about on this procedure, see [How to: Create a WCF Workflow Service Application](../WF_Design/How-to--Create-a-WCF-Workflow-Service-Application.md).|  
  
### To add a new item to a workflow project  
  
1.  On the **Project** menu, click **Add New Item…**.  
  
     The **Add a New Item** dialog box opens.  
  
2.  In the **Installed Templates** pane, select **Workflow** group.  
  
3.  Select one of the four items. The previous table lists the selections available.  
  
4.  Type an appropriate name for the item in the **Name** box at the bottom of the dialog box.  
  
5.  Click **Add** to add the item to the current workflow project.  
  
## See Also  
 [Creating a Workflow Project](../WF_Design/Creating-a-Workflow-Project.md)