---
title: "How to run a C# program"
description: "Learn how to run a simple C# program in Visual Studio."
ms.custom: "get-started"
ms.date: 10/16/2019
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
ms.topic: tutorial
ms.devlang: CSharp
author: ghogen
ms.author: ghogen
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
  - "dotnetcore"
---
# How to: Run a C# program in Visual Studio

What you need to do to run a program depends on what you're starting from, what type of program, app, or application it is, and whether you want to run it under the debugger or not. In the simplest case, when you have a project open in Visual Studio, build and run it by pressing **Ctrl**+**F5** (**Start without debugging**) or **F5** (**Start with debugging**), or press the green arrow (**Start Button**) on the main Visual Studio toolbar.

![Screenshot showing start button](media/run-program/vs-start-button.png)

## Starting from a Visual Studio solution or project

You might encounter source code that's already been edited by someone else with Visual Studio in a project.  The presence of a .csproj file or .sln file indicates that source code is set up to work with a version of Visual Studio. A .sln file is not necessary, especially if there's only one project. If a project contains a C# file with a `Main` method, and its output is an executable (EXE), not a library (DLL), then it should be able to run.

If you already have the code for your program in a project in Visual Studio, open the project. To open the project, double-click or tap on the .csproj from the Windows File Explorer, or from Visual Studio, choose **Open a project** and choose the project file.

After the projects loads in Visual Studio, press **Ctrl**+**F5** (**Start without debugging**) or use the green **Start** button on the Visual Studio toolbar to run the program.  If there are multiple projects, the one with the `Main` method must be set as the startup project.  To set the startup project, right-click on a project node, and choose **Set as startup project**.

Visual Studio attempts to build and runs your project.  If there are build errors, you see the build output in the **Output** window and the errors in the **Error List** window.

If the build succeeds, Console apps run in a terminal window, Windows desktop apps start in separate windows, and web apps start in the browser.

## Starting from a code listing, code file, or a small number of loose C# source code files

First, make sure the code you want to run is actually a runnable program, and that it's from a trusted source. If it has a `Main` method, it is likely intended as a runnable program.

If you have a complete and runnable program, but haven't opened it in Visual Studio yet, the first task is to get it into Visual Studio.  You can also compile and run from the command line. See [Build a C# program on the command line]().

If it's only a single file, the easiest way to get it into Visual Studio is to open an empty C# console project, copy the contents of your code file from wherever its source is, and paste it into the .cs file in the project. When you paste the code, overwrite or delete the code that was there before. You might need to rename the file to match the original code.

If it's a few files, you can add files to your project, and copy the code into the files. Make sure to rename them to match what the program expects.  If the code consists of larger numbers of files, use the Windows **File Explorer** to copy the files into your project's folder, and use **Add** > **Existing Item** to select the files and import them into your project.  If the number of files is large, you might want to consider using **Open Folder**. See the [Starting from a folder with many files](#starting-from-a-folder-with-many-files) section.

You can look at the red squiggly lines and at the **Error List** to see if the program has any errors, even before you compile and run it.

Once you have all the files in the project, press the green arrow (**Start** button) on the main Visual Studio toolbar, or press **F5** or **Ctrl**+**F5** to run the program. When you use the **Start** button, it runs under the debugger.

Visual Studio builds the project and reports any build (compile) errors.

To build properly, the code must be correct, and have the right references set up. Most .NET references are in the form of NuGet packages. Usually, if you find source code, the publisher or author will explain what packages that code depends on.  Install those NuGet packages and try building again.

If there are code errors, you might have some incorrect code, but it could also be that the code was written for a different version of .NET or requires some other dependencies. If there is any information available on the version that the author or publisher of the code was using, you can change the target framework to match that, or install that version of .NET, if it's not already installed.  Many simpler programs are compatible across a wide range of .NET versions; it is possible to write to the .NET Standard subset which is relatively portable. Well-written code intended for the widest possible use avoids constructs that limit its portability.

If it builds, but doesn't run, make sure the code is set up as a runnable program (executable). Look for a `Main` method to make sure your program can run on its own as an executable. If you don't see a Main method, the code doesn't have an entry point, so that usually indicates it's a library or an incomplete program, and it's meant to be called from another program.

## Starting from a folder with many files

When you are working with a folder of many files, first see if there's already a project or solution.  If the program was created with Visual Studio, you should find a project file or a solution file. Look for files with the .csproj extension or .sln extension and in the Windows File Explorer, double-click on one of them to open them in Visual Studio. See [Starting from a Visual Studio solution or project](#starting-from-a-visual-studio-solution-or-project).

If you truly have a large folder structure of C# code files, and no project or solution, then try opening the top-level folder by using the **Open folder** method in Visual Studio.  

When Visual Studio 2019 or later starts up, choose **Open a folder** and choose the top-level folder that contains your code. If it opens successfully, try building and running the code by using **Ctrl**+**F5** or **F5**.

## Starting from a GitHub or Azure DevOps repo

If the code you want to run is in GitHub or in an Azure DevOps repo, you can use Visual Studio to open the project directly from the repo. See []().

## Next steps



## See also
