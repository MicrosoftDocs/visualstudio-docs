---
title: "VerifyFileHash  Task | Microsoft Docs"
description: Learn how MSBuild uses the VerifyFileHash task to verify that a file matches the expected file hash, and fails if it doesn't match.
ms.custom: SEO-VS-2020
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
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
  - "multiple"
---
# VerifyFileHash task

Verifies that a file matches the expected file hash. If the hash doesn't match, the task fails.

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

On MSBuild 16.5 and later, if you don't want the build to fail when the hash doesn't match, such as if you are using the hash comparison as a condition for control flow, you can downgrade the warning to a message using the following code:

```xml
  <PropertyGroup>
    <MSBuildWarningsAsMessages>$(MSBuildWarningsAsMessages);MSB3952</MSBuildWarningsAsMessages>
  </PropertyGroup>

  <Target Name="DemoVerifyCheck">
    <VerifyFileHash File="$(MSBuildThisFileFullPath)"
                    Hash="1"
                    ContinueOnError="WarnAndContinue" />

    <PropertyGroup>
      <HashMatched>$(MSBuildLastTaskResult)</HashMatched>
    </PropertyGroup>

    <Message Condition=" '$(HashMatched)' != 'true'"
             Text="The hash didn't match" />

    <Message Condition=" '$(HashMatched)' == 'true'"
             Text="The hash did match" />
  </Target>
```

## See also

- [Tasks](../msbuild/msbuild-tasks.md)
- [Task reference](../msbuild/msbuild-task-reference.md)
