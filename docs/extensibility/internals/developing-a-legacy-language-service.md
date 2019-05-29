---
title: "Developing a Legacy Language Service | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.vsip.LangServWiz.langtoks"
  - "vs.vsip.LangServWiz.welcome"
  - "vs.vsip.LangServWiz.langSpec"
  - "vs.vsip.LangServWiz.langInfo"
  - "vs.vsip.LangServWiz.langServOpts"
helpviewer_keywords:
  - "language services, developing"
ms.assetid: 6151ba88-c1c3-41de-a1cc-668f494d48d1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Develop a legacy language service
This section links to topics that help you create a legacy language service.

 Legacy language services are implemented as part of a VSPackage, but the newer way to implement language service features is to use MEF extensions. To find out more about the new way to implement a language service, see [Editor and language service extensions](../../extensibility/editor-and-language-service-extensions.md).

> [!NOTE]
> We recommend that you begin to use the new editor API as soon as possible. This will improve the performance of your language service and let you take advantage of new editor features.

## In this section
- [Model of a legacy language service](../../extensibility/internals/model-of-a-legacy-language-service.md)

 Provides a model of a minimal language service for the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] core editor. You can use this model as a guide for creating your own language service.

- [Legacy language service interfaces](../../extensibility/internals/legacy-language-service-interfaces.md)

 Discusses the objects required to implement a language service and provides a listing of additional objects that you can use to provide syntax highlighting, method data, and other features.

- [Intercept legacy language service commands](../../extensibility/internals/intercepting-legacy-language-service-commands.md)

 Describes how to insert a command filter into your language service to intercept commands that the text view would otherwise handle.

- [Register a legacy language service](../../extensibility/internals/registering-a-legacy-language-service2.md)

 Provides information about how to register your language service by using [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)].

- [Language service support for debugging](../../extensibility/internals/language-service-support-for-debugging.md)

 Describes how a language service can provide features to support a debugger.

- [Checklist: Create a legacy language service](../../extensibility/internals/checklist-creating-a-legacy-language-service.md)

 Provides step-by-step instructions for creating and integrating a language service for the core editor.

## Related sections
- [Syntax coloring in a legacy language service](../../extensibility/internals/syntax-coloring-in-a-legacy-language-service.md)

 Discusses how to implement syntax highlighting in your language service.

- [Statement completion in a legacy language service](../../extensibility/internals/statement-completion-in-a-legacy-language-service.md)

 Discusses statement completion, the process by which a language service helps users finish a language keyword or element that they have started typing.

- [Parameter Info in a legacy language service](../../extensibility/internals/parameter-info-in-a-legacy-language-service1.md)

 Describes how to provide method tips for overloaded functions and methods.

- [How to: Provide hidden text support in a legacy language service](../../extensibility/internals/how-to-provide-hidden-text-support-in-a-legacy-language-service.md)

 Explains the purpose of a hidden text region and provides instructions about how to implement a hidden text region.

- [How to: Provide expanded outlining support in a legacy language service](../../extensibility/internals/how-to-provide-expanded-outlining-support-in-a-legacy-language-service.md)

 Explains the two options that extend outlining support for your language beyond supporting the *Collapse to Definitions* command.