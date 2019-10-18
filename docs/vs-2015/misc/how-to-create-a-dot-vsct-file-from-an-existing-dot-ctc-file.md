---
title: "How to: Create a .Vsct File from an Existing .Ctc File | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "VSCT files, creating based on a .ctc file"
ms.assetid: 700e80a4-c1e1-4178-af53-45e86dd2c08b
caps.latest.revision: 9
manager: jillfra
---
# How to: Create a .Vsct File from an Existing .Ctc File
You can create an XML-based .vsct file from an existing command table .ctc source file. By doing this, you can take advantage of the new XML-based [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] command table (VSCT) compiler format.  
  
### To create a .vsct file from a .ctc file  
  
1. Obtain a copy of the Perl language.  
  
2. Obtain a copy of the Perl script ConvertCTCToVSCT.pl, typically located in the *\<Visual Studio SDK installation path>*\VisualStudioIntegration\Tools\bin folder.  
  
3. Obtain a copy of the .ctc source file that you want to convert.  
  
4. Place the files in the same directory.  
  
5. In the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Command Prompt window, navigate to the directory.  
  
6. Type  
  
    ```  
    perl.exe ConvertCTCtoVSCT.pl PkgCmd.ctc PkgCmd.vsct  
    ```  
  
     where PkgCmd.ctc is the name of the .ctc file and PkgCmd.vsct is the name of the .vsct file that you want to create.  
  
     This creates a new .vsct XML command table source file. You can compile the file by using Vsct.exe, the VSCT compiler, as you would any other .vsct file.  
  
    > [!NOTE]
    > You can improve the readability of the .vsct file by reformatting the XML comments.  
  
## See also  
 [How to: Create a .Vsct File](../extensibility/internals/how-to-create-a-dot-vsct-file.md)   
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)