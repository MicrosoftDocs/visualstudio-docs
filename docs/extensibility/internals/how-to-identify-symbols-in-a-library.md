---
title: 'Identify Symbols in a Library'
description: Learn how to identify symbols in a library by implementing methods that pass navigation information from the symbol library to the Visual Studio object manager. 
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Call Browser tool, identifying symbols in the library
- Call Browser tool
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Identify symbols in a library

Symbol-browsing tools display hierarchical views of symbols. The symbols represent namespaces, objects, classes, class members, and other language elements.

 Each symbol in the hierarchy can be identified by the navigation information passed by the symbol library to the Visual Studio object manager through the following interfaces:

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsNavInfo>

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsNavInfoNode>

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsEnumNavInfoNodes>.

 The location of the symbol in the hierarchy distinguishes a symbol. It allows symbol-browsing tools to navigate to a specific symbol. The unique, fully qualified path to the symbol determines the location. Each element in the path is a node. The path starts with the top-level node and ends with the specific symbol. For example, if the M1 method is a member of the C1 class and C1 is in N1 namespace, the full path of the M1 method is N1.C1.M1. This path contains three nodes: N1, C1, and M1.

 The navigation information allows the Visual Studio object manager to locate, select, and keep selected the symbols in the hierarchy. It allows navigating from one browsing tool to another. While using **Object Browser** to browse symbols in a Visual C++ project, you can right-click a method and start the **Call Browser** tool to display the method in a call graph.

 Two forms describe the symbol location. The canonical form is based on the fully qualified path of the symbol. It represents a unique position of the symbol in the hierarchy. It is independent of the symbol-browsing tool. To obtain the canonical form information, the Visual Studio object manager calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsNavInfo.EnumCanonicalNodes%2A> method. The presentation form describes the location of the symbol within a specific symbol-browsing tool. The position of the symbol is relative to the position of other symbols in the hierarchy. A given symbol may have several presentation paths, but only one canonical path. For example, if C1 class is inherited from C2 class and both classes are in N1 namespace, the **Object Browser** displays the following hierarchical tree:

```
N1
    C1
        Bases and Interfaces
            C2
    C2
        Bases and Interfaces
. . . . . . . . . . .

```

 The canonical path of C2 class, in this example, is N1 + C2. The presentation path of C2 includes C1 and "Bases and Interfaces" nodes: N1 + C1 + "Bases and Interfaces" + C2.

 To obtain the presentation form information, the object manager calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsNavInfo.EnumPresentationNodes%2A> method.

## To obtain canonical and presentation forms information

1. Implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsNavInfo.EnumCanonicalNodes%2A> method.

     The object manager calls this method to obtain the list of nodes contained in the canonical path of the symbol.

    ### [C#](#tab/csharp)
    ```csharp
    public int EnumCanonicalNodes(out Microsoft.VisualStudio.Shell.Interop.IVsEnumNavInfoNodes ppEnum)
    {
        CallBrowserEnumNavInfoNodes EnumNavInfoNodes =
            new CallBrowserEnumNavInfoNodes(m_strMethod);
        ppEnum = (IVsEnumNavInfoNodes)(EnumNavInfoNodes);
        return 0;
    }

    ```

    ### [VB](#tab/vb)
    ```vb
    Public Function EnumCanonicalNodes(ByRef ppEnum As Microsoft.VisualStudio.Shell.Interop.IVsEnumNavInfoNodes) As Integer
        Dim EnumNavInfoNodes As CallBrowserEnumNavInfoNodes = _New CallBrowserEnumNavInfoNodes(m_strMethod)
        ppEnum = CType(EnumNavInfoNodes, IVsEnumNavInfoNodes)
        Return 0
    End Function
    ```
    ---

2. Implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsNavInfo.EnumPresentationNodes%2A> method.

     The object manager calls this method to obtain the list of nodes contained in the presentation path of the symbol.

## Related content
- [Support symbol-browsing tools](../../extensibility/internals/supporting-symbol-browsing-tools.md)
- [How to: Register a library with the object manager](../../extensibility/internals/how-to-register-a-library-with-the-object-manager.md)
- [How to: Expose lists of symbols provided by the library to the object manager](../../extensibility/internals/how-to-expose-lists-of-symbols-provided-by-the-library-to-the-object-manager.md)
