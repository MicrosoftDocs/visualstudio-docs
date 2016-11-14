---
title: "Upgrading Coded UI Tests from Visual Studio 2010 | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 11232a83-73ea-46bd-bc0c-46f74f6e3a42
caps.latest.revision: 33
ms.author: "mlearned"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Upgrading Coded UI Tests from Visual Studio 2010
Test Projects containing coded UI tests that were created in [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] SP1 are silently repaired when opened in Visual Studio 2012. If the Test projects are checked into source control, the project files are checked out for this repair. Once repaired, these test projects containing coded UI tests can then be used in both [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] SP1 and [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
> [!NOTE]
>  Visual Studio includes more than one test project type. If you create a new coded UI test, it will be created in a coded UI test project type. For more information, see [Upgrading Tests from Earlier Versions of Visual Studio](http://msdn.microsoft.com/en-us/e9c8b7f6-bd72-448e-8edb-d090dcc5cf52).  
  
> [!WARNING]
>  [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] test projects that contain coded UI tests must be rebuilt when you open the test project in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] or [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] side-by-side with [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].  
  
> [!WARNING]
>  When a test project that was created in [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] and contains only unit tests is opened in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], coded UI tests cannot be added to it. Similarly, you cannot add a coded UI test to a unit test project that was created in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].  
  
## Compatibility Issues between Visual Studio 2010 and Visual Studio 2012  
 The following table lists issues to be aware of when migrating coded UI tests between [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] and [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].  
  
> [!CAUTION]
>  There is a known issue regarding references in coded UI test projects not appearing in Solution Explorer. For more information, see the ReadMe file included on the [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] installation media.  
  
|Coded UI functionality|Issue|Solution|  
|----------------------------|-----------|--------------|  
|Silverlight UI Testing is not supported in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)]|**Build will fail**<br /><br /> If you have [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] Feature Pack 2 and have created Coded UI Test Projects for Silverlight applications, these projects cannot be opened in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].|We recommend that you manage these projects in [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] Feature Pack 2 only.|  
|Firefox UI Testing is not supported in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)]|**Build will succeed, test run will fail**<br /><br /> If you have [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] Feature Pack 2 and have created Coded UI Test Projects for web applications in Firefox, these projects cannot be opened in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].|We recommend that you manage these projects in [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] Feature Pack 2 only.|  
|New UI code testing APIs have been added in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)]|**Build will fail**<br /><br /> If you create Coded UI Tests using the new UI Testing API in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], these projects cannot be opened in [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)].|Projects using new API should be managed in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] only.|  
|In [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)], references were added inside a ‘Choose’ statement in the csproj file. In [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], we are using a Feedback targets file to include Coded UI Test Assembly references.|In [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], a Coded UI Test cannot be added to a Test Project created in [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] (or SP1) that did not contain a Coded UI Test.<br /><br /> The repair process adds the targets file and the Choose statement. If a Coded UI Test is not in the Test Project, then the project is marked as repaired and the appropriate references will not be added when adding Coded UI Test in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].|You will have to create a new Test Project in the same solution using [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)] and add your new Coded UI Test in it. Alternately, you can add Coded UI Tests into the Test Project in [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] SP1 and open that project in [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)].|  
  
##  <a name="UpgradingCodedUIFromVS2010_Update"></a> Visual Studio 2010 SP1 Update  
 An update to [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)] SP1 with compatibility support for Visual Studio 2012 and Windows 8 is available for download at the [Microsoft Download Center](http://www.microsoft.com/download/details.aspx?id=34677) and also as a Visual Studio update.  
  
 After you apply the update, the following [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)] SP1 coded UI test tool features are improved for Windows 8:  
  
-   You can run a Coded UI Test for the Microsoft .NET Framework 4.5-based Windows Presentation Foundation (WPF) controls on a computer that is running Windows 8.  
  
-   You can run a Coded UI test for 64-bit (x64) Internet Explorer 10 on a computer that is running Windows 8.  
  
 The update also contains fixes for the following issues:  
  
-   **Code coverage:** Inability to open a code coverage file (.coverage) that is created by Visual Studio 2012 in [!INCLUDE[vs2010](../misc/includes/vs2010_md.md)] SP1.  
  
-   **Stranded test artifacts:** Your team has a test artifact that is assigned to an invalid user in Team Foundation Server (TFS) 2010. For example, a user has left the company, but still has a test case that is assigned to him. You upgrade TFS 2010 to TFS 2012. You use [!INCLUDE[TCMext](../misc/includes/tcmext_md.md)] 2010 to connect to the upgraded TFS server. You are not able to assign the test artifact to any TFS users by using [!INCLUDE[TCMext](../misc/includes/tcmext_md.md)] 2010.  
  
-   **Load testing:** When you run a load test together with a network type other than the local area network (LAN) profile on a computer this is running Windows 8, the network emulator driver causes the operating system to crash. For more details, see [KB Article 2736182](http://support.microsoft.com/kb/2736182).  
  
## See Also  
 [Porting, Migrating, and Upgrading Visual Studio Projects](../porting/porting-migrating-and-upgrading-visual-studio-projects.md)   
 [Upgrading Tests from Earlier Versions of Visual Studio](http://msdn.microsoft.com/en-us/e9c8b7f6-bd72-448e-8edb-d090dcc5cf52)   
 [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)   
 [Generating a Coded UI Test from an Existing Action Recording](/devops-test-docs/test/generating-a-coded-ui-test-from-an-existing-action-recording)   
 [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../test/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)