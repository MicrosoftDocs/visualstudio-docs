---
title: "Walkthrough: Including a Component in your project"
description: This document covers how to include a component from the Xamarin Component Store in a project. It walks through connecting Xamarin Studio or Visual Studio to a Xamarin account, as well as downloading and including a component using the IDE integration features.
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: 5C800815-0B13-4B27-B017-95FCEF1A0EA2
---

<a name="Overview" class="injected"></a>


# Overview

Xamarin Components provide a variety of different components to use in *Xamarin.iOS* and *Xamarin.Android* applications. 
Components range from user interface controls to code libraries, as well as user interface themes. They allow applications built on 
Xamarin to create rich user experiences and integrate with many different third party services with very little work.

In this article, we’ll look at how to include a component in a project and demonstrate the tool chain that makes the process seamless.

 <a name="Walkthrough" class="injected"></a>


# Walkthrough

Let’s walk through the process to incorporate a component from the *Xamarin Components Store*. 
For this walkthrough, we’ll work with a project named `HelloComponents`, created from the Xamarin.iOS <kbd>Single View Application</kbd> template in Xamarin Studio or the <kbd>HelloWorld</kbd> <kbd> Application</kbd> 
template in Visual Studio respectively. However, the steps to include a component are the same irrespective of the project template used.

 <a name="Component_Store_from_Xamarin_Studio" class="injected"></a>


## Using the Component Store from Xamarin Studio

 <a name="Creating_a_New_Project" class="injected"></a>


### Creating a New Project

First, create a project named `HelloComponents` as shown below for Xamarin Studio. The project below is a Xamarin.iOS project, but you can use a Xamarin.Android project if you wish:

 [ ![](Images/components-walkthrough-00New.png)]()

 <a name="Launching_the_Component_Manager" class="injected"></a>


### Launching the Component Manager

With the project loaded in Xamarin Studio, launch the *Xamarin Components Manager* by either double-clicking on the <span class="UIItem">Components</span> folder
in the <span class="UIItem">Solution Pad</span>, or by right-clicking on the Components folder and selecting <kbd>Get More Components</kbd>:

 [ ![](Images/components-walkthrough-01New.png)]()

The Component Manager is where all previously downloaded components are displayed. 
The first time the Component Manager opens, no components will have yet been added, so it shows default screen below:

 [ ![](Images/components-walkthrough-02New.png)]()

 <a name="Logging_into_the_Component_Store" class="injected"></a>


### Logging into the Component Store

Accessing the Components Store requires a Xamarin Store account. To log in from the Component Manager, 
click the <kbd>Login to your Xamarin Account</kbd> button in the upper right. This will launch the account dialog, allowing you to log in:

 [ ![](Images/components-walkthrough-03New.png)]()

 <a name="Component_Store_from_Visual_Studio" class="injected"></a>


## Using the Component Store from Visual Studio

 <a name="Login_to_Xamarin_Account" class="injected"></a>


### Login to your Xamarin Account

Follow the steps below to do this.

In Visual Studio, go to the **Tools > Xamarin Account...** menu item:

![](Images/components-walkthrough-image20.png)

The Xamarin Account dialog will appear, click **Log In** to enter your Xamarin credentials:

![](Images/components-walkthrough-image21.png)

Enter your Xamarin Account details and click **Log In**:

 ![](Images/components-walkthrough-image22.png)

After a few seconds, your Xamarin subscription will be activated with the relevant subscription tier that you have purchased:

![](Images/components-walkthrough-image23.png)

You'll now be returned to the Xamarin Account dialog screen indicating that your Xamarin Account has been successfully linked to Xamarin for Visual Studio:

![](Images/components-walkthrough-image25.png)

 <a name="Create_New_Project" class="injected"></a>


### Create New Project

After logging in to a Xamarin account, create a new iOS project by selecting <kbd>File &gt; New &gt; Project</kbd>. Select the <kbd>HelloWorld Application</kbd> template under the <kbd>iOS &gt; iPhone</kbd> section and name the project `HelloComponents`, 
as shown below:

![](Images/components-walkthrough-06.png)

 <a name="Launching_the_Component_Manager" class="injected"></a>


### Launching the Component Manager

With the project created, right-click on the <kbd>Components</kbd> folder in the <kbd>Solution Explorer</kbd> and select <kbd>Get More Components</kbd>:

 ![](Images/components-walkthrough-07.png)

This loads the Components List shown below:

![](Images/components-walkthrough-08.png)

 <a name="Xamarin_Components_List" class="injected"></a>


