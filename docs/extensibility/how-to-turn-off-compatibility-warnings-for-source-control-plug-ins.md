---
title: Turn off warnings for source control plug-ins
description: A user may see several compatibility warnings when employing source control in Visual Studio. Learn how to disable these warnings.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- source control plug-ins, turning off compatibility warnings
- compatibility warnings, turning off
ms.assetid: ba318e12-921b-4b7a-a8c2-12c712be1dbf
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# How to: Turn off compatibility warnings for source control plug-ins

A user may see several compatibility warnings when employing source control in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. The warnings presented depend on the capabilities of the source control plug-in and can be disabled as detailed here.

### To disable the warning: "To ensure optimal source control integration with Visual Studio"

- Set the following registry entry (adding the value if necessary):

   **HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl\DontDisplayCheckDotNETCompatible = dword:00000001**

   This warning is displayed for all non-[!INCLUDE[vsvss](../extensibility/includes/vsvss_md.md)] plug-ins.

### To disable the warning: "The installed source control provider does not support all the capabilities"

- Set the following two registry values (adding the values if necessary):

     **HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl\WarnedOldMSSCCIProvider = dword:00000000**

    **HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl\UseOldSCC = dword:00000001**

     This warning is displayed if the source control plug-in does not explicitly support reentrancy for multiple projects (that is, if it can check in only one file and project at a time).

     It is best to support reentrancy (`SCC_CAP_REENTRANT` capability); doing so will remove this warning. However, if this support is not possible, these registry entries can be set.

## See also

- [Capability flags](../extensibility/capability-flags.md)
