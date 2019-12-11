---
title: "SetEnv task | Microsoft Docs"
ms.date: "11/05/2018"
ms.topic: "reference"
f1_keywords:
  - "vc.task.setenv"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild (C++), tasks"
  - "SetEnv task (MSBuild (C++))"
ms.assetid: fd9e4225-68cb-4608-8b27-468b0218c936
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# SetEnv task
Sets or deletes the value of a specified environment variable.

## Parameters
 The following table describes the parameters of the **SetEnv** task.

|Parameter|Description|
|---------------|-----------------|
|**Name**|Required **String** parameter.<br /><br /> The name of an environment variable.|
|**OutputEnvironmentVariable**|Optional **String** output parameter.<br /><br /> Contains the value that is assigned to the environment variable that is specified by the **Name** parameter.|
|**Prefix**|Mandatory `Boolean` parameter.<br /><br /> If `true`, concatenates the value of the **Value** parameter before the value of the environment variable that is specified by the **Name** parameter, and then assigns the result to the environment variable. If `false`, assigns only the value of the **Value** parameter to the environment variable.|
|**Target**|Optional **String** parameter.<br /><br /> Specifies the location where an environment variable is stored. Specify "User" or "Machine".<br /><br /> For more information, see [EnvironmentVariableTarget Enumeration](xref:System.EnvironmentVariableTarget).|
|**Value**|Optional **String** parameter.<br /><br /> The value assigned to the environment variable that is specified by the **Name** parameter. If **Value** is empty and the variable exists, the variable is deleted. If the variable does not exist, no error occurs even though the operation cannot be performed.<br /><br /> For more information, see [Environment::SetEnvironmentVariable Method](xref:System.Environment.SetEnvironmentVariable%2A).|

## See also
- [Task reference](../msbuild/msbuild-task-reference.md)