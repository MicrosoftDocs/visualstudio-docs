---
title: MSBuild Well-known Item Metadata
description: Learn about MSBuild metadata assigned to every item upon creation, and some optional MSBuild metadata you can define to control build behavior.
ms.date: 12/02/2024
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, item metadata
- MSBuild, well-known item metadata
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild well-known item metadata

Item metadata are values attached to items. Some are assigned by MSBuild to items when items are created, but you can also define any metadata you need. Some user-defined metadata values have meaning to MSBuild, specific tasks, or SDKs such as the .NET SDK.

The table in this article describes the metadata assigned to every item upon creation. The next table shows some optional metadata that has meaning for MSBuild, which you can define to control build behavior. In each example, the following item declaration was used to include the file *C:\MyProject\Source\Program.cs* in the project.

```xml
<ItemGroup>
    <MyItem Include="Source\Program.cs" />
</ItemGroup>
```

|Item metadata|Description|
|-------------------|-----------------|
|%(FullPath)|Contains the full path of the item. For example:<br /><br /> *C:\MyProject\Source\Program.cs*|
|%(RootDir)|Contains the root directory of the item. For example:<br /><br /> *C:\\*|
|%(Filename)|Contains the file name of the item, without the extension. For example:<br /><br /> *Program*|
|%(Extension)|Contains the file name extension of the item. For example:<br /><br /> *.cs*|
|%(RelativeDir)|Contains the path specified in the `Include` attribute, up to the final backslash (\\). For example:<br /><br /> *Source\\*<br /><br /> If the `Include` attribute is a full path, `%(RelativeDir)` begins with the root directory `%(RootDir)`.  For example: <br /><br /> *C:\MyProject\Source\\*|
|%(Directory)|Contains the directory of the item, without the root directory. For example:<br /><br /> *MyProject\\Source\\*|
|%(RecursiveDir)|If the `Include` attribute contains the wildcard \*\*, this metadata specifies the part of the path that replaces the wildcard. For more information on wildcards, see [How to: Select the files to build](../msbuild/how-to-select-the-files-to-build.md).<br /><br /> If the folder *C:\MySolution\MyProject\Source\\* contains the file *Program.cs*, and if the project file contains this item:<br /><br /> `<ItemGroup>`<br /><br /> `<MyItem Include="C:\**\Program.cs" />`<br /><br /> `</ItemGroup>`<br /><br /> then the value of `%(MyItem.RecursiveDir)` would be *MySolution\MyProject\Source\\*.|
|%(Identity)|The item specified in the `Include` attribute. For example:<br /><br /> *Source\Program.cs*|
|%(ModifiedTime)|Contains the timestamp from the last time the item was modified. For example:<br /><br /> `2004-07-01 00:21:31.5073316`|
|%(CreatedTime)|Contains the timestamp from when the item was created. For example:<br /><br /> `2004-06-25 09:26:45.8237425`|
|%(AccessedTime)|Contains the timestamp from the last time the item was accessed.<br /><br /> `2004-08-14 16:52:36.3168743`|
|%(DefiningProjectFullPath)|Contains the full path of the project file (or imported file) that defines this item.|
|%(DefiningProjectDirectory)|Contains the project directory of the project file (or imported file) that defines this item.|
|%(DefiningProjectName)|Contains the name of the project file (or imported file) that defines this item (without the extension).|
|%(DefiningProjectExtension)|Contains the extension of the project file (or imported file) that defines this item. |

## See also

- [Common MSBuild item metadata](common-msbuild-item-metadata.md)
- [Items](../msbuild/msbuild-items.md)
- [Batching](../msbuild/msbuild-batching.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
