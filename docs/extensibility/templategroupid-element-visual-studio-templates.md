---
title: TemplateGroupID Element (Visual Studio Templates)
description: Learn about the TemplateGroupID element and how it specifies what kind of project an item templates will show up in.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#TemplateGroupID
helpviewer_keywords:
- TemplateGroupID element [Visual Studio Templates]
- <TemplateGroupID> element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# TemplateGroupID Element (Visual Studio Templates)

Specifies what kind of project an item templates will show up in. This element is significant when [ShowByDefault (Visual Studio Templates)](../extensibility/showbydefault-visual-studio-templates.md) is set to `false`. When [ShowByDefault (Visual Studio Templates)](../extensibility/showbydefault-visual-studio-templates.md) is set to `true`, then an item template is available in all project types.

 \<VSTemplate>
 \<TemplateData>
 \<TemplateGroupID>

## Syntax

```
<TemplateGroupID> ... </TemplateGroupID>
```

## Attributes and Elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child Elements
 None.

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text Value
 A text value is required.

 The text specifies an identifier for a category of item templates.

## Remarks
 `TemplateGroupID` is an element.

 The value of the `TemplateGroupID` element is used along with project system registration (HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<version number>*\Projects\\) to filter templates that appear in the **Add New Item** dialog box.

|Visual C++ Value|Meaning|
|------------------------|-------------|
|VC-Native|Used for native projects. Also the default if a project type can't be determined.|
|VC-Managed|Used for managed (/clr) projects|
|VC-Windows|Used for all projects that target the windows platform (native/managed/store)|
|WinRT-Native-UAP|Used for Windows 10 store projects|
|CodeSharing-Native|Used for Shared item projects|
|WinRT-Native-6.3|Used for Windows 8.1 Store projects|
|WinRT-Native-Phone-6.3|Used for Windows Phone 8.1 projects|
|WinRT-Native|Used for Windows 8.0 Store projects|
|VC-Android|Used for Android projects|

## See also
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
