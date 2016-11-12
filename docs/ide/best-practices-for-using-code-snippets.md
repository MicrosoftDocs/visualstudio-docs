---
title: "Best Practices for Using Code Snippets | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "code snippets, best practices"
  - "code snippets, security"
ms.assetid: a293ec17-4dd7-4a99-8eeb-99f44a822a8b
caps.latest.revision: 22
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
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
# Best Practices for Using Code Snippets
The code in a code snippet shows only the most basic way to do something. For most applications, the code must be modified to suit the application.  
  
## Handling Exceptions  
 Typically, code snippet Try…Catch blocks catch and rethrow all exceptions. That may not be the right choice for your project. For each exception, there are several ways to respond. For examples, see [How to: Handle an Exception Using try/catch (C# Programming Guide)](../Topic/How%20to:%20Handle%20an%20Exception%20Using%20try-catch%20\(C%23%20Programming%20Guide\).md) and [Try...Catch...Finally Statement](/dotnet/visual-basic/language-reference/statements/try-catch-finally-statement).  
  
## File Locations  
 When you adapt file locations to your application, you should think about the following:  
  
-   Finding an accessible location. Users may not have access to the Program Files folder of the computer, so storing files with the application files may not work.  
  
-   Finding a secure location. Storing files in the root folder (C:\\) is not secure. For application data, we recommend the \Application Data folder. For individual user data, the application can create a file for each user in the \My Documents folder.  
  
-   Using a valid file name. You can use the <xref:System.Windows.Forms.OpenFileDialog> and <xref:System.Windows.Forms.SaveFileDialog> controls to reduce the likelihood of invalid file names. Be aware that between the time the user selects a file and the time your code manipulates the file, the file may be deleted. In addition, the user may not have permissions to write to the file.  
  
## Security  
 How secure a snippet is depends on where it is used in the source code and how it is modified once it is in the code. The following list contains a few of the areas that must be considered.  
  
-   File and database access  
  
-   Code access security  
  
-   Protecting resources (such as event logs, registry)  
  
-   Storing secrets  
  
-   Verifying inputs  
  
-   Passing data to scripting technologies  
  
 For more information, see [Securing Applications](../ide/securing-applications.md).  
  
## Downloaded Code Snippets  
 IntelliSense code snippets installed by Visual Studio are not in themselves a security hazard. However, they can create security risks in your application. Snippets downloaded from the Internet should be treated like any other downloaded content - with extreme caution.  
  
-   Download snippets only from sites you trust, and use up-to-date virus software.  
  
-   Open all downloaded snippet files in Notepad or the XML editor of Visual Studio and review them carefully before installing them. Look for the following issues:  
  
    -   The snippet code could damage your system if you execute it. Read the source code carefully before running it.  
  
    -   The Help URL block of the snippet file can contain URLs that execute a malicious script file or display an offensive Web site.  
  
    -   The snippet may contain references that are added silently to your project and may be loaded from anywhere on your system. These references may have been downloaded to your computer from where you downloaded the snippet. The snippet may then make a call to a method in the reference that executes malicious code. To protect yourself against such an attack, review the Imports and References blocks of the snippet file.  
  
## See Also  
 [Visual Basic IntelliSense Code Snippets](/dotnet/visual-basic/developing-apps/using-ide/intellisense-code-snippets)   
 [Securing Applications](../ide/securing-applications.md)   
 [Code Snippets](../ide/code-snippets.md)