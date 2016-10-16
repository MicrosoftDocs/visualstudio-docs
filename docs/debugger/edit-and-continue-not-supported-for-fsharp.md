---
title: "Edit and Continue Not Supported for F#"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Edit and Continue [F#]"
  - "Debugging [F#], Edit and Continue"
ms.assetid: 40ec77bb-07e3-4b58-9254-ae015009441c
caps.latest.revision: 8
ms.author: "mikejo"
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
# Edit and Continue Not Supported for F#
Edit and Continue is not supported when you debug F# code. Edits to F# code are possible during a debugging session but should be avoided. Code changes are not applied during the debugging session. Therefore, any edits made to F# code while you debug will result in source code that does not match the code being debugged.