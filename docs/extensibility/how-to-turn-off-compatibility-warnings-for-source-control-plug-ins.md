---
title: Turn off warnings for source control plug-ins
description: A user may see several compatibility warnings when employing source control in Visual Studio. Learn how to disable these warnings.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- source control plug-ins, turning off compatibility warnings
- compatibility warnings, turning off
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Turn off compatibility warnings for source control plug-ins

A user may see several compatibility warnings when employing source control in Visual Studio. The warnings presented depend on the capabilities of the source control plug-in and can be disabled as detailed here.

### To disable the warning: "To ensure optimal source control integration with Visual Studio"

- Set the following registry entry (adding the value if necessary):

   **HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl\DontDisplayCheckDotNETCompatible = dword:00000001**

   This warning is displayed for all non-Visual SourceSafe plug-ins.

### To disable the warning: "The installed source control provider does not support all the capabilities"

- Set the following two registry values (adding the values if necessary):

     **HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl\WarnedOldMSSCCIProvider = dword:00000000**

    **HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\8.0\SourceControl\UseOldSCC = dword:00000001**

     This warning is displayed if the source control plug-in does not explicitly support reentrancy for multiple projects (that is, if it can check in only one file and project at a time).

     It is best to support reentrancy (`SCC_CAP_REENTRANT` capability); doing so will remove this warning. However, if this support is not possible, these registry entries can be set.

## Related content

- [Capability flags](../extensibility/capability-flags.md)
