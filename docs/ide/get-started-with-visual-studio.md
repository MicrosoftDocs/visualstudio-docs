---
redirect_url: ../ide/visual-studio-ide
---
# Get Started with Visual Studio
Visual Studio is a powerful tool for developing your apps. If you haven't done so already, go ahead and download and install [Visual Studio](https://www.visualstudio.com/vs/). See the video [Getting Started with Visual Studio - Setting up your IDE](https://www.youtube.com/watch?v=xLCedknQkN0&list=PLReL099Y5nRfw6VNvzMkv0sabT2crbSpK&index=1) for more information about downloading Visual Studio and configuring it the way you want.

## Visual Studio tour
Visual Studio has a group of tool windows, menus, and toolbars collectively known as the integrated development environment, or IDE. The Visual Studio IDE helps you accomplish your development tasks. Here's a quick overview of IDE items you will likely use most often.

### Code editor
One of the most heavily-used tool windows in Visual Studio, this is where you write, view, and navigate through your code.

![Code Editor](../ide/media/VSIDE_CodeWindow.png)

As you enter code, the code editor helps you more quickly and easily write and find your code by providing features such as statement completion, syntax colorization, map mode, and more. For more information, see the video [Getting Started with Visual Studio - Editing and navigating your code](https://www.youtube.com/watch?v=4glwwioCVjA&list=PLReL099Y5nRfw6VNvzMkv0sabT2crbSpK&index=5)

Some solution types may include windows called *forms*, such as Windows Presentation Foundation (WPF) forms, Windows forms, Extensible Application Markup Language (XAML) forms and others. In those cases, you will also see a visual designer in this space that lets you drag and drop controls, such as buttons and list boxes, onto the form that users interact with when they run your app.

### Solution Explorer
A tool window called **Solution Explorer** lists all your code files. Solution Explorer can help organize your code by grouping its files into solutions and projects. The project in bold is called the *startup project*. It's the first code that runs when you start your solution. You can change the startup project. See the video [Getting Started with Visual Studio - Building blocks of the IDE](https://www.youtube.com/watch?v=JHc3_gsCmZg&index=2&list=PLReL099Y5nRfw6VNvzMkv0sabT2crbSpK) for more information.

![Solution Explorer collapsed nodes](../ide/media/VSIDE_SolutionExplorer2_callouts.png)

 In addition to solutions and projects, Solution Explorer lists all the files in each project when you expand the project's node. Each project contains one or more files, such as source code files and resource files such as images or libraries.

![Solution Explorer](../ide/media/VSIDE_SolutionExplorer3.png)

To see properties for solutions, projects, and files, choose the **Properties** command on the shortcut (right-click) menu, or choose **View, Properties Window** on the menu.

![Properties window](../ide/media/VSIDE_SolutionExplorer4.png)

You don't have to create a solution or project, however, to get started coding. You can simply jump right in and open code files in Visual Studio, such as files cloned from a Git repo, and start editing them right away. The files will appear in Solution Explorer and get syntax colorization, basic statement completion, and more, just like traditional solutions. See [Develop code in Visual Studio without projects or solutions](../ide/develop-code-in-visual-studio-without-projects-or-solutions.md) for more information.

### Toolbar and menus
To run your project, create new solutions, save files, and more, use the Visual Studio toolbar and menu commands. For example, once your code is ready to run for debugging, you can choose the **Start** button on the toolbar, or you can choose **Debug, Start Debugging** on the menu. To create a new solution, choose the **New Project** button, or choose **File, New, Project** on the menu, and so forth.

![Visual Studio toolbar](../ide/media/VSIDE_SolutionExplorer5_callouts.png)

Note that toolbar icons and menu commands can change depending on the context, meaning the item currently selected. Nearly all commands can be accessed via keyboard commands as well as through a mouse.

### Team Explorer
**Team Explorer** enables you to connect to source control tools such as [Git](https://git-scm.com/) and [Team Foundation Version Control (TFVC)](https://www.visualstudio.com/en-us/docs/tfvc/overview) to store your code locally or share it with others on a hosted service. You can also use it to track tasks and more.

See the videos [Getting Started with Visual Studio - Building blocks of the IDE](https://www.youtube.com/watch?v=JHc3_gsCmZg&index=2&list=PLReL099Y5nRfw6VNvzMkv0sabT2crbSpK) and [Getting Started with Visual Studio - Opening a project from Source Control](https://www.youtube.com/watch?v=pc9vX_4RGV4&list=PLReL099Y5nRfw6VNvzMkv0sabT2crbSpK&index=3) for more information.

![Team Explorer](../ide/media/TeamExplorer.png)

### Output window
The **Output** window is where Visual Studio sends its notifications, such as debugging and error messages, compiler warnings, publishing status messages, and more. Each message type has its own tab.

![Output window](../ide/media/VSIDE_OutputWindow.png)

To learn more about how to use the Output window for debugging, see [The Output window while debugging with Visual Studio](https://blogs.msdn.microsoft.com/visualstudioalm/2015/02/09/the-output-window-while-debugging-with-visual-studio/).

## First steps
- **Get the big picture** - To get an overview of many of the major features in Visual Studio, take a tour! See [Visual Studio IDE feature tour](../ide/visual-studio-ide.md).
- **Setup** - To learn about how to download and install Visual Studio, see [Install Visual Studio 2017](../install/install-visual-studio.md).
- **The basics** - To learn more about how Visual Studio works, see [Get Started Developing with Visual Studio](../ide/get-started-developing-with-visual-studio.md).
- **Settings** - To learn how to customize Visual Studio to fit the way you like to work. See [Personalizing the Visual Studio IDE](../ide/personalizing-the-visual-studio-ide.md).
- **Tutorials** - To learn more about how to develop code in Visual Studio, go through a tutorial, such as [Getting Started with Visual C# and Visual Basic](../ide/getting-started-with-visual-csharp-and-visual-basic.md) or [Getting Started with C++ in Visual Studio](../ide/getting-started-with-cpp-in-visual-studio.md).
- **Videos** - To learn more about other features and aspects of Visual Studio, check out videos on the [Microsoft Visual Studio channel](https://www.youtube.com/user/VisualStudio/videos) on YouTube, Visual Studio videos on [Channel 9](https://channel9.msdn.com/Tags/visual+studio), or on the [Microsoft Virtual Academy](https://mva.microsoft.com/product-training/visual-studio-courses#!jobf=Developer).

## Access cloud-based resources
If you want to use cloud-based resources in your app or game, you can do that by including [Azure services](https://azure.microsoft.com/en-us/services/). You can get the Azure SDK for .NET by installing the **Azure development** workload using the new Visual Studio Installer. The packages that are installed are at the same feature level as the 2.9.5 version of the SDK. For this version of Visual Studio and all future versions, the Azure SDK for .NET will only be available from the Visual Studio installer.

After installing the Azure development workload, a new tool window becomes available in Visual Studio called **Cloud Explorer**. Cloud Explorer enables you to browse and manage your Azure assets and resources from within Visual Studio. If a particular operation requires the Azure portal, Cloud Explorer provides links that take you to the place in the Azure portal you need to go.

![Cloud Explorer](../ide/media/VSIDE_CloudExplorer.png)

To learn more about using Cloud Explorer, see [Managing Azure resources with Cloud Explorer](https://azure.microsoft.com/en-us/documentation/articles/vs-azure-tools-resources-managing-with-cloud-explorer/).
Installing the Azure development workload also gives you [Visual Studio Tools for Azure](https://www.visualstudio.com/vs/azure-tools/) as well as other related tools.

## Tips and tricks
For shortcuts and handy tips and tricks on how to get more out of Visual Studio, see the following.
- [Getting Started with Visual Studio - Tips & Tricks](https://www.youtube.com/watch?v=vmXqGwn1Glk&list=PLReL099Y5nRfw6VNvzMkv0sabT2crbSpK&index=4)
- [Productivity Tips for Visual Studio](../ide/productivity-tips-for-visual-studio.md)
- [Visual Studio Tips and Tricks](https://channel9.msdn.com/events/TechEd/2013/DEV-B353)
- [C++ Debugging Tips and Tricks](https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/C-Plus-Plus-Debugging-Tips-and-Tricks)
- [Visual Studio's most useful (and underused) tips [Scott Hanselman blog]](https://www.hanselman.com/blog/VisualStudiosMostUsefulAndUnderusedTips.aspx)
- [Getting Started with Visual Studio - Installing Visual Studio extensions](https://www.youtube.com/watch?v=MWLLQaknRZY&list=PLReL099Y5nRfw6VNvzMkv0sabT2crbSpK&index=7)
