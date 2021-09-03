---
title: Providing Automation for Code | Microsoft Docs
description: Learn about implementing a code model, which requires implementing interfaces that are determined by your internal data structure.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- CodeModel object
ms.assetid: 21cb3e63-f25c-404b-bc1d-a32ad0fdd4d5
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Providing Automation for Code
Creating an automation model for your code is not required. The Environment SDK does not provide a sample for doing so. For insight into code models, see the <xref:EnvDTE.CodeModel> object.

 To implement a code model, you must implement any interfaces that are determined by your internal data structure. The objects must be derived from the `IDispatch` class.

 The objects that you extend, <xref:EnvDTE.CodeModel> and <xref:EnvDTE.FileCodeModel>, are available from the <xref:EnvDTE.Project> object, and look like the following:

- <xref:EnvDTE.Project.CodeModel%2A>

- <xref:EnvDTE.ProjectItem.FileCodeModel%2A>

 You can elect to implement just the `CodeModel` or the `FileCodeModel` interface in the object you return from your `Project` and <xref:EnvDTE.ProjectItem> objects. Provide any functionality from this interface that is appropriate for your project system.

 If you want to add features, such as methods or properties, that are not available from the standard `CodeModel` and `FileCodeModel` interfaces, create your own interface that inherits from the standard. Be sure to document it with your project system so end users will know to look for it. You return the standard interface, but the user can call the `QueryInterface` method or cast to your interface if it is known to exist.

## See also
- [Automation Model Overview](../../extensibility/internals/automation-model-overview.md)
