---
title: Legacy Language Service Features2 | Microsoft Docs
description: Learn about some of the legacy language service features you can provide by using Managed Extensibility Framework (MEF) extensions in the Visual Studio SDK.
ms.custom: SEO-VS-2020 
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- editors [Visual Studio SDK], code development aides
ms.assetid: 97c38622-ae0b-4ae0-90ed-604072c298d3
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# Legacy language service features 2
The following topics list some of the legacy language service features you can provide.

 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement a language service, see [Editor and Language Service Extensions](../../extensibility/editor-and-language-service-extensions.md).

> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.

## In This Section
- [Syntax Coloring in a Legacy Language Service](../../extensibility/internals/syntax-coloring-in-a-legacy-language-service.md)

 Explains how to implement syntax coloring.

- [Automatic Formatting in a Legacy Language Service](../../extensibility/internals/automatic-formatting-in-a-legacy-language-service.md)

 Explains how to implement automatic formatting.

- [Parameter Info in a Legacy Language Service](../../extensibility/internals/parameter-info-in-a-legacy-language-service1.md)

 Explains how to implement the IntelliSense Parameter Info Tooltip.

- [Statement Completion in a Legacy Language Service](../../extensibility/internals/statement-completion-in-a-legacy-language-service.md)

 Explains how to implement the IntelliSense statement list and member completion list.

- [Outlining and Hidden Text in a Legacy Language Service](../../extensibility/internals/outlining-and-hidden-text-in-a-legacy-language-service.md)

 Explains how to implement outlining or hidden text.

- [How to: Provide Expanded Outlining Support in a Legacy Language Service](../../extensibility/internals/how-to-provide-expanded-outlining-support-in-a-legacy-language-service.md)

 Explains some of the steps in implementing debugger support..

## Related Sections
