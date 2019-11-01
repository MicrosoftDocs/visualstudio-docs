---
title: "How to: Create a .Vsct File from an Existing .Cto File | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "VSCT files, creating based on a .cto file"
ms.assetid: 847717c9-477d-4ac9-8b2c-2da878912478
caps.latest.revision: 11
manager: jillfra
---
# How to: Create a .Vsct File from an Existing .Cto File
You can create an XML-based .vsct file from an existing binary .cto file. Doing this allows you to take advantage of the new command table compiler format. This process works even if the .cto file was compiled from a .ctc file. You can edit and compile the .vsct file into another .cto file.  
  
### To create a .vsct file from a .cto file  
  
1. Obtain copies of the .cto file and its corresponding .ctsym file.  
  
2. Place the files into the same directory as the vsct.exe compiler.  
  
3. At the Visual Studio Command Prompt, go to the directory that contains the .cto and .ctsym files.  
  
4. Type **vsct.exe** _ctofilename_**.cto** _vsctfilename_**.vsct -S**_symfilename_**.ctsym**.  
  
     `ctofilename` is the name of the .cto file, `vsctfilename` is the name of the vsct file you want to create, and `symfilename` is the name of the .ctsym file.  
  
     This process creates a new .vsct XML command table compiler file. You can edit and compile the file with vsct.exe, the vsct compiler, as you would any other .vsct file.  
  
## See Also  
 [How to: Create a .Vsct File](../extensibility/internals/how-to-create-a-dot-vsct-file.md)   
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)