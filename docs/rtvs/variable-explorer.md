---
title: "Interactive REPL Variable Explorer in R Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 4/10/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-r"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 6c669434-40d8-4970-92cc-502a98c8b5ab
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


# Variable Explorer

The Variable Explorer provides a list of all variables at global scope from the REPL. So, if in the REPL you executed: 

```r
x <- 42
y <- 43
n <- c(1,2,3,5,8,13)
```
 
The variable explorer will display the following data:

![](media/repl-variable-explorer-example-result.png)

If you have a more complex R data frame defined in the REPL, you can drill into the data. If you execute these commands:
 
```r
cars <- mtcars
```

You will see this view in the Variable Explorer:

![](media/repl-variable-explorer-cmds-example-results.png)
 
Next we click on the chevron to drill into the data:

![](media/repl-variable-explorer-cmds-example-drill-down.png)

We can drill as deep as the data is nested within the data frame:
 
![](media/repl-variable-explorer-cmds-example-drill-down2.png)

You can delete variables from your R session directly from the variable explorer. Just right click on the variable that you want to remove from your R session and select the Delete command. Or you can just select the variable that you want to remove and press the DELETE key.

![](media/repl-variable-explorer-delete-variables.png)

If you want to search for an observation in a data frame, we have an incremental search over all observations in a data frame. Note that you must first expand the data frame in Variable Explorer for this to work. 

![](media/repl-variable-explorer-incremental-search.png)

## Export to Excel

While the data table viewer is a great tool, sometimes you want to be able to take your data frame and *export* it to Excel. You can easily do this by clicking on the small Excel icon to the variable explorer. When you click on it, it will take your data frame and export it to a new Excel Workbook:

![](media/repl-variable-explorer-excel-view.png)

We do this by writing a new CSV file containing the contents of the dataframe to the `%USERPROFILE%\Documents\RTVS_CSV_Exports` directory.

## Scopes 

We now let you pick different *scopes* for the variables in the variable explorer; previously you could only examine variables at global scope. Now, with package level scope, we give you a view over all of the variables (including functions, which are just functions bound to variables) defined within a package:

![](media/repl-variable-explorer-package-scopes.png)

If you are stopped at a breakpoint in the debugger, you can use the Variable Explorer to inspect runtime variables in your program. You can inspect complex variables such as data frames, and even export them to Excel. All you need to do is change the scope of the Variable Explorer to the current function that you are stopped at (it won't do this automatically for you). In the example below, I have set the Variable Explorer's scope to the `foo` function where the debugger is currently stopped on a breakpoint. You can inspect the `df` data frame
variable directly in the Variable Explorer, or even send it to Excel to snapshot the current state of the data frame.

![](media/repl-variable-explorer-as-locals-window.png)

When you are debugging, variable explorer also recognizes the current execution scope (i.e., when you are debugging code within a function). Here, local variables that you define within that function can now be inspected using variable explorer. In the picture below, you can see that the current execution scope is within a function called `renderUI`, and that there are two local variables defined at the current execution point: `country_data` and `max_destinations`:

![](media/repl-variable-explorer-view-locals.png)

We support viewing variables defined inside of private named scopes as well (i.e., variables defined within a package). For example, here are the variables defined in the Shiny package:

![](media/repl-variable-explorer-scopes.png)

## Importing data into Variable Explorer

Another way to bring data sets into your project is to use the Import Dataset command in the Variable Explorer. Click either the Import from Web or Import from File toolbar button to specify the location of the CSV file that you want to import:

![](media/repl-variable-explorer-toolbar.png)

Once you've specified the location of the file, you will see the Import Dataset dialog box which gives you options that control how that data file is parsed. You can even see a preview of the imported data frame and the original data file.

![](media/repl-variable-explorer-import-dataset-dialog.png)
