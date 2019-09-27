---
title: "VerifyFileHash  Task | Microsoft Docs"
ms.date: "01/28/2019"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "VerifyFileHash task [MSBuild]"
  - "MSBuild, VerifyFileHash task"
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# VerifyFileHash task

Verifies that a file matches the expected file hash.

This task was added in 15.8, but requires a [workaround](https://github.com/Microsoft/msbuild/pull/3999#issuecomment-458193272) to use for MSBuild versions below 16.0.

## Task parameters

 The following table describes the parameters of the `VerifyFileHash` task.

|Parameter|Description|
|---------------|-----------------|
|`File`|Required `String` parameter.<br /><br />The file to be hashed and validated.|
|`Hash`|Required `String` parameter.<br /><br />The expected hash of the file.|
|`Algorithm`|Optional `String` parameter.<br /><br />The algorithm. Allowed values: `SHA256`, `SHA384`, `SHA512`. Default = `SHA256`.|
|`HashEncoding`|Optional `String` parameter.<br /><br />The encoding to use for generated hashes. Defaults to `hex`. Allowed values = `hex`, `base64`.|

## Example

The following example uses the `VerifyFileHash` task to verify its own checksum.

```xml
<Project>
  <Target Name="VerifyHash">
    <GetFileHash Files="$(MSBuildProjectFullPath)">
      <Output
          TaskParameter="Items"
          ItemName="FilesWithHashes" />
    </GetFileHash>

    <Message Importance="High"
             Text="@(FilesWithHashes->'%(Identity): %(FileHash)')" />

    <VerifyFileHash File="$(MSBuildThisFileFullPath)"
                    Hash="$(ExpectedHash)" />
  </Target>
</Project>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)