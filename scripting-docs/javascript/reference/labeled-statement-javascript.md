---
title: "Labeled Statement (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "labeled_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "continue statement"
  - "labeled statement"
  - "identifiers, statements"
ms.assetid: 019f898e-9e27-4be4-a22f-c5927c7fcae2
caps.latest.revision: 19
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Labeled Statement (JavaScript)
Provides an identifier for a statement.  
  
## Syntax  
  
```  
  
      label :  
   statements   
```  
  
## Parameters  
 *label*  
 Required. A unique identifier used when referring to the labeled statement.  
  
 `statements`  
 Optional. One or more statements associated with *label*.  
  
## Remarks  
 Labels are used by the **break** and **continue** statements to specify the statement to which the **break** and **continue** apply.  
  
## Example  
 In the following code, the **continue** statement refers to the **for** loop that is preceded by the `Inner:` statement. When `j` is 24, the **continue** statement causes that **for** loop to go to the next iteration. The numbers 21 through 23 and 25 through 30 print on each line.  
  
```JavaScript  
Outer:  
for (i = 1; i <= 10; i++) {  
   document.write ("<br />");  
   document.write ("i: " + i);  
   document.write (" j: ");  
  
Inner:  
   for (j = 21; j <= 30; j++) {  
      if (j == 24)  
          {  
          continue Inner;  
      }  
      document.write (j + " ");  
  }  
}  
```  
  
## Requirements  
 [!INCLUDE[jsv3](../../javascript/reference/includes/jsv3-md.md)]  
  
## See Also  
 [break Statement](../../javascript/reference/break-statement-javascript.md)   
 [continue Statement](../../javascript/reference/continue-statement-javascript.md)