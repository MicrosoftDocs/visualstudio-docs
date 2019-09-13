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
# Code analysis FAQ

This page contains answers to some frequently asked questions about .NET Compiler Platform-based code analysis in Visual Studio.

## Code analysis versus EditorConfig

**Q**: Should I use code analysis or EditorConfig for checking code style?

**A**: Code analysis and .editorconfig files work hand-in-hand. When you define code styles [in an .editorconfig file](../ide/editorconfig-code-style-settings-reference.md) or on the [text editor Options](../ide/code-styles-and-code-cleanup.md) page, you're actually configuring the code analyzers that are built into Visual Studio. EditorConfig files can also be used to configure some NuGet analyzer packages, such as [FxCop analyzers](configure-fxcop-analyzers.md).

## EditorConfig versus rule sets

**Q**: Should I configure my analyzers using a rule set or an .editorconfig file?

**A**: Rule sets and .editorconfig files are mutually exclusive ways to configure analyzers. They can coexist. [Rule sets](analyzer-rule-sets.md) let you enable and disable rules and set their severity. EditorConfig files offer other ways to configure rules. For FxCop analyzers, .editorconfig files let you [define which types of code to analyze](fxcop-analyzer-options.md). For the analyzers that are built into Visual Studio, .editorconfig files let you [define the preferred code styles](../ide/editorconfig-code-style-settings-reference.md) for a codebase.

In addition to rule sets and .editorconfig files, some analyzers are configured through the use of text files marked as [additional files](../ide/build-actions.md#build-action-values) for the C# and VB compilers.

> [!NOTE]
> EditorConfig files cannot be used to configure legacy analysis, whereas rule sets can.

## Code analysis in CI builds

**Q**: Does .NET Compiler Platform-based code analysis work in continuous integration (CI) builds?

**A**: Yes. For analyzers that are installed from a NuGet package, those rules are [enforced at build time](roslyn-analyzers-overview.md#build-errors), including during a CI build. Analyzers used in CI builds respect rule configuration from both [rule sets](analyzer-rule-sets.md) and [.editorconfig files](configure-fxcop-analyzers.md). Currently, the code analyzers that are built into Visual Studio are not available as a NuGet package, and so these rules are not enforceable in a CI build.

## IDE analyzers versus StyleCop

**Q**: What's the difference between the Visual Studio IDE code analyzers and StyleCop analyzers?

**A**: The Visual Studio IDE includes built-in analyzers that look for both code style and quality issues. These rules help you use new language features as they're introduced and improve the maintainability of your code. IDE analyzers are continually updated with each Visual Studio release.

[StyleCop analyzers](https://github.com/DotNetAnalyzers/StyleCopAnalyzers) are third-party analyzers installed as a NuGet package that check for style consistency in your code. In general, StyleCop rules let you set personal preferences for a code base without recommending one style over another.

## Code analyzers versus legacy analysis

**Q**: What's the difference between legacy analysis and .NET Compiler Platform-based code analysis?

**A**: .NET Compiler Platform-based code analysis analyzes source code in real time and during compilation, whereas legacy analysis analyzes binary files after build has completed. For more information, see [.NET Compiler Platform-based analysis versus legacy analysis](roslyn-analyzers-overview.md#net-compiler-platform-based-analysis-versus-legacy-analysis) and [FxCop analyzers FAQ](fxcop-analyzers-faq.md).

## See also

- [Analyzers overview](roslyn-analyzers-overview.md)
- [.NET coding convention settings for EditorConfig](../ide/editorconfig-code-style-settings-reference.md)