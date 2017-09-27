---
title: R Tools for Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: 6/29/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-r"
ms.devlang: r
ms.tgt_pltfrm: ""
ms.topic: "hero-article"
ms.assetid: 11324501-ceb6-47a2-ae13-e9e992d3603e
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
---

# Working with R in Visual Studio

R is a highly extensible language and environment for statistical computing and graphics. It's distributed for free under the GNU General Public License, enjoys strong community support, and is known for its ability to produce publication-quality plots including mathematical symbols and formulae. You can learn more about R at [r-project.org](https://www.r-project.org/about.html) and [An Introduction to R](https://cran.r-project.org/doc/manuals/r-release/R-intro.html).

R Tools for Visual Studio (RTVS) is a free, [open-source](https://github.com/microsoft/RTVS) extension for Visual Studio 2017 and Visual Studio 2015 Update 3 (or higher), released under the MIT license. (A second open-source component called [RHost](https://github.com/microsoft/R-Host), which links to the R interpreter binaries, is released under the GNU Public License V2.)

To experience R in Visual Studio:

- [Install the R Tools](installation.md).
- Follow the [Getting Started](getting-started-with-r.md) guide, as well as the [Samples](getting-started-samples.md) and [Getting Help](getting-started-help.md) topics.

Then follow the links to learn more about R-related features as well as the general capabilities of Visual Studio itself.

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

The following video also provides a brief (5m 48s) review of the R Tools capabilities:

> [!VIDEO https://www.youtube.com/embed/RcSDEfMgUvU]

## Frequently Asked Questions

**Q. Does RTVS work with Visual Studio Express editions?**

A. No.

**Q. What R interpreters does RTVS work with?**

A. [CRAN R](https://cran.r-project.org/), [Microsoft R Client, and Microsoft R Server](https://msdn.microsoft.com/microsoft-r/)

**Q. Where can I download these interpreters?**

A. See [Installation](installation.md).

**Q. Can I use Visual Studio extensions with RTVS?**

A. Absolutely. In fact, here are a few that are popular for people working with R.

- [VsVim for vim key bindings](https://marketplace.visualstudio.com/items?itemName=JaredParMSFT.VsVim)
- [Github](https://marketplace.visualstudio.com/items?itemName=GitHub.GitHubExtensionforVisualStudio)
- [Markdown editor with live preview](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor)

See the [Visual Studio Marketplace](https://marketplace.visualstudio.com/) to find more.

**Q. Because RTVS is in Visual Studio, does it mean that R can be easily used with C#, C++ and other Microsoft languages?**

A. No. RTVS is a tool for developing R code, and uses the standard native R interpreters. Interop between R and other languages isn't currently supported.

**Q. Feature X is missing, but RStudio has it!**

A. RStudio is a fantastic and mature IDE for R that's been under development for many years. RTVS seeks to have all the critical features that you need to be successful. Help prioritize future work by taking the [RTVS survey](https://www.surveymonkey.com/r/RTVS1).

**Q. Does RTVS work on OS X or Linux?**

A. No, RTVS is built on top of Visual Studio, which is a Windows-only implementation. That said, Microsoft is investigating building a new set of tools based on [Visual Studio Code](https://code.visualstudio.com/), the popular cross-platform editor from Microsoft.

**Q. Can I contribute to RTVS?**

A. Absolutely! The source code lives on [Github](https://github.com/microsoft/RTVS). Use the issue tracker to submit bugs and comment on those already filed.

You're also welcome to contribute to this documentation&mdash;just select the **Edit** command on the upper right of any page. Comments on the docs are also welcome, which you can add at the bottom of any page.

**Q. Does RTVS work with my source control system?**

A. Yes, you can use any source control system that is integrated into Visual Studio.

**Q. Does RTVS work with a non-English locale?**

A. The 1.0 release of RTVS is English-only. The 1.1 release will be localized to the same set of languages that Visual Studio itself is. In the meantime, use the [English language pack for Visual Studio 2015](https://www.microsoft.com/download/details.aspx?id=48157), or in Visual Studio 2017, run the installer and select English in the **Language Packs** tab.

![International settings for Visual Studio 2017](media/FAQ-international-settings.png)

**Q. Does RTVS work with 32-bit editions of R?**

A. No, RTVS only supports 64-bit editions of R running on 64-bit editions of Windows.

**Q. I really like my current Visual Studio settings, but I want to try out the new Data Science settings. What should I do?**

A. Save your current Visual Studio settings using **Tools > Import and Export Settings...**, then switch to the Data Science settings. To restore the saved settings, use the **Import and Export Settings...** command again.

**Q. What are the recommended `.gitignore` settings for an RTVS project?**

A. Github maintains a master repository of recommended `.gitignore` files. You can see it here: [R .gitignore](https://github.com/github/gitignore/blob/master/R.gitignore)

**Q. Can I store my Visual Studio project on a network share?**

A. No, Visual Studio doesn't support loading projects from a network share.

## Send us your feedback!

1. **Github issues**: The best way to reach the RTVS team is by [filing an issue on GitHub](https://github.com/Microsoft/RTVS/issues), or by using the **R Tools > Feedback** menu.

1. **Send a Smile / Frown**: The **R Tools > Feedback** menu is a quick way to send feedback and attach RTVS log files to assist in the diagnosis of your issue. (Logs are written into `%temp%/RTVSlogs.zip` in case you want to send them separately.) Logging is disabled if you've opted out of Visual Studio telemetry through the **Help > Feedback > Settings** menu command, or during installation.

1. **Email**: You can send direct feedback to the team at *rtvsuserfeedback (at) microsoft.com*.
