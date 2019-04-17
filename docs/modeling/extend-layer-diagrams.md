---
title: Extend dependency diagrams
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "dependency diagrams, creating extensions"
  - "layer models"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Extend dependency diagrams

You can write code to create and update dependency diagrams, and to validate the structure of your program code against dependency diagrams in Visual Studio. You can add commands that appear in the shortcut (context) menu of the diagrams, customize drag-and-drop gestures, and access the layer model from text templates. You can package these extensions into a Visual Studio Integration Extension (VSIX) and distribute them to other Visual Studio users.

 For more information about dependency diagrams, see:

- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)

- [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)

- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)

- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)

##  <a name="prereqs"></a> Requirements

You must have the following installed on the computer where you want to develop your layer extensions:

- Visual Studio

- [Visual Studio SDK](../extensibility/visual-studio-sdk.md)

- Modeling SDK for Visual Studio

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

You must have a suitable version of Visual Studio installed on the computer where you want to run your layer extensions.

To see which versions of Visual Studio support dependency diagrams, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## In This Section
 [Add commands and gestures to dependency diagrams](../modeling/add-commands-and-gestures-to-layer-diagrams.md)

 [Add custom architecture validation to dependency diagrams](../modeling/add-custom-architecture-validation-to-layer-diagrams.md)

 [Add custom properties to dependency diagrams](../modeling/add-custom-properties-to-layer-diagrams.md)

## See Also

- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)
- [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)
- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)
- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)
