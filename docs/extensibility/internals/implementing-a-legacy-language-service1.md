---
title: "Implementing a Legacy Language Service1 | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "language services, managed"
ms.assetid: df638f24-166d-4b80-be82-c9c39ca7a556
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Implementing a Legacy Language Service
You can use classes in the managed package framework (MPF) to implement a legacy language service that supports a wide variety of features, such as syntax highlighting, brace matching, and IntelliSense completion.

 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement a language service, see [Editor and Language Service Extensions](../../extensibility/editor-and-language-service-extensions.md).

> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.

## In This Section
- [Legacy Language Service Overview](../../extensibility/internals/legacy-language-service-overview.md)

 An overview of the language service features that are supported in MPF.

- [Implementing a Legacy Language Service](../../extensibility/internals/implementing-a-legacy-language-service2.md)

 Describes what is required to implement a language service by using MPF.

- [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md)

 Describes the steps that are required to register an MPF-based language service with [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].

- [Legacy Language Service Parser and Scanner](../../extensibility/internals/legacy-language-service-parser-and-scanner.md)

 Describes the two parsers that are required to implement all the features of a language service by using the MPF.

- [Walkthrough: Creating a Legacy Language Service](../../extensibility/internals/walkthrough-creating-a-legacy-language-service.md)

 Provides the basic steps that are required to implement an MPF language service in a VSPackage.

- [Walkthrough: Getting a List of Installed Code Snippets (Legacy Implementation)](../../extensibility/internals/walkthrough-getting-a-list-of-installed-code-snippets-legacy-implementation.md)

 Demonstrates the techniques of retrieving a list of installed code snippets.

- [Legacy Language Service Features](../../extensibility/internals/legacy-language-service-features1.md)

 Provides links to topics that detail what must be done to implement all the features of a language service by using MPF.