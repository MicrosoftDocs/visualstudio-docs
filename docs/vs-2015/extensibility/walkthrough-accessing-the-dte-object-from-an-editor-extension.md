---
title: "Walkthrough: Accessing the DTE Object from an Editor Extension | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], new - getting the DTE object"
ms.assetid: c1f40bab-c6ec-45b0-8333-ea5ceb02a39d
caps.latest.revision: 23
ms.author: gregvanl
manager: jillfra
---
# Walkthrough: Accessing the DTE Object from an Editor Extension
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In VSPackages, you can get the DTE object by calling the <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> method with the type of the DTE object. In Managed Extensibility Framework (MEF) extensions, you can import <xref:Microsoft.VisualStudio.Shell.SVsServiceProvider> and then call the <xref:Microsoft.VisualStudio.Shell.ServiceProvider.GetService%2A> method with a type of <xref:EnvDTE.DTE>.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).  
  
## Getting the DTE Object  
  
#### To get the DTE object from the ServiceProvider  
  
1. Create a C# VSIX project named `DTETest`. Add an Editor Classifier item template and name it `DTETest`. For more information, see [Creating an Extension with an Editor Item Template](../extensibility/creating-an-extension-with-an-editor-item-template.md).  
  
2. Add the following assembly references to the project:  
  
    - EnvDTE  
  
    - EnvDTE80  
  
    - Microsoft.VisualStudio.Shell.Immutable.10.0  
  
3. Go to the DTETest.cs file, and add the following `using` directives:  
  
    ```csharp  
    using EnvDTE;  
    using EnvDTE80;  
    using Microsoft.VisualStudio.Shell;  
  
    ```  
  
4. In the `GetDTEProvider` class, import a <xref:Microsoft.VisualStudio.Shell.SVsServiceProvider>.  
  
    ```csharp  
    [Import]  
    internal SVsServiceProvider ServiceProvider = null;  
  
    ```  
  
5. In the `GetClassifier()` method, add the following code.  
  
    ```csharp  
    DTE dte = (DTE)ServiceProvider.GetService(typeof(DTE));  
  
    ```  
  
6. If you have to use the <xref:EnvDTE80.DTE2> interface, you can cast the DTE object to it.  
  
## See Also  
 [Language Service and Editor Extension Points](../extensibility/language-service-and-editor-extension-points.md)
