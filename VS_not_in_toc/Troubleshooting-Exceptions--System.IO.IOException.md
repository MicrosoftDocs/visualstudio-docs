---
title: "Troubleshooting Exceptions: System.IO.IOException"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 87812daa-0784-43dc-b3dc-6652a960c362
caps.latest.revision: 9
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Troubleshooting Exceptions: System.IO.IOException
A <xref:System.IO.IOException?qualifyHint=False> is thrown when an I/O error, such as failing to read from or write to a file, occurs.  
  
## Associated Tips  
 **Make sure the file and directory exist.**  
 Verify that the directory you are trying to read from/write to exists. Verify that the file you are trying to read from exists.  
  
### Remarks  
 <xref:System.IO.IOException?qualifyHint=False> is the base class for exceptions thrown while accessing information using streams, files and directories.  
  
 The Base Class Library includes the following types, each of which is a derived class of <xref:System.IO.IOException?qualifyHint=False>:  
  
-   <xref:System.IO.DirectoryNotFoundException?qualifyHint=False>  
  
-   <xref:System.IO.EndOfStreamException?qualifyHint=False>  
  
-   <xref:System.IO.FileNotFoundException?qualifyHint=False>  
  
-   <xref:System.IO.FileLoadException?qualifyHint=False>  
  
-   <xref:System.IO.PathTooLongException?qualifyHint=False>  
  
## See Also  
 <xref:System.IO.IOException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)   
 [NOTINBUILD How to: Create CLR Console Applications](assetId:///b8af4197-e65f-4b17-b18e-b9e92965d026)