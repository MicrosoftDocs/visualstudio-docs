---
title: Custom Parameters
description: Learn how to create custom parameters that control the operation of a wizard after a wizard has started, by modifying a .vsz file.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- wizards, custom parameters
- custom parameters
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Custom parameters

Custom parameters control the operation of a wizard after a wizard has started. A related *.vsz* file provides an array of user-defined parameters that are packaged by the integrated development environment (IDE) and passed to the wizard as an array of strings when the wizard is started. The wizard then parses the array of strings and uses the information to control the actual operation of the wizard. In this manner, a wizard can customize functionality depending on the contents of the *.vsz* file.

 Context parameters, on the other hand, define the state of the project when the wizard is started. For more information, see [Context parameters](../../extensibility/internals/context-parameters.md).

 Following is an example of a *.vsz* file that has custom parameters:

```
VSWIZARD 8.0
Wizard=VsWizard.VsWizard_Engine
Param="WIZARD_NAME = Sample Wizard"
Param="WIZARD_UI = FALSE"
Param="RELATIVE_PATH = VSWizards\Classwiz\ATL"
Param="PREPROCESS_FUNCTION = CanAddATLSupport"
Param="PROJECT_TYPE = CSPROJ"
```

 The author of the *.vsz* file adds the values of the parameters. When a user selects **New Project** or **Add New Item** on the **File** menu or by right-clicking a project in **Solution Explorer**, the IDE collects these values into an array of strings. The IDE then calls the project's <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.AddItem%2A> method with the <xref:Microsoft.VisualStudio.Shell.Interop.VSADDITEMOPERATION> flag set, and the project calls the <xref:EnvDTE.IVsExtensibility.RunWizardFile%2A> method that is responsible for running the wizard and returning the result.

 The wizard is responsible for parsing the array of strings and acting on the strings appropriately. In this manner, by implementing custom parameters you can create one wizard that performs a variety of functions. In other words, one wizard could have three different *.vsz* files. Each file passes different sets of custom parameters to control the behavior of the wizard in various situations.

 For more information, see [Wizard (.vsz) file](../../extensibility/internals/wizard-dot-vsz-file.md).

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3>
- [Context parameters](../../extensibility/internals/context-parameters.md)
- [Wizards](../../extensibility/internals/wizards.md)
- [Wizard (.vsz) file](../../extensibility/internals/wizard-dot-vsz-file.md)
