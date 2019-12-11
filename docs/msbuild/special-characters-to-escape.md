---
title: "Special Characters to Escape | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "special characters to escape"
  - "msbuild, special characters to escape"
ms.assetid: 5b5172c3-41e4-4f38-a16f-2aeac831a5fc
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Special characters to escape
Special characters must be escaped only if they have special meaning in the context in which they are being used. For example, the asterisk (*) is a special character only in the "Include" and "Exclude" attributes of an item definition, or in a call to <xref:Microsoft.Build.Tasks.CreateItem>. In all other cases, the asterisk is treated as a literal asterisk. While you do not need to escape asterisks everywhere in project files, doing so does no harm.

 Use the notation %\<xx> in place of the special character, where \<xx> represents the hexadecimal value of the ASCII character. For example, to use an asterisk (*) as a literal character, use the value `%2A`.

 The full list of special characters to escape follows:

|Character|Description|
|---------------|-----------------|
|%|Percent sign, used to reference metadata.|
|$|Dollar sign, used to reference properties.|
|@|At sign, used to reference item lists.|
|(|Open parenthesis, used in lists.|
|)|Close parenthesis, used in lists.|
|;|Semicolon, a list separator.|
|?|Question mark, a wildcard character when describing a file spec in an item's Include/Exclude section.|
|*|Asterisk, a wildcard character when describing a file spec in an item's Include/Exclude section.|

> [!NOTE]
> In some scenarios, you may need to escape double quote (") characters, such as when using within an `Exec` task.

## See also
- [How to: Escape special characters in MSBuild](../msbuild/how-to-escape-special-characters-in-msbuild.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
