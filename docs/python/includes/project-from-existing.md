---
ms.date: 04/18/2024
ms.topic: include
---

Follow these steps to create a project from existing files.

> [!IMPORTANT]
> The following process doesn't move or copy any original source files.
> If you want to work with a copy of your files, first duplicate the folder and then create the project.

1. Launch Visual Studio and select **File** > **New** > **Project**.

1. In the **Create a new project** dialog, search for _python_, and select the **From Existing Python code** template, and select **Next**.

1. In the **Configure your new project** dialog, enter a project **Name** and **Location**, choose the solution to contain the project, and select **Create**.

1. In the **Create New Project from Existing Python Code** wizard, set the **Folder path** to your existing code, set a **Filter** for file types, and specify any **Search paths** that your project requires, then select **Next**. If you don't know the search paths, leave the field blank.

   :::image type="content" source="../media/projects-from-existing-1.png" alt-text="Screenshot of a New Project creation from Existing Code, including choosing the folder path, file type filters, and search paths." lightbox="../media/projects-from-existing-1.png":::

1. On the next page, select the **Startup file** for your project. Visual Studio selects the default global Python interpreter and version. You can change the environment by using the dropdown menu. When you're ready, select **Next**.

   > [!NOTE]
   > The dialog shows only files in the root folder. If the file you want is in a subfolder, leave the startup file blank. You can set the startup file in **Solution Explorer**, as described in a later step.

   :::image type="content" source="../media/projects-from-existing-2.png" alt-text="Screenshot of New Project Creation from Existing Code window, including choosing the startup file and Python environment." lightbox="../media/projects-from-existing-2.png":::

1. Select the location to store the project file (a _.pyproj_ file on disk). If applicable, you can also include autodetection of virtual environments and customize the project for different web frameworks. If you're unsure of these options, leave the fields set to the defaults.

   :::image type="content" source="../media/projects-from-existing-3.png" alt-text="Screenshot of a New Project creation from Existing Code window, including the location for the project file and other optional settings." lightbox="../media/projects-from-existing-3.png" :::

1. Select **Finish**.

   Visual Studio creates the project and opens it in **Solution Explorer**. If you want to move the _.pyproj_ file to a different location, select the file in **Solution Explorer**, and then select **File** > **Save As** on the toolbar. This action updates file references in the project, but it doesn't move any code files.

1. To set a different startup file, locate the file in **Solution Explorer**, right-click the file, and select **Set as Startup File**.
