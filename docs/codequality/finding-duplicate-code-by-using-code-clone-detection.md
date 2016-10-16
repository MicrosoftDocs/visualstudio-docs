---
title: "Finding Duplicate Code by using Code Clone Detection"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.codeclone.codecloneanalysisresults.overview"
ms.assetid: a97cd5a6-5ffa-4104-9627-8e59e513654d
caps.latest.revision: 17
ms.author: "awills"
manager: "kamrani"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Finding Duplicate Code by using Code Clone Detection
*Code clones* are separate fragments of code that are very similar. They are a common phenomenon in an application that has been under development for some time. Clones make it hard to change your application because you have to find and update more than one fragment.  
  
 **Visual Studio Enterprise** can help you find code clones so that you can refactor them.  
  
 You can either find the clones of a specific fragment, or find all clones in your solution. In addition to discovering direct copies, the clone analysis tool can find fragments which differ in the names of variables and parameters, and in which some statements have been rearranged.  
  
 The code clone analyser searches for duplicate code in Visual C# and Visual Basic projects throughout your Visual Studio solution.  
  
 ![Code clone analysis result with strong matches](../codequality/media/codeclone1.png "CodeClone1")  
  
### To find clones of a particular code fragment  
  
1.  Highlight a fragment of code within a method or a get/set definition.  
  
    > [!NOTE]
    >  You can find clones of statements, but not declarations such as field, method, or property signatures.  
  
2.  On the shortcut menu for the fragment, choose **Find matching clones in solution**.  
  
 Use this method when you want to know if there is a similar method or fragment already in existence in your solution.  
  
### To find all clones in a solution  
  
1.  On the **Analyse** menu, choose **Analyze Solution for Code Clones**.  
  
 This method is particularly useful when you are reviewing your code.  
  
> [!NOTE]
>  Methods that are less than 10 statements long are not scanned by this command.  
  
 The results are presented in order of similarity. Expand each item to see the code fragments.  
  
 Notice that similarities are detected even if the local variables that are used by the fragments have different names, and even if a few statements have been inserted or deleted.  
  
### To compare clones  
  
1.  In the **Code Clone Results** window, select either two files, or a clone group that contains two files.  
  
2.  Choose **Compare** from the shortcut menu.  
  
 This feature uses the same comparison tool as is used for comparing versions under source control. If you want to change it, choose **Options** from the **Tools** menu. Expand **Source Control** and **Visual Studio Team Foundation Server**. Choose **Configure User Tools** and then **Add**.  
  
### To exclude specific files or methods from the analysis  
  
1.  Add a new XML file to the Visual Studio project in which the methods that you want to exclude are defined.  
  
     It does not matter whether the file is part of the project. It must be in the top directory of the project.  
  
2.  Change the file name extension to `.codeclonesettings`  
  
3.  Edit the content of the file so that it resembles the following example.  
  
    ```xml  
    <CodeCloneSettings>  
      <Exclusions>  
        <!-- Add any combination of the following node types. -->  
        <!-- Absolute or relative path names: -->  
        <File>MyFile.cs</File>  
        <!-- Filepaths may contain wildcards: -->  
        <File>GeneratedFiles\*.cs</File>  
        <!-- Namespace, Type, and FunctionName must be fully qualified: -->  
        <Namespace>MyCompany.MyProject</Namespace>  
        <Type>MyCompany.MyProject.MyClass1</Type>  
        <FunctionName>MyCompany.MyProject.MyClass2.MyMethod</FunctionName>  
        <!-- Names may contain wildcards: -->  
        <Namespace>*.AnotherProject</Namespace>  
        <Type>*.AnotherClass*</Type>  
        <FunctionName>MyProject.*.AnotherMethod</FunctionName>  
      </Exclusions>  
    </CodeCloneSettings>        
    ```  
  
## What code clones will be found?  
 The code clone analyzer will find "near miss" clones.  
  
 Code clones often result from developers copying code and then adapting it to its new location. It is therefore easiest to consider the degree of change that can be made before the analyzer fails to find the clone. The following modifications can be made, and the clone will still be recognized. In each case, there is a tolerance of a specific number of such modifications:  
  
-   Rename identifiers.  
  
-   Insert and delete statements.  
  
-   Rearrange statements.  
  
### What duplicates will not be found?  
  
-   Type declarations are not compared. For example, if you have two classes with very similar sets of field declarations, they will not be reported as clones.  
  
     Only statements in methods and property definitions are compared.  
  
-   **Analyze Solution for Code Clones** will not find clones in methods that are less than 10 statements long.  
  
     However, you can apply **Find matching clones in solution** to shorter fragments.  
  
-   Fragments with more than 40% changed tokens.  
  
-   If a project contains a `.codeclonesettings` file, code elements that are defined in that project will not be searched if they are named in the `Exclusions` section of the `.codeclonesettings` file.  
  
-   Some kinds of generated code:  
  
    1.  `*.designer.cs`, `*.designer.vb`  
  
    2.  `InitializeComponent` methods  
  
     However, this does not automatically apply to all generated code. For example, if you use text templates, you might want to exclude the generated files by naming them in a `.codeclonesettings` file.  
  
## When to use code clone analysis  
 Finding clones is typically useful in the following cases:  
  
-   **When updating existing code.** When you are fixing a bug, or responding to changes in requirements, you usually start by finding the location in the code that you need to change. Before you make the change, search for clones of that code segment. If clones are discovered:  
  
    1.  Consider whether you need to make the same change to each clone.  
  
    2.  Consider also whether this is a good opportunity to refactor the cloned code into a shared method or class.  
  
-   **Architectural cleanup.** Towards the end of every iteration, use **Analyze Solution for Code Clones** on the **Analyze** menu.  
  
-   **When you create code.** When you have written new code, use the tool to find similar code that already existed.  
  
## Applying clone analysis to a large code base  
 Code is often copied between quite separate parts of a large project, and is often copied to different parts of an organization. You should therefore look for clones in as large a code base as you can, not just in the immediate solution on which you are working.  
  
 To apply the code clone analyzer across your source tree, create a solution that contains all of the projects in the repository.  
  
> [!TIP]
>  Remember that you can include a project in more than one solution. To analyze a lot of projects for code clones, you can create a solution that includes all the projects. You do not need to remove the projects from the solutions through which they are usually accessed.  
  
## Generated Code  
 Code clone analysis does not work well with generated code. For example:  
  
-   Code generated from T4 templates.  
  
     For more information about T4, see [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md).  
  
-   Code generated from a designer such as the Silverlight or WPF user interface designers.  
  
#### To exclude files generated by T4 templates from code clone analysis  
  
1.  Place the templates in a sub directory of the Visual Studio project. Name it, for example, `GeneratedFiles`.  
  
2.  Add a new text file to the project, and change its name and extension to `t4Exclusions.codeclonesettings`  
  
3.  Change the content of the file as follows:  
  
    ```xml  
    <CodeCloneSettings>  
      <Exclusions>  
        <File>GeneratedFiles\*.cs</File>  
      </Exclusions>  
    </CodeCloneSettings>  
  
    ```