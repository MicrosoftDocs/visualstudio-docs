---
title: "R Markdown with the R Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 4/10/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-r"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3ac955b2-b6e1-4d32-b1a4-2882c93311fc
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---


# R Markdown

To use R Markdown, you should first install pandoc. Make sure to shut down Visual Studio before installing pandoc to ensure that Visual Studio will pick up the path to the pandoc installation when you run it after the installation.

[Install Pandoc from pandoc.org](http://pandoc.org/installing.html)

You will also need to install the knitr and rmarkdown packages:

{% highlight R %}
install.packages("knitr")
install.packages("rmarkdown")
{% endhighlight %}

Next, to create an R Markdown file, go to File/New and select R Markdown:

![R Markdown New file](media/rmarkdown-new-file.png)

Once you've edited your file, you can right click and Preview into Word or HTML:

![Preview](media/rmarkdown-preview.png)
