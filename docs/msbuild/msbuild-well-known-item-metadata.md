---
title: MSBuild Well-known Item Metadata | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- MSBuild, item metadata
- MSBuild, well-known item metadata
ms.assetid: b5e791b5-c68f-4978-ad8a-9247d03bb6c0
author: ghogen
ms.author: ghogen
manager: jillfra
ms.workload:
- multiple
---
# MSBuild well-known item metadata

Item metadata are values attached to items. Some are assigned by MSBuild to items when items are create, but you can also define any metadata you need. Some user-defined metadata values have meaning to MSBuild or to some SDKs such as the .NET SDK.

The first table in this article describes the metadata assigned to every item upon creation. The next table shows some optional metadata that has meaning for MSBuild, which you can define to control build behavior. In each example, the following item declaration was used to include the file *C:\MyProject\Source\Program.cs* in the project.

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

The following table describes optional item metadata that have meaning for some MSBuild SDKs or targets, but that are not set by default for every item. You can set these to influence build behavior, but only if the SDK or target files you are using recognize it.

| Item metadata | SDKs | Description |
|---------------| ------- | -------------|
|%(Link)| All |The Visual Studio project system uses `Link` metadata (if present) to alter what shows up in the project tree; you can put a file in a different logical folder structure in **Solution Explorer**.<br />In addition, the `AssignTargetPath` task looks at `Link` to determine where in the output directory to copy a file to, if it’s one of the items that gets copied.|
|%(LinkBase)| .NET Core SDK | Used to set the folder to be used for `Link` metadata for groups of items. |

## See also

- [Items](../msbuild/msbuild-items.md)
- [Batching](../msbuild/msbuild-batching.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
