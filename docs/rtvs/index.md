---
title: R Tools for Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: 11/13/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-r"
ms.devlang: r
ms.tgt_pltfrm: ""
ms.topic: "hero-article"
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "data-science"
---

# Working with R in Visual Studio

R is a highly extensible language and environment for statistical computing and graphics. It's distributed for free under the GNU General Public License, enjoys strong community support, and is known for its ability to produce publication-quality plots including mathematical symbols and formulae. You can learn more about R at [r-project.org](https://www.r-project.org/about.html) and [An Introduction to R](https://cran.r-project.org/doc/manuals/r-release/R-intro.html).

R Tools for Visual Studio (RTVS) is a free, [open-source](https://github.com/microsoft/RTVS) extension for Visual Studio 2017 and Visual Studio 2015 Update 3 (or higher), released under the MIT license. (A second open-source component called [RHost](https://github.com/microsoft/R-Host), which links to the R interpreter binaries, is released under the GNU Public License V2.)

> [!Note]
> RTVS is presently supported only in Visual Studio on Windows and not Visual Studio for Mac.

To experience R in Visual Studio:

- [Install the R Tools](installation.md).
- Follow the [Getting Started](getting-started-with-r.md) guide, as well as the [Samples](getting-started-samples.md) and [Getting Help](getting-started-help.md) topics.

Then follow the links below to learn more about R-related features as well as the general capabilities of Visual Studio itself.

| Feature | Description | General Visual Studio Documentation | 
| --- | --- | --- |
| [Visual Studio project system](projects.md) | Organize and manage related files in a convenient structure, and take advantage of useful templates for items such as R code, R documentation, R Markdown, SQL queries, and stored procedures. Also enjoy the [package manager](package-manager.md) and [SQL Server integration](sql-server.md).  | [Solutions and Projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md) |
| [Workspace](workspaces.md) | RTVS can bind to local and remote workspaces, allowing you to develop R code locally with smaller data sets, then easily run the code on more powerful cloud-based computers with much larger data sets. | n/a |
| [R Tools options](options.md) | Control various aspects of RTVS. | [Options dialog box](../ide/reference/options-dialog-box-visual-studio.md) |
| [Rich editing, IntelliSense, and code snippets](code-editing.md) | Includes syntax coloring, [IntelliSense](code-intellisense.md) across all your code and libraries, code formatting, signature help, Go to Definition, Find All References, [code snippets](code-snippets.md), and more. | [Writing Code in the Code and Text Editor](../ide/writing-code-in-the-code-and-text-editor.md) |
| [R Markdown](rmarkdown.md) | R Markdown documents help you share your data results, with integrated R code inside markdown code blocks. | n/a |
| [Interactive Window](interactive-repl.md) | Provides a full REPL experience for R with the ability to easily run code in a source file in the interactive window. | n/a |
| [Visualizing data](visualizing-data.md) | Plotting is an integral part of the R experience, and RTVS supports multiple, independent plot windows, each with their own history and the ability to move plots between windows. Plots can be saved to bitmap and PDF files, or copied to the clipboard as a bitmap or metafile.  | n/a |
| [Variable Explorer](variable-explorer.md) | Examine variables in the global or package-specific scopes, with the ability to view sortable tables and export to CSV. | n/a |
| [Full-featured debugging](debugging.md) | Includes integration with the interactive window. | [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md) |

Also see [Frequently asked questions](faq.md).

The following video also provides a brief (5m 48s) review of the R Tools capabilities:

> [!VIDEO https://www.youtube.com/embed/RcSDEfMgUvU]

## Send us your feedback!

1. **Github issues**: The best way to reach the RTVS team is by [filing an issue on GitHub](https://github.com/Microsoft/RTVS/issues), or by using the **R Tools > Feedback** menu.

1. **Send a Smile / Frown**: The **R Tools > Feedback** menu is a quick way to send feedback and attach RTVS log files to assist in the diagnosis of your issue. (Logs are written into `%temp%/RTVSlogs.zip` in case you want to send them separately.) Logging is disabled if you've opted out of Visual Studio telemetry through the **Help > Feedback > Settings** menu command, or during installation.

1. **Email**: You can send direct feedback to the team at *rtvsuserfeedback (at) microsoft.com*.
