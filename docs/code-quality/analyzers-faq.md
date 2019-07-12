---
title: EditorConfig versus analyzers
ms.date: 03/11/2019
ms.topic: conceptual
helpviewer_keywords:
  - "analyzers, faq"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Analyzers FAQ

This page contains answers to some frequently asked questions about Roslyn analyzers in Visual Studio.

## Roslyn analyzers versus .editorconfig

**Q**: Should I use Roslyn analyzers or .editorconfig for code style?

**A**: Roslyn analyzers and .editorconfig files work hand-in-hand. When you define code styles [in an .editorconfig file](../ide/editorconfig-code-style-settings-reference.md) or on the [text editor Options](../ide/code-styles-and-code-cleanup.md) page, you're actually configuring the Roslyn analyzers that are built into Visual Studio. EditorConfig files can also be used to configure some third-party analyzer packages, such as [FxCop analyzers](configure-fxcop-analyzers.md).

## EditorConfig versus rule sets

**Q**: Should I configure my analyzers using a rule set or an .editorconfig file?

**A**: Rule sets and .editorconfig files are mutually exclusive ways to configure analyzers. They can coexist. [Rule sets](analyzer-rule-sets.md) let you enable and disable rules and set their severity. EditorConfig files offer other ways to configure rules. For FxCop analyzers, .editorconfig files let you [define which types of code to analyze](fxcop-analyzer-options.md). For the analyzers that are built into Visual Studio, .editorconfig files let you [define the preferred code styles](../ide/editorconfig-code-style-settings-reference.md) for a codebase.

In addition to rule sets and .editorconfig files, some third-party analyzers are configured through the use of text files marked as [additional files](../ide/build-actions.md#build-action-values) for the C# and VB compilers.

> [!NOTE]
> EditorConfig files cannot be used to configure static code analysis rules, whereas rule sets can.

## Analyzers in CI builds

**Q**: Do analyzers work in continuous integration (CI) builds?

**A**: Yes. For analyzers that are installed from a NuGet package, those rules are [enforced at build time](roslyn-analyzers-overview.md#build-errors), including during a CI build. Analyzers used in CI builds respect rule configuration from both [rule sets](analyzer-rule-sets.md) and [.editorconfig files](configure-fxcop-analyzers.md). Currently, the code analyzers that are built into Visual Studio are not available as a NuGet package, and so these rules are not enforceable in a CI build.

## IDE analyzers versus StyleCop

**Q**: What's the difference between the Visual Studio IDE code analyzers and StyleCop analyzers?

**A**: The Visual Studio IDE includes built-in analyzers that look for both code style and quality issues. These rules help you use new language features as they're introduced and improve the maintainability of your code. IDE analyzers are continually updated with each Visual Studio release.

[StyleCop analyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers) are third-party analyzers installed as a NuGet package that check for style consistency in your code. In general, StyleCop rules let you set personal preferences for a code base without recommending one style over another.

## Analyzers versus static code analysis

**Q**: What's the difference between analyzers and static code analysis?

**A**: Analyzers analyze source code in real time and during compilation, whereas static code analysis analyzes binary files after build has completed. For more information, see [Roslyn analyzers vs. static code analysis](roslyn-analyzers-overview.md#roslyn-analyzers-vs-static-code-analysis) and [FxCop analyzers FAQ](fxcop-analyzers-faq.md).

## See also

- [Analyzers overview](roslyn-analyzers-overview.md)
- [.NET coding convention settings for EditorConfig](../ide/editorconfig-code-style-settings-reference.md)