---
title: "Print Command"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "debug.print"
helpviewer_keywords: 
  - "Debug.Print command"
  - "Print method"
  - "Print command"
ms.assetid: 0412d381-590a-483f-bab4-6e1cca095645
caps.latest.revision: 10
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
# Print Command
Evaluates an expression, or displays specified text.  
  
## Syntax  
  
```  
Debug.Print text  
```  
  
## Arguments  
 `text`  
 Required. The expression to evaluate or the text to display.  
  
## Remarks  
 You can use the question mark (?) as an alias for this command. So, for example, the command  
  
```  
>Debug.Print expA  
```  
  
 can also be written  
  
```  
>? expA  
```  
  
 Both versions of this command will return the current value of the expression `expA`.  
  
## Example  
  
```  
>Debug.Print varA  
```  
  
## See Also  
 [Evaluate Statement Command](../reference/evaluate-statement-command.md)   
 [Visual Studio Commands](../reference/visual-studio-commands.md)   
 [Command Window](../reference/command-window.md)   
 [Find/Command Box](../ide/find-command-box.md)   
 [Visual Studio Command Aliases](../reference/visual-studio-command-aliases.md)