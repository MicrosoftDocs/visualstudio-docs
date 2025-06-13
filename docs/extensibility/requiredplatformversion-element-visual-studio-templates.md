---
description: "Specifies the minimum version of the operating system that the project template requires to work correctly."
title: RequiredPlatformVersion Element (Visual Studio Templates)
titleSuffix: ""
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# RequiredPlatformVersion element (Visual Studio templates)

Specifies the minimum version of the operating system that the project template requires to work correctly. This element is used to for project templates that create Windows 8.x Store apps.

 The `RequiredPlatformVersion` value is compared directly with the version of the operating system. If the `RequiredPlatformVersion` is higher than the operating system version, the template does not appear in the **New Project** dialog box. To specify a template for Windows 8 or higher, set `RequiredPlatformVersion` to 6.2.0. To specify a template for Windows 8.1 or higher, set `RequiredPlatformVersion` to 6.3.0.

 Templates that specify `RequiredPlatformVersion`=8 are compatible with previous customer Windows 8.x Store templates.

 VSTemplate
TemplateData
.....TargetPlatformName
RequiredPlatformVersion

## Syntax

```xml
<RequiredPlatformVersion> OperatingSystem </RequiredPlatformVersion>
```

## Attributes and elements

 None.

### Attributes

 None.

### Child elements

 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplatePlatformName](../extensibility/templatedata-element-visual-studio-templates.md)|Specifies the platform that the project template targets.|

## Text value

 A text value is required.

## Remarks

 This text specifies the minimum operating system version required by the template.

## Example

 This example specifies that the project template targets Windows 8 or later.

```xml
<VSTemplate Type="Project" Version="3.0.0"    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <TargetPlatformName>Windows</TargetPlatformName>
            <RequiredPlatformVersion>6.3.0</RequiredPlatformVersion>

    </TemplateData>
    <TemplateContent>

    </TemplateContent>
</VSTemplate>
```

## See also

- [TargetPlatformName element (Visual Studio templates)](../extensibility/targetplatformname-element-visual-studio-templates.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
