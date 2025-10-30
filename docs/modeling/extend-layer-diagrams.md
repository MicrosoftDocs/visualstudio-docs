---
title: Extend dependency diagrams
description: Learn how you can write code to create and update dependency diagrams, and how to validate the structure of your program code against dependency diagrams in Visual Studio.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- dependency diagrams, creating extensions
- layer models
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Extend dependency diagrams

You can write code to create and update dependency diagrams and to validate the structure of your program code against dependency diagrams in Visual Studio. You can add commands that appear in the shortcut (context) menu of the diagrams, customize drag-and-drop gestures, and access the layer model from text templates. You can package these extensions into a Visual Studio Integration Extension (VSIX) and distribute them to other Visual Studio users.

## Requirements

You must have the following installed on the computer where you want to develop your layer extensions:

- Visual Studio

- [Visual Studio SDK](../extensibility/visual-studio-sdk.md)

- Modeling SDK for Visual Studio

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

You must have a suitable edition of Visual Studio installed on the computer where you want to run your layer extensions. To see which editions of Visual Studio support dependency diagrams, see [Edition support for architecture and modeling tools](../modeling/analyze-and-model-your-architecture.md#VersionSupport).

## Related content

- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)
- [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)
- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)
- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)
