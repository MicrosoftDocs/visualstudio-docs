---
title: Access the DTE Object from an editor extension
ms.date: 04/24/2019
ms.topic: conceptual
helpviewer_keywords:
  - "editors [Visual Studio SDK], new - getting the DTE object"
ms.assetid: c1f40bab-c6ec-45b0-8333-ea5ceb02a39d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Walkthrough: Access the DTE object from an editor extension

In VSPackages, you can get the DTE object by calling the <xref:Microsoft.VisualStudio.Shell.Package.GetService%2A> method with the type of the DTE object. In Managed Extensibility Framework (MEF) extensions, you can import <xref:Microsoft.VisualStudio.Shell.SVsServiceProvider> and then call the <xref:Microsoft.VisualStudio.Shell.ServiceProvider.GetService%2A> method with a type of <xref:EnvDTE.DTE>.

## Prerequisites

To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

## Get the DTE object

1. Create a C# VSIX project and name it **DTETest**. Add an **Editor Classifier** item template and name it **DTETest**.

   For more information, see [Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md).

::: moniker range=">=vs-2019"

2. Add the following assembly reference to the project:

    - Microsoft.VisualStudio.Shell.Immutable.10.0

3. In the *DTETestProvider.cs* file, add the following `using` directives:

    ```csharp
    using EnvDTE;
    using Microsoft.VisualStudio.Shell;
    ```

4. In the `DTETestProvider` class, import an <xref:Microsoft.VisualStudio.Shell.SVsServiceProvider>.

    ```csharp
    [Import]
    internal SVsServiceProvider ServiceProvider = null;
    ```

5. In the `GetClassifier()` method, add the following code before the `return` statement:

    ```csharp
   ThreadHelper.ThrowIfNotOnUIThread();
   DTE dte = (DTE)ServiceProvider.GetService(typeof(DTE));
   ```

::: moniker-end

::: moniker range="vs-2017"

2. Add the following assembly references to the project:

   - EnvDTE
   - Microsoft.VisualStudio.Shell.Framework

3. In the *DTETestProvider.cs* file, add the following `using` directives:

    ```csharp
    using EnvDTE;
    using Microsoft.VisualStudio.Shell;
    ```

4. In the `DTETestProvider` class, import an <xref:Microsoft.VisualStudio.Shell.SVsServiceProvider>.

    ```csharp
    [Import]
    internal SVsServiceProvider ServiceProvider = null;
    ```

5. In the `GetClassifier()` method, add the following code before the `return` statement:

    ```csharp
   DTE dte = (DTE)ServiceProvider.GetService(typeof(DTE));
   ```

::: moniker-end

## See also

- [Language service and editor extension points](../extensibility/language-service-and-editor-extension-points.md)
- [Launch Visual Studio using DTE](launch-visual-studio-dte.md)