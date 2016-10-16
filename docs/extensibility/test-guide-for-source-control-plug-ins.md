---
title: "Test Guide for Source Control Plug-ins"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "plug-ins, source control"
  - "source control [Visual Studio SDK], testing plug-ins"
  - "tests, source control plug-ins"
  - "testing, source control plug-ins"
  - "source control plug-ins, test guide"
ms.assetid: 13b74765-0b7c-418e-8cd9-5f2e8db51ae5
caps.latest.revision: 26
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# Test Guide for Source Control Plug-ins
This section provides guidance for testing your source control plug-in with [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)]. An extensive overview of the most common testing areas, as well as some of the more intricate areas that may be problematic is provided. This overview is not meant to be an exhaustive list of test cases.  
  
> [!NOTE]
>  Some bug fixes and improvements to the latest [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] IDE may uncover problems with existing source control plug-ins that were previously not encountered while using previous versions of [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)]. It is strongly recommended that you test your existing source control plug-in for the areas enumerated in this section, even if no changes have been made to the plug-in since the previous version of [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)].  
  
## Common Preparation  
 A machine with [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] and the target source control plug-in installed, is required. A second machine similarly configured can be used for some of the Open from Source Control tests.  
  
## Definition of Terms  
 For the purpose of this test guide, use the following term definitions:  
  
 Client project  
 Any project type available in [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] that supports source control integration (for example, [!INCLUDE[vbprvb](../codequality/includes/vbprvb_md.md)], [!INCLUDE[csprcs](../datatools/includes/csprcs_md.md)], or [!INCLUDE[vcprvc](../codequality/includes/vcprvc_md.md)]).  
  
 Web project  
 There are four types of Web projects: File System, Local IIS, Remote Sites, and FTP.  
  
-   File System projects are created on a local path, but they do not require the Internet Information Services (IIS) to be installed as they are accessed internally via a UNC path, and can be placed under source control from inside the IDE, much like client projects.  
  
-   Local IIS projects work with IIS that is installed on the same machine and are accessed with a URL pointing to the local machine.  
  
-   Remote Sites projects are also created under an IIS Services, but they are placed under source control on the IIS server machine and not from inside the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] IDE.  
  
-   FTP projects are accessed through a remote FTP server but they cannot be placed under source control.  
  
 Enlistment  
 Another term for the solution or project under source control.  
  
 Version Store  
 The source control database that is being accessed through the Source Control Plug-in API.  
  
## Test Areas Covered in This Section  
  
-   [Test Area 1: Add To/Open From Source Control](../extensibility/test-area-1--add-to-open-from-source-control.md)  
  
    -   Case 1a: Add Solution to Source Control  
  
    -   Case 1b: Open Solution from Source Control  
  
    -   Case 1c: Add Solution from Source Control  
  
-   [Test Area 2: Get From Source Control](../extensibility/test-area-2--get-from-source-control.md)  
  
-   [Test Area 3: Check Out/Undo Checkout](../extensibility/test-area-3--check-out-undo-checkout.md)  
  
    -   Case 3: Check Out/Undo Checkout  
  
    -   Case 3a: Check Out  
  
    -   Case 3b: Disconnected Checkout  
  
    -   Case 3c: Query Edit/Query Save (QEQS)  
  
    -   Case 3d: Silent Checkout  
  
    -   Case 3e: Undo Checkout  
  
-   [Test Area 4: Check In](../extensibility/test-area-4--check-in.md)  
  
    -   Case 4a: Modified items  
  
    -   Case 4b: Adding files  
  
    -   Case 4c: Adding projects  
  
-   [Test Area 5: Change Source Control](../extensibility/test-area-5--change-source-control.md)  
  
    -   Case 5a: Bind  
  
    -   Case 5b: Unbind  
  
    -   Case 5c: Rebind  
  
-   [Test Area 6: Delete](../extensibility/test-area-6--delete.md)  
  
-   [Test Area 7: Share](../extensibility/test-area-7--share.md)  
  
-   [Test Area 8: Plug-in Switching](../extensibility/test-area-8--plug-in-switching.md)  
  
    -   Case 8a: Automatic Change  
  
    -   Case 8b: Solution-based Change  
  
## See Also  
 [Source Control Plug-ins](../extensibility/source-control-plug-ins.md)