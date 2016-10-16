---
title: "Upgrade SCVMM 2008 R2 to SCVMM 2012"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5be92444-c701-43c7-8b2a-77df8e02bc27
caps.latest.revision: 11
ms.author: "ahomer"
manager: "kamrani"
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
# Upgrade SCVMM 2008 R2 to SCVMM 2012
Lab Management for Team Foundation Server supports SCVMM 2008 R2 and SCVMM 2012. If you are upgrading Team Foundation Server 2013 to Team Foundation Server 2015, and plan to upgrade SCVMM 2008 R2 to SCVMM 2012, we recommend that you upgrade to SCVMM 2012 after you complete your upgrade to Team Foundation Server 2015. This topic describes how to upgrade SCVMM 2008 R2 to SCVMM 2012 when you are using Lab Management on Team Foundation Server 2015.  
  
> [!IMPORTANT]
>  When you upgrade SCVMM, certain steps will cause some downtime for your Team Foundation Server. Those steps are indicated below.  
  
## Upgrading to SCVMM 2012  
  
1.  Use the SCVMM 2012 installer to upgrade SCVMM 2008 R2 Server to SCVMM 2012 Server.  
  
2.  Upgrade the SCVMM agents on your hosts and library shares.  
  
3.  Use the SCVMM Administration Console to verify that all of your SCVMM components are working.  
  
4.  Install SCVMM 2012 Administration Console on all machines of the application tier of your Team Foundation Server.  
  
5.  Use the **iisreset** command to restart the Team Foundation Server web service. Then restart the Team Foundation Server job agent.  
  
    > [!CAUTION]
    >  This step will disrupt the services on your Team Foundation Server.  
  
6.  Upgrade the data and templates in each project collection database so it is compatible with SCVMM 2012.  
  
     Open an elevated command prompt on your Team Foundation Server and enter the following command:  
  
     **C:\Program Files\Microsoft Team Foundation Server 14.0\Tools> tfsconfig lab /upgradeSCVMM /collectionName:\***  
  
     When you use the **upgradeSCVMM** command, Team Foundation Server will create a new template object on your SCVMM server for every team project that uses that template. This ensures that your templates are upgraded to be compatible with SCVMM 2012 without losing any data. However, when the new templates are created, the team project name is appended to the template name.  
  
    > [!CAUTION]
    >  If the new template name is greater than 64 characters, this will cause an SCVMM failure. To resolve this error, you must give those templates a shorter name. If you encounter any other errors or warnings when you run this command, see the next section to resolve those errors. If you do not encounter any errors or warnings, your upgrade is complete and you can begin using SCVMM environments with Lab Management.  
  
### Resolving errors and warnings when using the upgradeSCVMM command  
 After you use the **upgradeSCVMM** command, you must resolve any errors or warnings you receive then rerun the command before you can start using Lab Management. The **upgradeSCVMM** command generates a log file that contains information about any errors and warnings that you encounter. The location of the log file is displayed when you run the **upgradeSCVMM** command.  
  
 **SCVMM failure:** If you receive an error that is related to an SCVMM failure, use your SCVMM job history to get additional information about the error. After you resolve the error in SCVMM, rerun the **upgradeSCVMM** command.  
  
## See Also  
 [Upgrading Lab Management Components from Visual Studio 2010](assetId:///41cc4ddb-a118-4176-ada9-ee713e5596a2)