---
title: "TargetPlatformName Element (Visual Studio Templates) | Microsoft Docs"
ms.date: "11/04/2016"
ms.technology: vs-ide-general
ms.topic: reference
ms.assetid: 3a6b1f45-b5d6-418e-add1-87ee8f15033d
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# TargetPlatformName Element (Visual Studio Templates)
Specifies the platform that the project template targets. This element is used to specify that a project template is used to create [!INCLUDE[win8_appname_long](../debugger/includes/win8_appname_long_md.md)] apps.

## Syntax

```xml
<VSTemplate>
    <TemplateData>
        <TargetPlatformName> OperatingSystem</TargetPlatformName>
```

## Attributes and Elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child Elements

|Element|Description|
|-------------|-----------------|
|[RequiredPlatformVersion](../extensibility/requiredplatformversion-element-visual-studio-templates.md)|Specifies the version of the operation system that the project template targets.|

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text Value
 A text value is required.

## Remarks
 The text must be **Windows**.

## Example
 This example specifies that the project template targets [!INCLUDE[win8](../debugger/includes/win8_md.md)] or later.

```xml
<VSTemplate Type="Project" Version="3.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <TargetPlatformName>Windows</TargetPlatformName>
        <RequiredPlatformVersion>8</RequiredPlatformVersion>
    </TemplateData>
    <TemplateContent> </TemplateContent>
</VSTemplate>
```

## See also
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)