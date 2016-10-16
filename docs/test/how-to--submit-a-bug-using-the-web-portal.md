---
title: "How to: Submit a bug using the web portal"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c44c08d5-9f24-4a4a-9dc6-1e9de2fc92f3
caps.latest.revision: 8
ms.author: "ahomer"
manager: "douge"
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
# How to: Submit a bug using the web portal
You can submit a bug using the web portal at any time during the software development process. For example, you perform ad hoc testing and find a bug, or you notice incorrect behavior while you’re discussing the application under test with your team mates. You can manually attach information to this bug and link it to other work items.  
  
> [!NOTE]
>  Using the web portal to submit a bug does not automatically add data that was collected when a test was run, unlike when you create a bug using Test Runner or the Exploratory Testing window from Microsoft Test Manager. For more information about these methods, see [Submitting Bugs](../test_notintoc/submitting-bugs-in-microsoft-test-manager.md).  
  
### To connect to the web portal  
  
1.  Open a browser window and type a URL that uses the following form, where *ServerName* is the name of the application tier for Team Foundation Server, and the default *Port* is **8080**:  
  
     **http://** *ServerName:Port* **/tfs/**  
  
     For example, to connect to the server named **FabrikamPrime**, you would type **http://FabrikamPrime:8080/tfs/**. For more information, see [Connect to team projects](../Topic/Connect%20to%20team%20projects%20in%20Team%20Foundation%20Server.md).  
  
2.  In the **Windows Identity** dialog box, enter your credentials and choose the **OK** button.  
  
3.  On the server home page, choose a team project link from those displayed, or choose **Browse all** to choose a team project from all those hosted on the server.  
  
     The **HOME** page for the selected team project displays.  
  
## To create a new bug using the web portal  
 ![Create new bug using Team Web Access](../test/media/teamaccesssubmitbug.png "TeamAccessSubmitBug")  
  
1.  On the **HOME** page of your team project, choose the **WORK** page and then choose the **work items** tab.  
  
2.  Using the drop-down list for **New**, choose **Bug**.  
  
     A **New Bug** form displays.  
  
3.  Type an appropriate title in the **Title** field.  
  
4.  (Optional) Use the drop-down list for **Iteration** to change the iteration path you want to associate with the bug.  
  
5.  Under **STATUS**, perform the following optional steps:  
  
    -   (Optional) To select the user to assign to this bug, use the drop-down list for **Assigned to**.  
  
    -   (Optional) To change the state of this bug from the default state of active, use the drop-down list for **State**.  
  
    -   (Optional) To change the reason for the bug, use the drop-down list for **Reason**.  
  
6.  Under **DETAILS**, perform the following optional steps:  
  
    -   (Optional) Add text in the **Effort** field.  
  
    -   (Optional) To assign a severity to the bug, use the drop-down list for **Severity**.  
  
    -   (Optional) Use the drop-down list for **Area** to select the appropriate area in the team project for this bug.  
  
    -   (Optional) Add text for the **Backlog Priority** field.  
  
7.  (Optional) Add comments applicable to the error causing the bug under **HISTORY**.  
  
8.  (Optional) To link this bug to other work items, choose **LINKS** and then choose **Link to**.  
  
9. (Optional) To add attachments to this bug, choose **Attachments**. Any file can be added. For example, you could add a video recording file, a screen shot file, or a log file.  
  
10. To save the bug, choose **Save work item** (disc icon) on the toolbar.  
  
## See Also  
 [Submitting Bugs](../test_notintoc/submitting-bugs-in-microsoft-test-manager.md)   
 [Work in the web portal](../Topic/Work%20in%20the%20TFS%20web%20portal.md)