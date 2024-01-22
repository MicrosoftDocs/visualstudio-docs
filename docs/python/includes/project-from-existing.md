---
ms.date: 01/21/2024
ms.topic: include
---

1. Launch Visual Studio and select **File** > **New** > **Project**.

1. In the **Create a new project** dialog, search for _python_, and select the **From Existing Python code** template. Enter a project name and location, choose the solution to contain the project, and select **Create**.

1. In the **Create New Project from Existing Python Code** wizard, set the folder path to your existing code, set a filter for file types, and specify any search paths that your project requires, then select **Next**. If you don't know the search paths, leave the field blank.

   :::image type="content" source="../media/projects-from-existing-1.png" alt-text="Screenshot of a New Project creation from Existing Code, including choosing the folder path, file type filters, and search paths." lightbox="../media/projects-from-existing-1.png":::

1. On the next page, select the startup file for your project. Visual Studio selects the Python interpreter and version by default. You can change the environment by using the dropdown menu. When you're ready, select **Next**.

   > [!Note]
   > The dialog shows only files in the root folder. If the file you want is in a subfolder, leave the startup file blank. You can set the startup file later in **Solution Explorer**, as described in a later step.

   :::image type="content" source="../media/projects-from-existing-2.png" alt-text="Screenshot of New Project Creation from Existing Code window, including choosing the startup file and Python environment." lightbox="../media/projects-from-existing-2.png":::

1. Select the location where you want to save the project file (a _.pyproj_ file on disk). If applicable, you can also include autodetection of virtual environments and customize the project for different web frameworks. If you're unsure of these options, leave the fields set to the defaults.

   :::image type="content" source="../media/projects-from-existing-3.png" alt-text="Screenshot of a New Project creation from Existing Code window, including the save location for the project file and other optional settings." lightbox="../media/projects-from-existing-3.png" :::

1. Select **Finish**.

   Visual Studio creates the project and opens it in **Solution Explorer**. If you want to move the _.pyproj_ file to a different location, select the file in **Solution Explorer**, and then select **File** > **Save As** on the toolbar. This action updates file references in the project, but it doesn't move any code files.

1. To set a different startup file, locate the file in **Solution Explorer**, right-click the file, and select **Set as Startup File**.
