# Create an AI project from existing code

Once you've [installed Visual Studio Tools for AI](installation.md), it's easy to bring existing Python code into a Visual Studio project. 

> [!Important]
>
> The process described here does not move or copy the original source files. If you want to work with a copy, duplicate the folder first.

1. Launch Visual Studio and select **File > New > Project**.

1. In the **New Project** dialog, search for "**AI Tools**", select the "**From Existing Python code**" template, give the project a name and location, and select **OK**.

	![New Project from Existing Code, step 1](media\create-project-existing\new-ai-project.png)

1. In the wizard that appears, set the path to your existing code, set a filter for file types, and specify any search paths that your project requires, then select **OK**. If you don't know what search paths are, leave that field blank.


![New Project from Existing Code, step 2](media\create-project-existing\azurebatch-newproject.png)

> If your existing code is part of an Azure Machine Learning project, check the "**Is Azure Machine Learning folder**" to ensure successful conversion of important Azure Machine Learning configuration details like which Experimentation account, which Workspace, the compute contexts to use and more.

1. To set a startup file, locate the file in Solution Explorer, right-click, and select **Set as Startup File**.

8. If desired, run the program by pressing Ctrl+F5 or selecting **Debug > Start Without Debugging**. 

> [!div class="nextstepaction"]
> [Tutorial: Working with Python in Visual Studio](../python/tutorial-working-with-python-in-visual-studio-step-00-installation.md)

## See Also

- [Creating an environment for an existing Python interpreter](https://docs.microsoft.com/visualstudio/python/python-environments#creating-an-environment-for-an-existing-interpreter)