---
title: "Best Practices for Using Code Snippets | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "code snippets, best practices"
  - "code snippets, security"
ms.assetid: a293ec17-4dd7-4a99-8eeb-99f44a822a8b
caps.latest.revision: 26
author: jillre
ms.author: jillfra
manager: jillfra
---
# Best Practices for Using Code Snippets
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The code in a code snippet shows only the most basic way to do something. For most applications, the code must be modified to suit the application.

## Handling Exceptions
 Typically, code snippet Try…Catch blocks catch and rethrow all exceptions. That may not be the right choice for your project. For each exception, there are several ways to respond. For examples, see [How to: Handle an Exception Using try/catch (C# Programming Guide)](https://msdn.microsoft.com/library/ca8e3773-980e-4767-8633-7408540e9818) and [Try...Catch...Finally Statement](https://msdn.microsoft.com/library/d6488026-ccb3-42b8-a810-0d97b9d6472b).

## File Locations
 When you adapt file locations to your application, you should think about the following:

- Finding an accessible location. Users may not have access to the Program Files folder of the computer, so storing files with the application files may not work.

- Finding a secure location. Storing files in the root folder (C:\\) is not secure. For application data, we recommend the \Application Data folder. For individual user data, the application can create a file for each user in the \My Documents folder.

- Using a valid file name. You can use the <xref:System.Windows.Forms.OpenFileDialog> and <xref:System.Windows.Forms.SaveFileDialog> controls to reduce the likelihood of invalid file names. Be aware that between the time the user selects a file and the time your code manipulates the file, the file may be deleted. In addition, the user may not have permissions to write to the file.

## Security
 How secure a snippet is depends on where it is used in the source code and how it is modified once it is in the code. The following list contains a few of the areas that must be considered.

- File and database access

- Code access security

- Protecting resources (such as event logs, registry)

- Storing secrets

- Verifying inputs

- Passing data to scripting technologies

  For more information, see [Securing Applications](../ide/securing-applications.md).

## Downloaded Code Snippets
 IntelliSense code snippets installed by Visual Studio are not in themselves a security hazard. However, they can create security risks in your application. Snippets downloaded from the Internet should be treated like any other downloaded content - with extreme caution.

- Download snippets only from sites you trust, and use up-to-date virus software.

- Open all downloaded snippet files in Notepad or the XML editor of Visual Studio and review them carefully before installing them. Look for the following issues:

  - The snippet code could damage your system if you execute it. Read the source code carefully before running it.

  - The Help URL block of the snippet file can contain URLs that execute a malicious script file or display an offensive Web site.

  - The snippet may contain references that are added silently to your project and may be loaded from anywhere on your system. These references may have been downloaded to your computer from where you downloaded the snippet. The snippet may then make a call to a method in the reference that executes malicious code. To protect yourself against such an attack, review the Imports and References blocks of the snippet file.

## See Also
 [Visual Basic IntelliSense Code Snippets](https://msdn.microsoft.com/library/ffdde4c9-8141-4906-b09b-15181357a643)
 [Securing Applications](../ide/securing-applications.md)
 [Code Snippets](../ide/code-snippets.md)
