---
title: "GetFileHash  Task | Microsoft Docs"
description: Learn to use the MSBuild GetFileHash task to compute checksums of the contents of a file or set of files.
ms.custom: SEO-VS-2020
ms.date: "01/28/2019"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "GetFileHash task [MSBuild]"
  - "MSBuild, GetFileHash task"
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# GetFileHash task

Computes checksums of the contents of a file or set of files.

This task was added in 15.8, but requires a [workaround](https://github.com/Microsoft/msbuild/pull/3999#issuecomment-458193272) to use for MSBuild versions below 16.0.

## Task parameters

 The following table describes the parameters of the `GetFileHash` task.

|Parameter|Description|
|---------------|-----------------|
|`Files`|Required <xref:Microsoft.Build.Framework.ITaskItem>`[]` parameter.<br /><br />The files to be hashed.|
|`Items`|<xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br />The `Files` input with additional metadata set to the file hash.|
|`Hash`|`String` output parameter.<br /><br />The hash of the file. This output is only set if there was exactly one item passed in.|
|`Algorithm`|Optional `String` parameter.<br /><br />The algorithm. Allowed values: `SHA256`, `SHA384`, `SHA512`. Default = `SHA256`.|
|`MetadataName`|Optional `String` parameter.<br /><br />The metadata name where the hash is stored in each item. Defaults to `FileHash`.|
|`HashEncoding`|Optional `String` parameter.<br /><br />The encoding to use for generated hashes. Defaults to `hex`. Allowed values = `hex`, `base64`.|

## Example

The following example uses the `GetFileHash` task to determine and print the checksum of the `FilesToHash` items.

```xml
<Project>
  <ItemGroup>
    <FilesToHash Include="$(MSBuildThisFileDirectory)\*" />
  </ItemGroup>
  <Target Name="GetHash">
    <GetFileHash Files="@(FilesToHash)">
      <Output
          TaskParameter="Items"
          ItemName="FilesWithHashes" />
    </GetFileHash>

    <Message Importance="High"
             Text="@(FilesWithHashes->'%(Identity): %(FileHash)')" />
  </Target>
</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)

- [Task reference](../msbuild/msbuild-task-reference.md)