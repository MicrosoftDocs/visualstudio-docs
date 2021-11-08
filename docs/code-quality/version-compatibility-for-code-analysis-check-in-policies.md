---
title: Version Compatibility for Code Analysis Check-In Policies
ms.date: 11/04/2016
description: Learn how Team System 2008 Team Foundation Server and Team Foundation Server 2010 evaluate Visual Studio check-in policies differently.
ms.custom: SEO-VS-2020
ms.topic: conceptual
helpviewer_keywords:
- version compatibility, code analysis check-in policy
- check-in policies, version compatibility for code analysis
ms.assetid: 1af376e3-3be7-4445-803b-76a858567a5b
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-code-analysis
ms.workload:
- multiple
---
# Version Compatibility for Code Analysis Check-In Policies

If you must evaluate and author code analysis check-in policies using different versions of [!INCLUDE[esprtfc](../code-quality/includes/esprtfc_md.md)], you must know the differences in how [!INCLUDE[vstsTfsOrcasLong](../code-quality/includes/vststfsorcaslong_md.md)] and [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)] evaluate check-in policies.

## Version Compatibility for Evaluating Check-In Policies

- When code analysis check-in policies are evaluated in [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)], any rules that existed in [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)] but do not exist in [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)] are ignored.

- When code analysis check-in policies are evaluated in [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)], all new rules that are exclusive to [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)] are ignored.

- If the code analysis check-in policy specifies rules assemblies, [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)] ignores all rules that are specified by assemblies that it does not recognize.

- If the code analysis check-in policy specifies rules assemblies that [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)] does not recognize, a message is displayed.

## Version Compatibility for Authoring Check-In Policies

- If you created a code analysis check-in policy by using the [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)] version of [!INCLUDE[esprtfc](../code-quality/includes/esprtfc_md.md)], you cannot use the [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)] version of [!INCLUDE[esprtfc](../code-quality/includes/esprtfc_md.md)] to modify it. And also, [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)] cannot evaluate the policy.

- If you created a code analysis check-in policy by using [!INCLUDE[esprtfc](../code-quality/includes/esprtfc_md.md)] in [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)], you can use [!INCLUDE[esprtfc](../code-quality/includes/esprtfc_md.md)] in [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)] to modify it, and the policy can also be evaluated by [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)]. After you modify the policy by using [!INCLUDE[esprtfc](../code-quality/includes/esprtfc_md.md)] in [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)], you can no longer edit the policy by using [!INCLUDE[esprtfc](../code-quality/includes/esprtfc_md.md)] in [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)]. [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)] can evaluate the policies without problems with mismatched strong names.

- To create a code analysis check-in policy with rule settings that apply for both [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)] and [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)], you must create the policy in [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)], make all the changes needed, and save the policy. If the changes to rules exist only in [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)], you modify and save the policy in [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)].

   After you save the policy in [!INCLUDE[vstsTfsOrcasShort](../code-quality/includes/vststfsorcasshort_md.md)], you can no longer change settings for rules that exist in [!INCLUDE[vstsTfsRosarioShort](../code-quality/includes/vststfsrosarioshort_md.md)] only.
