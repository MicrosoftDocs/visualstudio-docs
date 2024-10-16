---
title: "Edit and Continue Not Supported for F#"
description: Edit and Continue is not supported for F# debugging. Edits to code during debugging aren't applied to the source, so the code being debugged won't match the source.
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Edit and Continue [F#]"
  - "Debugging [F#], Edit and Continue"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Edit and Continue Not Supported for F# #

Edit and Continue is not supported when you debug F# code. Edits to F# code are possible during a debugging session but should be avoided. Code changes are not applied during the debugging session. Therefore, any edits made to F# code while you debug will result in source code that does not match the code being debugged.
