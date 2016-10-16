---
title: "How to: Create a hyperlink to view test results from an email"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 39d04ac8-0ed9-4b77-aaca-03975267d0be
caps.latest.revision: 6
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
# How to: Create a hyperlink to view test results from an email
If you are using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] to run your tests, you might want to send out a status e-mail with a hyperlink to the latest test results. You can construct a hyperlink with a URL that contains the necessary information about your [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] and team project and the ID of your test run. This way, the test results can be accessed immediately. You will not have to search for them in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
> [!NOTE]
>  You must have [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] installed on the computer that you use to access this URL.  
  
### To Create a Hyperlink to View Test Results From an Email  
  
1.  To create a hyperlink, you will need the following information about your team project:  
  
    -   The name of your [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)]  
  
    -   The name of your team project collection  
  
    -   The name of your team project  
  
    > [!IMPORTANT]
    >  To obtain this information, you can copy the URL for the test plan that contains the test run. You can then edit this URL to the format shown in the following steps. Replace **connect** with **open** and add the ID of the test run. For information about how to copy the URL for a test plan, see [How to: Switch between Test Plans Using URLs](../test_notintoc/how-to--switch-between-test-plans-using-urls.md).  
  
2.  To access the correct test run, you need the test run ID. This ID is displayed in the **Analyze Test Runs** view in the **Test** activity center.  
  
3.  Create a hyperlink in your e-mail. Use the following format for the URL for the hyperlink:  
  
     **mtm://\<Team Foundation Server Name>:\<port number>/tfs/\<team project collection name>/p:\<team project name>/Testing/testrun/open?id=\<test run id>**  
  
     For example:  
  
     **mtm://contoso:8080/tfs/DefaultCollection/p:DinnerNow/Testing/testrun/open?id=40**  
  
## See Also  
 [How to: Analyze Manual Test Runs Using Microsoft Test Manager](assetId:///8fd8b3d5-d71e-4a37-91a4-354ab00e32ed)   
 [Reviewing Test Results in Microsoft Test Manager](assetId:///9fb3e429-78df-4fe2-89ed-0ad1db0738f4)