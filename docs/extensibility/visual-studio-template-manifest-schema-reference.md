---
title: Visual Studio Template Manifest Schema Reference
description: This schema reference describes the format of the Visual Studio template manifest files that are generated for Visual Studio project or item templates.
ms.date: 11/04/2016
ms.topic: reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Visual Studio template manifest schema reference

This schema describes the format of the Visual Studio template manifest (*.vstman*) files that are generated for Visual Studio project or item templates. The schema also describes the location and other relevant information about the template.

 : Because there are separate item and project template directories, a manifest should never have a mix of item and project templates.

> [!IMPORTANT]
> This manifest is available starting in Visual Studio 2017.

## VSTemplateManifest element
 The root element of the manifest.

### Attributes

- **Version**: A string representing the version of the template manifest. Required.

- **Locale**: A string representing the locale or locales of the template manifest. The locale value applies to all templates. You  must use a separate manifest for each locale. Optional.

### Child elements

- **VSTemplateContainer** Optional.

- **VSTemplateDir** Optional.

### Parent element
 None.

## VSTemplateContainer
 The container of the template manifest elements. A manifest has one template container for each template it defines.

### Attributes
 **VSTemplateType**: A string value that specifies the type of the template (`"Project"`, `"Item"`, or `"ProjectGroup"`). Required

### Child elements

- **RelativePathOnDisk**:  The relative path of the template file on disk. This location also defines the placement of the template in the template tree shown in the **New Project** or **New Item** dialog. For templates deployed as a directory and individual files, this path refers to the directory containing the template files. For templates deployed as a *.zip* file, this path should be the path to the *.zip* file.

- **VSTemplateHeader: A [TemplateData](../extensibility/templatedata-element-visual-studio-templates.md) element that describes the header.

### Parent element
 **VSTemplateManifest**

## VSTemplateDir
 Describes the directory where the template is located. A manifest can contain multiple **VSTemplateDir** entries to provide localized name and sort ordering for directories to control their appearance in template category tree.

 Due to their design, **VSTemplateDir** entries should  appear only in non-locale specified manifests.

### Attributes
 None.

### Child elements

- **RelativePath**: The path of the template. There can  be only one entry per path, so the first one will win for all manifests.

- **LocalizedName**: A **NameDescriptionIcon** element that specifies the localized name. Optional.

- **SortOrder**: A string that specifies the sort order. Optional.

- **ParentFolderOverrideName**: The overridden name of the parent folder. Optional. This element has a **Name** attribute, which is a string value that specifies the name.

### Parent element
 **VSTemplateManifest**

## NameDescriptionIcon
 Specifies the name and description, possibly for localized templates. See **LocalizedName** above.

### Attributes

- **Package**: A string value that specifies the package. Optional.

- **ID**: A string value that specifies the ID. Optional.

### Child elements
 None.

### Parent element
 **LocalizedName**

## Examples
 The following code is an example of a project template *.vstman* file.

```xml
<VSTemplateManifest Version="1.0" Locale="1033" xmlns="http://schemas.microsoft.com/developer/vstemplatemanifest/2015">
  <VSTemplateContainer TemplateType="Project">
    <RelativePathOnDisk>CSharp\1033\TestProjectTemplate</RelativePathOnDisk>
    <TemplateFileName>TestProjectTemplate.vstemplate</TemplateFileName>
    <VSTemplateHeader>
      <TemplateData xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
        <Name>TestProjectTemplate</Name>
        <Description>TestProjectTemplate</Description>
        <Icon>TestProjectTemplate.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <RequiredFrameworkVersion>2.0</RequiredFrameworkVersion>
        <SortOrder>1000</SortOrder>
        <TemplateID>aac0aeea-7883-4003-992f-937d53d70ab1</TemplateID>
        <CreateNewFolder>true</CreateNewFolder>
        <DefaultName>TestProjectTemplate</DefaultName>
        <ProvideDefaultName>true</ProvideDefaultName>
      </TemplateData>
    </VSTemplateHeader>
  </VSTemplateContainer>
</VSTemplateManifest>

```

 The following code is an example of an item template *.vstman* file.

```xml
<VSTemplateManifest Version="1.0" Locale="1033" xmlns="http://schemas.microsoft.com/developer/vstemplatemanifest/2015">
  <VSTemplateContainer TemplateType="Item">
    <RelativePathOnDisk>CSharp\1033\ItemTemplate1</RelativePathOnDisk>
    <TemplateFileName>ItemTemplate1.vstemplate</TemplateFileName>
    <VSTemplateHeader>
      <TemplateData xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
        <Name>ItemTemplate1</Name>
        <Description>ItemTemplate1</Description>
        <Icon>ItemTemplate1.ico</Icon>
        <TemplateID>bfeadf8e-a251-4109-b605-516b88e38c8d</TemplateID>
        <ProjectType>CSharp</ProjectType>
        <RequiredFrameworkVersion>2.0</RequiredFrameworkVersion>
        <NumberOfParentCategoriesToRollUp>1</NumberOfParentCategoriesToRollUp>
        <DefaultName>Class.cs</DefaultName>
      </TemplateData>
    </VSTemplateHeader>
  </VSTemplateContainer>
</VSTemplateManifest>

```
