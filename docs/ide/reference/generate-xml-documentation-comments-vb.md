---
title: "Generate XML documentation comments for Visual Basic | Microsoft Docs"
ms.custom: ""
ms.date: "11/17/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.tgt_pltfrm: ""
ms.topic: "article"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Generate XML documentation comments in Visual Basic

**What:** Lets you immediately generate the base XML required to document the selected element. 

**When:** You want to create XML Document Comments for later processing by a documentation tool like Sandcastle.

**Why:** You could manually create the entire comment block yourself, however this will save time and improve accuracy by generating the base template and additional elements. 

**How:**

1. Place your text cursor above the element you want to document, for example, a method.

   ![Method to document](media/doc-highlight-vb.png)

1. Next, type **'''** (3 single quotes) which will automatically create the base template and any additional elements as necessary.  For example, when commenting a method, it will generate the **\<summary\>** tags as well as a **\<param\>** tag for every parameter that is passed to the method, and a **\<returns\>** tag to document what the method returns.

   ![Template](media/doc-preview-vb.png)

1. Complete the comments and add any additional information you feel is necessary.

   ![Completed comment](media/doc-result-vb.png)

## See also

[Documenting Your Code with XML (Visual Basic)](/dotnet/visual-basic/programming-guide/program-structure/documenting-your-code-with-xml)  
[Code Generation](../code-generation-in-visual-studio.md)