---
title: "Encodings and Line Breaks | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.Encoding"
helpviewer_keywords: 
  - "line breaks"
  - "encoding"
  - "Visual Studio, encoding"
  - "editors, line breaks"
  - "line break characters"
  - "Visual Studio, line break characters"
ms.assetid: 8f9b3ffc-7b8d-44f4-87cb-dc29105be12d
caps.latest.revision: 8
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
# Encodings and Line Breaks
In Visual Studio you can use the **File/Advanced Save Options** settings to determine the type of line break characters you want. You can also change the encoding of a file with the same settings.  
  
> [!NOTE]
>  If you have certain types of development settings (Visual Basic, F#, Web Development) you may not see **Advanced Save Options** on the menu. To change your settings (for example to General), open **Tools / Import and Export Settings**. For more information, see [Customizing Development Settings in Visual Studio](http://msdn.microsoft.com/en-us/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 In Visual Studio the following characters are interpreted as line breaks:  
  
-   CRLF: Carriage return + line feed, Unicode characters 000D + 000A  
  
-   LF: Line feed, Unicode character 000A  
  
-   NEL: Next line, Unicode character 0085  
  
-   LS: Line separator, Unicode character 2028  
  
-   PS: Paragraph separator, Unicode character 2029  
  
 Text that is copied from other applications keeps the original encoding and line break characters. For example, when you copy text from Notepad and paste it into a text file in Visual Studio, the text has the same settings that it had in Notepad.  
  
 When you open a file that has a different line break characters, you may see a dialog box that asks whether the inconsistent line break characters should be normalized and which type of line breaks to choose.