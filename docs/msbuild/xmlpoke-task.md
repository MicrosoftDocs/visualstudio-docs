---
title: XmlPoke Task
description: Learn how MSBuild uses the XmlPoke task to set values as specified by an XPath query into an XML file.
ms.date: 1/28/2025
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- XmlPoke task [MSBuild]
- MSBuild, XmlPoke task
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# XmlPoke task

Sets values as specified by an XPath query into an XML file.

## Parameters

 The following table describes the parameters of the `XmlPoke` task.

|Parameter|Description|
|---------------|-----------------|
|`Namespaces`|Optional `String` parameter.<br /><br /> Specifies the namespaces for XPath query prefixes. `Namespaces` is an XML snippet consisting of `Namespace` elements with attributes `Prefix` and `Uri`. The attribute `Prefix` specifies the prefix to associate with the namespace specified in `Uri` attribute. Don't use an empty `Prefix`.|
|`Query`|Optional `String` parameter.<br /><br /> Specifies the XPath query.|
|`Value`|Required <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the value to be inserted into the specified path.|
|`XmlInputPath`|Optional <xref:Microsoft.Build.Framework.ITaskItem> parameter.<br /><br /> Specifies the XML input as a file path.|

## Remarks

 In addition to having the parameters that are listed in the table, this task inherits parameters from the <xref:Microsoft.Build.Tasks.TaskExtension> class, which itself inherits from the <xref:Microsoft.Build.Utilities.Task> class. For a list of these additional parameters and their descriptions, see [TaskExtension base class](../msbuild/taskextension-base-class.md).

## Example

Here's a sample.xml to modify:

```xml
<Package xmlns="http://schemas.microsoft.com/appx/manifest/foundation/windows10"
         xmlns:mp="http://schemas.microsoft.com/appx/2014/phone/manifest"
         xmlns:uap="http://schemas.microsoft.com/appx/manifest/uap/windows10" >
<Identity Name="Sample.Product " Publisher="CN=1234" Version="1.0.0.0" />
<mp:PhoneIdentity PhoneProductId="456" PhonePublisherId="0" />
</Package>
```

In this example, if you want to modify `/Package/mp:PhoneIdentity/PhoneProductId`, then use

```xml
<Project>
  <PropertyGroup>
    <Namespace>
        <Namespace Prefix="dn" Uri="http://schemas.microsoft.com/appx/manifest/foundation/windows10" />
        <Namespace Prefix="mp" Uri="http://schemas.microsoft.com/appx/2014/phone/manifest" />
        <Namespace Prefix="uap" Uri="http://schemas.microsoft.com/appx/manifest/uap/windows10" />
    </Namespace>
</PropertyGroup>

<Target Name="Poke">
  <XmlPoke
    XmlInputPath="Sample.xml"
    Value="MyId"
    Query="/dn:Package/mp:PhoneIdentity/@PhoneProductId"
    Namespaces="$(Namespace)"/>
</Target>
</Project>
```

`dn` is here used as an artificial namespace prefix for the default namespace; you can use it whenever there isn't a specified prefix in the target XML.

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
