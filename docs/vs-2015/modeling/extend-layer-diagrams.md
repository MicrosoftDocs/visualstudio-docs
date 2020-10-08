---
title: "Extend layer diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "layer diagrams, creating extensions"
  - "layer models"
ms.assetid: 83fca301-b008-485a-87eb-218050e71451
caps.latest.revision: 41
author: jillre
ms.author: jillfra
manager: jillfra
---
# Extend layer diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can write code to create and update layer diagrams, and to validate the structure of your program code against layer diagrams in Visual Studio. You can add commands that appear in the shortcut (context) menu of the diagrams, customize drag-and-drop gestures, and access the layer model from text templates. You can package these extensions into a Visual Studio Integration Extension (VSIX) and distribute them to other Visual Studio users.

 For more information about layer diagrams, see:

- [Layer Diagrams: Reference](../modeling/layer-diagrams-reference.md)

- [Layer Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)

- [Create layer diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)

- [Validate code with layer diagrams](../modeling/validate-code-with-layer-diagrams.md)

## <a name="prereqs"></a> Requirements
 You must have the following installed on the computer where you want to develop your layer extensions:

- Visual Studio

- [Visual Studio SDK](../extensibility/visual-studio-sdk.md)

- [Modeling SDK for Visual Studio 2015](https://www.microsoft.com/download/details.aspx?id=48148)

  You must have a suitable version of Visual Studio installed on the computer where you want to run your layer extensions. For more information, see [Deploy a layer model extension](../modeling/deploy-a-layer-model-extension.md).

  To see which versions of Visual Studio support layer diagrams, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## In This Section
 [Add commands and gestures to layer diagrams](../modeling/add-commands-and-gestures-to-layer-diagrams.md)

 [Add custom architecture validation to layer diagrams](../modeling/add-custom-architecture-validation-to-layer-diagrams.md)

 [Add custom properties to layer diagrams](../modeling/add-custom-properties-to-layer-diagrams.md)

 [Navigate and update layer models in program code](../modeling/navigate-and-update-layer-models-in-program-code.md)

 [Deploy a layer model extension](../modeling/deploy-a-layer-model-extension.md)

 [Troubleshoot extensions for layer diagrams](../modeling/troubleshoot-extensions-for-layer-diagrams.md)

## See Also
 [Define and install a modeling extension](../modeling/define-and-install-a-modeling-extension.md)
 [Layer Diagrams: Reference](../modeling/layer-diagrams-reference.md)
 [Layer Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)
 [Create layer diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)
 [Validate code with layer diagrams](../modeling/validate-code-with-layer-diagrams.md)
 [Generate files from a UML model](../modeling/generate-files-from-a-uml-model.md)
 [Open a UML model by using the Visual Studio API](../modeling/open-a-uml-model-by-using-the-visual-studio-api.md)
