---
title: "Generate XML documentation comments - Code Generation (C#) | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d2025bd2-5984-4486-a61c-0a0933a735ea
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "dotnet"
---

# Generate XML documentation comments in C# #
**What:** Lets you immediately generate the base XML required to document the selected element. 

**When:** You want to create XML Document Comments for later processing by a documentation tool like Sandcastle.

**Why:** You could manually create the entire comment block yourself, however this will save time and improve accuracy by generating the base template and additional elements. 

**How:**

1. Place your text cursor above the element you want to document, for example, a method.

   ![Method to document](media/doc-highlight-cs.png)

1. Next, type **///** (3 forward slashes) which will automatically create the base template and any additional elements as necessary.  For example, when commenting a method, it will generate the **\<summary\>** tags as well as a **\<param\>** tag for every parameter that is passed to the method, and a **\<returns\>** tag to document what the method returns.

   ![Template](media/doc-preview-cs.png)

1. Complete the comments and add any additional information you feel is necessary.

   ![Completed comment](media/doc-result-cs.png)

## See also

[Code Generation](../code-generation-in-visual-studio.md)  
[XML Documentation Comments (C# Programming Guide)](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)
