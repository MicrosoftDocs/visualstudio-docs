---
title: Web Site Support Attributes
description: Learn about the web site support attributes that are necessary for extending the functionality of Visual Studio using web site projects.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- web site projects, registration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Web Site Support Attributes

Visual Studio Web site project can be extended to provide support for Web programming languages. The language must register itself with Visual Studio so that project templates can appear in the **New Web Site** dialog box when the language is selected.

The IronPython Studio sample includes web site support. The sample contains the following attribute classes to register IronPython as a codebehind language for new Web projects.

## WebSiteProjectAttribute
 This attribute is placed on the language project. It adds the language to the list of Web programming languages in the **Language** list in the **New Web Site** dialog box. For example, the following code adds IronPython to the list:

```
[WebSiteProject("IronPython", "Iron Python")]
public class PythonProjectPackage : ProjectPackage
```

 This attribute also sets the templates path to point to the templates folder. For more information on the location of the templates folder, see [Web Site Support Templates](../../extensibility/internals/web-site-support-templates.md).

## WebSiteProjectRelatedFilesAttribute
 This attribute is placed on the language project. It allows the Web Site project to nest one file type (related) under another file type (primary) in the **Solution Explorer**.

 For example, the following code specifies that an IronPython codebehind file is related to an .aspx file. When a new .aspx Web page is created in an IronPython Web site solution, a new .py source file is generated and appears as a child node of the .aspx page.

```
[WebSiteProjectRelatedFiles("aspx", "py")]
public class PythonProjectPackage : ProjectPackage
```

## ProvideIntellisenseProviderAttribute
 This attribute is placed on the language project package. It selects the IntelliSense provider for the language.

 For example, the following code specifies that an instance of PythonIntellisenseProvider, which implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsIntellisenseProject>, should be created on demand to provide language services.

```
[ProvideIntellisenseProvider(typeof(PythonIntellisenseProvider), "IronPythonCodeProvider", "Iron Python", ".py", "IronPython;Python", "IronPython")]
public class PythonPackage : Package, IOleComponent
```

 The IVsIntellisenseProject implementation handles references and calls the language compiler when a Web page with code is requested but isn't cached.

## See also
- [Web Site Support](../../extensibility/internals/web-site-support.md)
