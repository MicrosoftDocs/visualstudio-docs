---
title: "File Status Code Enumerator | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "named constants, SccStatus enumerator"
  - "source control plug-ins, file status enumeration"
  - "SccStatus enumerator"
  - "file status code enumerator"
ms.assetid: 5c37876b-c83c-4ca1-837b-57cd465a879a
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# File Status Code Enumerator
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The `SccStatus` enumerator contains named constant values that specify the state of a file in the source control system. This enumeration is used by the [SccQueryInfo](../extensibility/sccqueryinfo-function.md) and the `POPLISTFUNC` callback function (see [POPLISTFUNC](../extensibility/poplistfunc.md) for details).  
  
## Syntax  
  
```  
enum SccStatus {  
   SCC_STATUS_INVALID          = -1L,  
   SCC_STATUS_NOTCONTROLLED    = 0x0000L,  
   SCC_STATUS_CONTROLLED       = 0x0001L,  
   SCC_STATUS_CHECKEDOUT       = 0x0002L,  
   SCC_STATUS_OUTOTHER         = 0x0004L,  
   SCC_STATUS_OUTEXCLUSIVE     = 0x0008L,  
   SCC_STATUS_OUTMULTIPLE      = 0x0010L,  
   SCC_STATUS_OUTOFDATE        = 0x0020L,  
   SCC_STATUS_DELETED          = 0x0040L,  
   SCC_STATUS_LOCKED           = 0x0080L,  
   SCC_STATUS_MERGED           = 0x0100L,  
   SCC_STATUS_SHARED           = 0x0200L,  
   SCC_STATUS_PINNED           = 0x0400L,  
   SCC_STATUS_MODIFIED         = 0x0800L,  
   SCC_STATUS_OUTBYUSER        = 0x1000L  
   SCC_STATUS_NOMERGE          = 0x2000L  
   SCC_STATUS_RESERVED_1       = 0x4000L  
   SCC_STATUS_RESERVED_2       = 0x8000L  
};  
```  
  
## Members  
 SCC_STATUS_INVALID  
 Status could not be obtained; do not rely on it.  
  
 SCC_STATUS_NOTCONTROLLED  
 File is not under source control.  
  
 SCC_STATUS_CONTROLLED  
 File is under source control.  
  
 SCC_STATUS_CHECKEDOUT  
 Checked out by current user on local disk.  
  
 SCC_STATUS_OUTOTHER  
 File is checked out by another user.  
  
 SCC_STATUS_OUTEXCLUSIVE  
 File is exclusively checked out.  
  
 SCC_STATUS_OUTMULTIPLE  
 File is checked out by more than one user.  
  
 SCC_STATUS_OUTOFDATE  
 The file is not the most recent.  
  
 SCC_STATUS_DELETED  
 File has been deleted from the project.  
  
 SCC_STATUS_LOCKED  
 File is locked; no more versions allowed.  
  
 SCC_STATUS_MERGED  
 File has been merged but not yet fixed/verified.  
  
 SCC_STATUS_SHARED  
 File is shared between projects.  
  
 SCC_STATUS_PINNED  
 File is shared to an explicit version.  
  
 SCC_STATUS_MODIFIED  
 File has been modified/broken/violated.  
  
 SCC_STATUS_OUTBYUSER  
 File is checked out by current user.  
  
 SCC_STATUS_NOMERGE  
 File can never be merged with and need not be saved before a GET.  
  
 SCC_STATUS_RESERVED_1  
 Reserved for internal use.  
  
 SCC_STATUS_RESERVED_2  
 Reserved for internal use.  
  
## See also  
 [Source Control Plug-ins](../extensibility/source-control-plug-ins.md)   
 [SccQueryInfo](../extensibility/sccqueryinfo-function.md)   
 [POPLISTFUNC](../extensibility/poplistfunc.md)
