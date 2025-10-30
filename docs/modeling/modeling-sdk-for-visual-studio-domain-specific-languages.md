---
title: Use the Modeling SDK for Visual Studio
description: Use the Modeling SDK for Visual Studio to create powerful model-based development tools that integrate into Visual Studio.
titleSuffix: ''
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- Domain-Specific Language Tools
- Domain-Specific Language
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Modeling SDK for Visual Studio - Domain-Specific Languages

By using the Modeling SDK for Visual Studio, you can create powerful model-based development tools that you can integrate into Visual Studio. In the same manner, you can create one or more model definitions and integrate them into a set of tools.

At the heart of MSDK is the definition of a model that you create to represent concepts in your business area. You can surround the model with a variety of tools, such as a diagrammatic view, the ability to generate code and other artifacts, commands for transforming the model, and the ability to interact with code and other objects in Visual Studio. As you develop the model, you can combine it with other models and tools to form a powerful toolset that is centered on your development.

MSDK lets you develop a model quickly in the form of a domain-specific language (DSL). You begin by using a specialized editor to define a schema or abstract syntax together with a graphical notation. From this definition, VMSDK generates:

- A model implementation with a strongly-typed API that runs in a transaction-based store.

- A tree-based explorer.

- A graphical editor in which users can view the model or parts of it that you define.

- Serialization methods that save your models in readable XML.

- Facilities for generating program code and other artifacts using text templating.

You can customize and extend all of these features. Your extensions are integrated in such a way that you can still update the DSL definition and re-generate the features without losing your extensions.

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

[Related blog posts](https://devblogs.microsoft.com/devops/the-visual-studio-modeling-sdk-is-now-available-with-visual-studio-2017/)