## Xamarin Components List

After connecting to the Component Store in either Xamarin Studio or Visual Studio, a window, similar to the one below, opens to show all the 
components available in the Component Store:

 ![](Images/components-walkthrough-09.png)

From this window we can:

-  Search for components by name.
-  Filter components by category and tag.
-  Sort components by whether they are featured, number of downloads and name.
-  Make suggestions for components.
-  Submit components.
-  Select a component to include in a project.


 <a name="Including_a_Component" class="injected"></a>


### Including a Component

Let’s include the Alert Center Component. Use the search box to locate it, and double-click on the Alert Center component in the list to open the component’s page:

 ![](Images/components-walkthrough-10.png)

From the component page, select the <kbd>Add to App</kbd> button to download the component and add it
to the current project. When the download completes, the component will be displayed under the
<kbd>Components</kbd> folder in the Solution Pad, with a screen showing details about the component
loaded in the tabbed section of Xamarin Studio.


In Visual Studio, double-click the component in the Solution Explorer in Visual Studio to show the detail screen:

  ![](Images/components-walkthrough-11.png)

 <a name="Component_Detail_Screen" class="injected"></a>


### Component Detail Screen

The detail screen under the tab includes the following sections:

-  <kbd>Getting Started</kbd> &ndash; Code snippets to get started using the component.


 ![](Images/components-walkthrough-12New.png)

-  <kbd>Samples</kbd> &ndash; Sample projects that use the component, which can be added to the current solution.


 ![](Images/components-walkthrough-13New.png)

-  <kbd>Assemblies</kbd> &ndash; Assemblies included with the component.


 ![](Images/components-walkthrough-14New.png)

 <a name="Adding_Component_Code" class="injected"></a>


### Adding Component Code

Let’s use the code sample from the Getting Started tab to add the Alert Center component to our project.

In the `ViewController` class, first add the following using directive:

	using Xamarin.Controls;

Then, add the following code to the `ViewDidLoad` method:


	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();

		AlertCenter.Default.PostMessage ("Knock knock!", "Who's there?");
		AlertCenter.Default.PostMessage ("Interrupting cow.", "Interrupting cow who?",
			                        UIImage.FromFile ("cow.png"), delegate {
			Console.WriteLine ("Moo!");
		});
	}


Also add an image named `cow.png`, which the AlertCenter code above will display in the alert. 
In lieu of creating an image, there is a cow.png in the sample code that accompanies this article that can be used. 

With the code and images above added, running the application now displays an alert as shown below:

 ![](Images/components-walkthrough-demo.png)

 <a name="Summary" class="injected"></a>
 
# Configuring the Components Directory
 
It is possible to configure the directory where Xamarin components will be extracted to before being referenced by a project, within your solution. This allows multiple solutions to use the same directory and prevents the assembly references from being modified within the context of different solutions.
 
 To configure the components directory, a **components.config** file will need to be created if it doesn't already exist. This file should contain the following information:
 
	 <components>
	     <config>
	        <add key="cachePath" value="..\Components"></add>
	    </config>
	 </components>

Where `value` is the path to the components directory you wish to point to.

When a solution is opened Xamarin Studio will check for a **components.config** file in several locations based on the solution's directory. Consider if the solution is in the directory /Users/myusername/Projects/AwesomeApp/, then the full list of locations checked is as follows, in order:

1. /Users/myusername/Projects/AwesomeApp/.components/components.config
2. /Users/myusername/Projects/AwesomeApp/components.config
3. /Users/myusername/Projects/components.config
4. /Users/myusername/components.config
5. /Users/components.config
6. /components.config
7. ~/Library/Preferences/Xamarin/Components/components.config [Mac]
	* %AppData%\Xamarin\Components\components.config [Windows]
	
If the **components.config** file is placed in a directory with a number of solutions, all solutions will be able to access and use this common file.  If no file is available, then the default components directory will be used.

For more detailed information on this topic, please refer to [Matt Ward's blog post](http://lastexitcode.com/blog/2015/05/10/XamarinComponentsDirectoryConfiguration/) detailing Xamarin components directory configuration.

# Summary

This document covered how to use the Xamarin Component Store to incorporate a component into an application. It showed the
IDE integration with the Component Store as well as features of the store itself, such as searching and filtering, which
make finding the right component a breeze. It also showed how to download and include a component with a single click, as
well as using the code provided with a component to get up and running quickly. Finally, it touched on how to confiure the components directory in Xamarin Studio.

