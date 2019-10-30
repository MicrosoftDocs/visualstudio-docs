---
title: "Version Compatibility for Code Analysis Check-In Policies | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: conceptual
helpviewer_keywords:
  - "version compatibility, code analysis check-in policy"
  - "check-in policies, version compatibility for code analysis"
ms.assetid: 1af376e3-3be7-4445-803b-76a858567a5b
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# Version Compatibility for Code Analysis Check-In Policies
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If you must evaluate and author code analysis check-in policies using different versions of [!INCLUDE[esprtfc](../includes/esprtfc-md.md)], you must know the differences in how [!INCLUDE[vstsTfsOrcasLong](../includes/vststfsorcaslong-md.md)] and [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)] evaluate check-in policies.

## Version Compatibility for Evaluating Check-In Policies

- When code analysis check-in policies are evaluated in [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)], any rules that existed in [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)] but do not exist in [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)] are ignored.

- When code analysis check-in policies are evaluated in [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)], all new rules that are exclusive to [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)] are ignored.

- If the code analysis check-in policy specifies rules assemblies, [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)] ignores all rules that are specified by assemblies that it does not recognize.

- If the code analysis check-in policy specifies rules assemblies that [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)] does not recognize, a message is displayed.

## Version Compatibility for Authoring Check-In Policies

- If you created a code analysis check-in policy by using the [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)] version of [!INCLUDE[esprtfc](../includes/esprtfc-md.md)], you cannot use the [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)] version of [!INCLUDE[esprtfc](../includes/esprtfc-md.md)] to modify it. And also, [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)] cannot evaluate the policy.

- If you created a code analysis check-in policy by using [!INCLUDE[esprtfc](../includes/esprtfc-md.md)] in [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)], you can use [!INCLUDE[esprtfc](../includes/esprtfc-md.md)] in [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)] to modify it, and the policy can also be evaluated by [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)]. After you modify the policy by using [!INCLUDE[esprtfc](../includes/esprtfc-md.md)] in [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)], you can no longer edit the policy by using [!INCLUDE[esprtfc](../includes/esprtfc-md.md)] in [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)]. [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)] can evaluate the policies without problems with mismatched strong names.

- To create a code analysis check-in policy with rule settings that apply for both [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)] and [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)], you must create the policy in [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)], make all the changes needed, and save the policy. If the changes to rules exist only in [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)], you modify and save the policy in [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)].

     After you save the policy in [!INCLUDE[vstsTfsOrcasShort](../includes/vststfsorcasshort-md.md)], you can no longer change settings for rules that exist in [!INCLUDE[vstsTfsRosarioShort](../includes/vststfsrosarioshort-md.md)] only.
