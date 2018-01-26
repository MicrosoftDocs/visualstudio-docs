---
title: "Insert XML documentation comments in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "11/16/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.topic: "article"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "dotnet"
---
# How to: Insert XML comments for documentation generation

The **Insert Comment** command applies to:

- C#

- Visual Basic

Visual Studio can help you document code elements such as classes and methods, by automatically generating the standard XML comment structure. XML comments can be processed into reference documentation by tools like [Sandcastle](https://www.microsoft.com/download/details.aspx?id=10526). You can also manually craft the comment block yourself, however this will take additional time and have lower accuracy.

## To insert XML comments for a code element

1. Place your text cursor above the element you want to document, for example, a method.

1. Do one of the following:

   - Type `///` in C#, or `'''` in Visual Basic

   - From the **Edit** menu, choose **IntelliSense** > **Insert Comment**

   - From the right-click or context menu on or just above the code element, choose **Snippet** > **Insert Comment**

   The XML template is immediately generated above the code element. For example, when commenting a method, it generates the **\<summary\>** element, a **\<param\>** element for each parameter, and a **\<returns\>** element to document the return value.

   ![XML comment template - C#](media/doc-preview-cs.png)

   ![XML comment template - Visual Basic](media/doc-preview-vb.png)

1. Enter descriptions for each XML element to fully document the code element.

   ![Completed comment](media/doc-result-cs.png)

> [!NOTE]
> There is an [option](../../ide/reference/options-text-editor-csharp-advanced.md) to toggle XML documentation comments after typing `///` in C# or `'''` Visual Basic. From the menu bar, choose **Tools** > **Options** to open the **Options** dialog box. Then, navigate to **Text Editor** > **C#** or **Basic** > **Advanced**. In the **Editor Help** section, look for the **Generate XML documentation comments** option.

## See also

[XML Documentation Comments (C# Programming Guide)](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)  
[Documenting your code with XML comments (C# Guide)](/dotnet/csharp/codedoc)  
[Code Generation](../code-generation-in-visual-studio.md)  
[XML Documentation Comments (C# Programming Guide)](/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments)
