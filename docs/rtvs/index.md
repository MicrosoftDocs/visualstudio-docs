---
title: R Tools for Visual Studio
description: R Tools for Visual Studio 2017 (RTVS) is a free, open-source extension that provides many language features including IntelliSense, debugging, and remote workspaces.
ms.date: 11/13/2017
ms.prod: visual-studio-dev15
ms.topic: overview
author: kraigb
ms.author: kraigb
manager: jmartens
ms.technology: vs-rtvs
ms.workload:
  - data-science
---

# Work with R in Visual Studio

R is a highly extensible language and environment for statistical computing and graphics. It's distributed for free under the GNU General Public License, enjoys strong community support, and is known for its ability to produce publication-quality plots including mathematical symbols and formulae. You can learn more about R at [r-project.org](https://www.r-project.org/about.html) and [An Introduction to R](https://cran.r-project.org/doc/manuals/r-release/R-intro.html).

R Tools for Visual Studio (RTVS) is a free, [open-source](https://github.com/microsoft/RTVS) extension for Visual Studio 2017 and Visual Studio 2015 Update 3 (or higher), released under the MIT license. (A second open-source component called [RHost](https://github.com/microsoft/R-Host), which links to the R interpreter binaries, is released under the GNU Public License V2.)

> [!Note]
> RTVS is presently supported only in Visual Studio 2017 on Windows and not Visual Studio for Mac. It is not available for Visual Studio 2019.

To experience R in Visual Studio:

- [Install the R Tools](installing-r-tools-for-visual-studio.md).
- Follow the [Getting started](getting-started-with-r.md) guide, as well as the [Samples](getting-started-samples.md) and [Getting Help](getting-started-help.md) articles.

Then follow the links below to learn more about R-related features as well as the general capabilities of Visual Studio itself.

| Feature | Description | General Visual Studio Documentation |
| --- | --- | --- |
| [Visual Studio project system](r-projects-in-visual-studio.md) | Organize and manage related files in a convenient structure, and take advantage of useful templates for items such as R code, R documentation, R Markdown, SQL queries, and stored procedures. Also enjoy the [package manager](r-package-manager-in-visual-studio.md) and [SQL Server integration](integrating-sql-server-with-r.md).  | [Solutions and Projects in Visual Studio](../ide/solutions-and-projects-in-visual-studio.md) |
| [Workspace](r-workspaces-in-visual-studio.md) | RTVS can bind to local and remote workspaces, allowing you to develop R code locally with smaller data sets, then easily run the code on more powerful cloud-based computers with much larger data sets. | n/a |
| [R Tools options](options-for-r-tools-in-visual-studio.md) | Control various aspects of RTVS. | [Options dialog box](../ide/reference/options-dialog-box-visual-studio.md) |
| [Rich editing, IntelliSense, and code snippets](editing-r-code-in-visual-studio.md) | Includes syntax coloring, [IntelliSense](r-intellisense.md) across all your code and libraries, code formatting, signature help, Go to Definition, Find All References, [code snippets](code-snippets-for-r.md), and more. | [Features of the code editor](../ide/writing-code-in-the-code-and-text-editor.md) |
| [R Markdown](rmarkdown-with-r-in-visual-studio.md) | R Markdown documents help you share your data results, with integrated R code inside markdown code blocks. | n/a |
| [Interactive Window](interactive-repl-for-r-in-visual-studio.md) | Provides a full REPL experience for R with the ability to easily run code in a source file in the interactive window. | n/a |
| [Visualizing data](visualizing-data-with-r-in-visual-studio.md) | Plotting is an integral part of the R experience, and RTVS supports multiple, independent plot windows, each with their own history and the ability to move plots between windows. Plots can be saved to bitmap and PDF files, or copied to the clipboard as a bitmap or metafile.  | n/a |
| [Variable Explorer](variable-explorer.md) | Examine variables in the global or package-specific scopes, with the ability to view sortable tables and export to CSV. | n/a |
| [Full-featured debugging](debugging-r-in-visual-studio.md) | Includes integration with the interactive window. | [Debugging in Visual Studio](../debugger/debugger-feature-tour.md) |

Also see [Frequently asked questions](faq.md).

![movie camera icon for video](../install/media/video-icon.png "Watch a video") [Watch a video (youtube.com)](https://www.youtube.com/watch?v=dll3IS1bfWQ) for an overview of R Tools for Visual Studio (12m 36s). Also see [more R Tools videos](https://www.youtube.com/results?search_query=R+Tools+for+visual+studio).

## Send us your feedback!

1. **GitHub issues**: The best way to reach the RTVS team is by [filing an issue on GitHub](https://github.com/Microsoft/RTVS/issues), or by using the **R Tools** > **Feedback** menu.

1. **Send a Smile / Frown**: The **R Tools** > **Feedback** menu is a quick way to send feedback and attach RTVS log files to assist in the diagnosis of your issue. (Logs are written into *%temp%/RTVSlogs.zip* in case you want to send them separately.) Logging is disabled if you've opted out of Visual Studio telemetry through the **Help** > **Feedback** > **Settings** menu command, or during installation.

1. **Email**: You can send direct feedback to the team at *rtvsuserfeedback (at) microsoft.com*.
