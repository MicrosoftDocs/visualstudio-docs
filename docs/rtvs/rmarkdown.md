---
title: R Markdown with R Tools for Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: 6/29/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-r"
ms.devlang: r
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3ac955b2-b6e1-4d32-b1a4-2882c93311fc
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
---

# Creating R Markdown documents

[R Markdown](https://rmarkdown.rstudio.com/) is a document format that turns analysis in R into high-quality documents, reports, presentations, and dashboards.

R Tools for Visual Studio (RTVS) provides a R Markdown item template, editor support (including IntelliSense for R code within the editor), and file generation capabilities.

To use R Markdown:

1. Close Visual Studio.
1. (One time only) Install `pandoc` from [pandoc.org](http://pandoc.org/installing.html).
1. Restart Visual Studio, which should pick up the pandoc installation.
1. Install the `knitr` and `rmarkdown` packages, which you can do from the [interactive window](interactive-repl.md):

    ```R
    install.packages("knitr")
    install.packages("rmarkdown")

    ```
1. Create a new R Markdown file using either the **File > New** menu command and selecting **R Markdown** from the list, or by right-clicking your project in Solution Explorer and selecting **Add R Markdown** (or **Add > New Item...** and selecting **R Markdown** from the list).

1. The default contents of the new file are as follows:

    ~~~markdown
    ---
    title: "Untitled"
    output: html_document
    ---
    
    This is an R Markdown document. Markdown is a simple formatting syntax for authoring HTML, PDF, and Microsoft Word documents. For more details on using R Markdown see <http://rmarkdown.rstudio.com>.
    
    When you click the **R Tools | Publish | Preview** button a document will be generated that includes both content as well as the output of any embedded R code chunks within the document. You can embed an R code chunk like this:
    
    ```{r}
    summary(cars)
    ```
    
    You can also embed plots, for example:
    
    ```{r, echo=FALSE}
    plot(cars)
    ```
    
    Note that the `echo = FALSE` parameter was added to the code chunk to prevent printing of the R code that generated the plot.
    
    ~~~

1. At any time during editing, right-click in the editor and select **Preview**, which has options for HTML, PDF, and Microsoft Word. From that preview you can save the file as appropriate for the format you chose.
