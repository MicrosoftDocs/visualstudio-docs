---
title: Wizard (.Vsz) File
description: Learn about the .vsz files that the IDE uses to start wizards. The files contain information about which wizard to call and what to pass to the wizard.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- .vsz files
- vsz files
- wizards, files
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Wizard (.Vsz) File

The integrated development environment (IDE) uses .vsz files to start wizards. These .vsz files contain information that the IDE uses to determine which wizard to call and what information to pass to the wizard.

A .vsz file is a version of an .ini-formatted text file that has no sections. Information known to the IDE is stored at the beginning of the file. This provides a link between the wizard that the IDE calls and the parameters that are in the .vsz file to be passed to the IDE. The rest of the file provides parameters that are specific to the wizard and that are to be collected by the IDE and passed to the specific wizard.

The following example shows the contents of a .vsz file.

```
VSWizard 8.0
Wizard=VsWizard.CBlankSiteWizard -or- {123-1234556-123334}
Param="WIZARDNAME = Wizard One"
Param="WIZARDUI = FALSE"
```

Following are the parts in the .vsz file.

|Part|Description|
|----------|-----------------|
|VSWizard|The first parameter in the file is the version number of the template file format. This version number must be 6.0, 7.0, 7.1, or 8.0. Other numbers cannot be started and cause an Invalid Format error.|
|Wizard|This field contains the OLE ProgID of the wizard, or alternatively a GUID string representation of the CLSID of the wizard that is cocreated by the IDE.|
|Param|These parts are optional. You can add as many as needed.|

The parameters enable the .vsz file to pass additional custom parameters to the wizard. Each value is passed as a string element in an array of variants to the wizard. For more information, see [Custom Parameters](../../extensibility/internals/custom-parameters.md).

To add a default locale ID to your .vsz file, specify `FALLBACK_LCID`=xxxx, where xxxx is the locale ID, for example, 1033 for English. When `FALLBACK_LCID` parameter is defined, the wizard uses the supplied fallback locale ID if the current ID is not found.

## See also

- [Custom Parameters](../../extensibility/internals/custom-parameters.md)
- [Wizards](../../extensibility/internals/wizards.md)
- [Template Directory Description (.Vsdir) Files](../../extensibility/internals/template-directory-description-dot-vsdir-files.md)
