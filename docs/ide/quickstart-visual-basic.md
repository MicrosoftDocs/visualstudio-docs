---
title: "Quickstart: Use Visual Studio to create your first Visual Basic app | Microsoft Docs"
ms.custom: ""
ms.date: "12/04/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.devlang: "vb"
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
dev_langs:
  - vb
---
# Quickstart: Use Visual Studio to create your first Visual Basic app
In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple Visual Basic application. If you haven't already installed Visual Studio, click the following button to download and install it for free:

> [!div class="button"]
> [Download Visual Studio 2017](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs)
<br/>

## Create a project
First, you'll create a Visual Basic application project. The project type comes with all the template files you'll need, before you've even added anything!  

1. Open Visual Studio 2017.  

2. From the top menu bar, choose **File** > **New** > **Project...**.  

3. In the **New Project** dialog box in the left pane, expand **Visual Basic**, and then choose **Windows Classic Desktop**. In the middle pane, choose **Windows Forms App (.NET Framework)**. Then, name the file `HelloWorld`.  

     If you don't see the **Windows Forms App (.NET Framework)** project template, cancel out of the **New Project** dialog box and from the top menu bar, choose **Tools**, **Get Tools and Features...**. The Visual Studio Installer launches. Choose the **.NET desktop development** workload, then choose **Modify**.  

     ![.NET Core workload in the Visual Studio Installer](../ide/media/install-dot-net-desktop-env.png)  

## Add a button to the form  
After you select your Visual Basic project template and name your file, Visual Studio opens a form for you. A form is any interface in Windows. Let's add some controls to it.

1. Click **Toolbox**. It's on left side of the IDE.

     ![.NET Core workload in the Visual Studio Installer](../ide/media/vb-toolbox-toolwindow.png)  

> [!TIP]
> Notice that the **Toolbox** window covers the form. It's easier to drag-and-drop controls onto your form if you dock the Toolbox. To do so, click **Window** > **Dock** from the menu bar.

2.  Double-click the **Button** control. Notice that a button appears on the form.


## Add a label to the form
Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum purus eget augue sagittis pellentesque. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nullam feugiat efficitur sem a pharetra. Proin condimentum mi elit, id euismod tellus placerat a. Nulla scelerisque sem eu efficitur lobortis. Suspendisse potenti.

## View the code behind the form

 ```vb
 Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
     MessageBox.Show("Hello World!")
 End Sub
 ```  



## Run the application
1. Click **Start** to run the application.  
2. Notice that the label control in your form says "Hello World!"

Congratulations on completing this quickstart! We hope you learned a little bit about Visual Basic and the Visual Studio IDE. If you'd like to delve deeper, please continue with a tutorial in the **Tutorials** section of the table of contents.  

## See also   
* [Getting Started with C# and Visual Basic using Visual Studio](getting-started-with-visual-csharp-and-visual-basic.md)
* [Visual Basic IntelliSense](visual-basic-specific-intellisense.md)  
