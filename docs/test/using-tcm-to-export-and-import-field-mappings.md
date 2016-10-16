---
title: "Using tcm to export and import field mappings"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a4174b29-58d0-42e6-9e57-56ea5053a326
caps.latest.revision: 11
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
# Using tcm to export and import field mappings
To import and export the XML file that maps to the type provided, use the following **tcm** command:  
  
-   **tcm fieldmapping /import**  
  
-   **tcm fieldmapping /export**  
  
> [!NOTE]
>  The **fieldmapping** option is only available with [Visual Studio 2012.2](http://go.microsoft.com/fwlink/?LinkID=267636) or later.  
  
## Syntax  
  
```  
tcm fieldmapping /import /type: typeofmapping /mappingfile: path /collection:CollectionURL /teamproject:project [/login:username,[password]]  
```  
  
```  
tcm fieldmapping /export /type: typeofmapping /mappingfile: path /collection:CollectionURL /teamproject:project [/login:username,[password]]  
```  
  
#### Parameters  
  
|**Parameter**|**Description**|  
|-------------------|---------------------|  
|**/type**: `typeofmappingfile`|Specifies the type for which export/import needs to be done.<br /><br /> Types: resolutiontype, bug, failuretype.<br /><br /> Expected value: resolutiontype.|  
|**/mappingfile**: `path`|Specifies full path, including file name for export/import.<br /><br /> For import option, verify that the file exists and for export option, make sure the file does not exist.|  
|**/collection**:`CollectionURL`|Specifies the URI of the team project collection. The format for the URI is as follows: **http**://*ServerName:Port/VirtualDirectoryName/CollectionName*<br /><br /> If no virtual directory is used, then the format for the URI is as follows:<br /><br /> **http**://*ServerName:Port/CollectionName*|  
|**/teamproject**:`project`|The name of the team project that contains the test plan that you want to import your automated tests into.|  
|**/login**:`username,[password]`|Optional. Specifies the name and password of a user who is logged on to the application-tier server for [!INCLUDE[esprtfs](../codequality/includes/esprtfs_md.md)] and who has permissions to run the command. You would use this option if your Windows credentials do not have the appropriate permissions, or you are using basic authentication, or you are not connected to a domain.<br /><br /> To login to Visual Studio Team Services, you will also need to use /allowalternatecredentials listed below.|  
|**/allowalternatecredentials**|This flag must be specified in addition to the **/login** parameter when connecting to Visual Studio Team Services. (This flag is only available if you have Visual Studio 2013 Update 4 or greater.)|  
  
## Examples  
  
## Import and export XML fieldmapping file  
 The following examples assume that you have started a [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] command prompt.  
  
 To do this, choose **Start**, point to **All Programs**, point to **Microsoft Visual Studio 2012**, point to **Visual Studio Tools**, and then choose **Developer Command Prompt**.  
  
 The command prompt opens to the folder: **\<drive>:\Program Files\Microsoft Visual Studio 11.0\VC**  
  
 Change the directory to the folder that contains the assembly built from your test project.  
  
 The following command imports fieldmapping into the DinnerNow team project from a specified XML file:  
  
```  
tcm fieldmapping /import /type:resolutiontype /mappingfile:<drive>\dir\sudir\filetoimport.xml /collection:http://<Team Foundation Server Name>:8080/tfs/<team project collection name>  
/teamproject:DinnerNow  
```  
  
 The following command exports fieldmapping from the DinnerNow team project:  
  
```  
tcm fieldmapping /export /type: resolutiontype /mappingfile:<drive>\dir\sudir\filetoexport.xml /collection:http://<Team Foundation Server Name>:8080/tfs/<team project collection name>  
/teamproject:DinnerNow  
```  
  
## See Also  
 [Using TCM from the command line](../test/using-tcm-from-the-command-line.md)