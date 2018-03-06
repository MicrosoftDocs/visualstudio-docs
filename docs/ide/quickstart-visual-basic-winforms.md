---
title: "Quickstart: Create a Windows Forms app in Visual Studio with Visual Basic | Microsoft Docs"
ms.custom: ""
ms.date: "12/04/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-acquisition"
ms.tgt_pltfrm: ""
ms.topic: "quickstart"
ms.devlang: "vb"
author: "TerryGLee"
ms.author: "tglee"
manager: ghogen
dev_langs: 
  - vb
ms.workload: 
  - "multiple"
---
# Quickstart: Create a Windows Forms app in Visual Studio with Visual Basic
In this 5-10 minute introduction to the Visual Studio integrated development environment (IDE), you'll create a simple Visual Basic application that has a Windows-based user interface (UI).

If you haven't already installed Visual Studio, go to the [Visual Studio Downloads](https://aka.ms/vsdownload?utm_source=mscom&utm_campaign=msdocs) page to install it for free.

## Create a project
First, you'll create a Visual Basic application project. The project type comes with all the template files you'll need, before you've even added anything.  

1. Open Visual Studio 2017.  

2. From the top menu bar, choose **File** > **New** > **Project...**.  

3. In the **New Project** dialog box in the left pane, expand **Visual Basic**, and then choose **Windows Classic Desktop**. In the middle pane, choose **Windows Forms App (.NET Framework)**. Then name the file `HelloWorld`.  

     If you don't see the **Windows Forms App (.NET Framework)** project template, cancel out of the **New Project** dialog box and from the top menu bar, choose **Tools** > **Get Tools and Features...**. The Visual Studio Installer launches. Choose the **.NET desktop development** workload, then choose **Modify**.  

     ![.NET Core workload in the Visual Studio Installer](../ide/media/install-dot-net-desktop-env.png)  

## Create the application
After you select your Visual Basic project template and name your file, Visual Studio opens a form for you. A form is a Windows user interface. We'll create a "Hello World" application by adding controls to the form, and then we'll run the application.   

### Add a button to the form  

1. Click **Toolbox** to open the Toolbox fly-out window.

     ![Click the Toolbox to open the Toolbox window](../ide/media/vb-toolbox-toolwindow.png)  

     (If you don't see the Toolbox fly-out option, you can open it from the menu bar. To do so, click **View** > **Toolbox**. Or, press **Ctrl**+**Alt**+**X**.)

2. Click the **Pin** icon to dock the Toolbox window.

     ![Click the Pin icon to pin the Toolbox window to the IDE](../ide/media/vb-pin-the-toolbox-window.png)  
3. Click the **Button** control and then drag it onto the form.

     ![Add a button to the form](../ide/media/vb-add-a-button-to-form1.png)

4. In the **Appearance** section of the **Properties** window, type "Click this", and then press **Enter**.

     ![Add text to the button on the form](../ide/media/vb-button-control-text.png)  

     (If you don't see the Properties window, you can open it from the menu bar. To do so, click **View** > **Properties Window**. Or, press **F4**.)

5. In the **Design** section of the **Properties** window, change the name from "Button1" to "btnClickThis", and then press **Enter**.

     ![Add a function to the button on the form](../ide/media/vb-button-control-function.png)

### Add a label to the form
Now that we've added a button control to create an action, let's add a label control to send text to.

1. Select the **Label** control from the Toolbox window, and then drag it onto the form and drop it beneath the **Click this** button.

2. In the **Design** section of the **Properties** window, change the name from "Label1" to "lblHelloWorld", and then press **Enter**.

### Add code to the form

1. In the **Form1.vb &#91;Design&#93;** window, double-click the **Click this** button to open the **Form1.vb** window.

      (Alternatively, you can expand **Form1.vb** in the **Solution Explorer** window, and then click **Form1**.)

2. In the **Form1.vb** window, between the **Private Sub** line and the **End Sub** line, type or paste  `lblHelloWorld.Text = "Hello World!"`.

     ![Add code to the form form](../ide/media/vb-add-code-to-the-form.png)

## Run the application
1. Click the **Start** button to run the application.

     ![Click Start to debug and run the app](../ide/media/vb-click-start-hello-world.png)

   Several things will happen. In the Visual Studio IDE, the Diagnostics Tools window will open, and an Output window will open, too. But outside of the IDE, a Form1 dialog box appears. It will include your **Click this** button and text that says "Label1".

2. Click the **Click this** button in the **Form1** dialog box. Notice that the "Label1" text changes to "Hello World!".

    ![A Form1 dialog box that includes Label1 text ](../ide/media/vb-form1-dialog-hello-world.png)

Congratulations on completing this quickstart! We hope you learned a little bit about Visual Basic and the Visual Studio IDE. If you'd like to delve deeper, please continue with a tutorial in the **Tutorials** section of the table of contents.  

## See also   
* [Quickstart: Create a console app in Visual Studio with Visual Basic](quickstart-visual-basic-console.md)
* [Learn more about Visual Basic IntelliSense](visual-basic-specific-intellisense.md)  
