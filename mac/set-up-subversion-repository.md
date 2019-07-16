---
title: Setting Up a Subversion Repository
description: Using Subversion in Visual Studio for Mac.
author: jmatthiesen
ms.author: jomatthi
ms.date: 05/06/2018
ms.assetid: 0D58FB37-530E-495B-BED6-FD499477A9B6
---
# Set up a Subversion repository

Subversion is a centralized _version control system_, meaning that there's a single server that contains all files and revisions, from which users can check out any version of any file. When files are checked out from a remote Subversion repository, the user gets a snapshot of the repository at that point in time.

To use Subversion for your version control, it must be installed on your machine. To check if Subversion is installed your machine, use the following command in Terminal:

```bash
svn --version
```

This command returns the version number.

If Subversion isn't already installed, the easiest way to get it is by installing the _Xcode Command Line Tools_. Use the command below to install Xcode Command Line Tools and Subversion.

```bash
xcode-select --install
```

Once Subversion is installed on your machine, use the following steps to publish your project in SVN.

1. Create a free SVN repository online. For this example, [Assembla](https://app.assembla.com/) was used. Once created, a URL will be provided, which will be used to connect to the repository:

    ![copy the SVN URL](media/version-control-subversion1-sml.png)

2. Open or create a Visual Studio for Mac Project.

3. Right click on the Project and select **Version Control > Publish in Version Control...**:

    ![Start Publishing Project](media/version-control-subversion2.png)

4. In the **Connect to Repository** tab, select **Subversion** from the top drop-down.

5. Enter the URL from step 1. Once the URL is entered, the other fields are populated by default:

    ![Select Repository and Enter details Dialog](media/version-control-subversion3.png)

7. Click **OK** and then confirm by pressing **Publish**.

7. If prompted, enter your credentials for the site on which you create the repository, as illustrated below:

    ![Entering credentials for subversion repo](media/version-control-subversion5.png)

8. All the version control commands available should now be visible in the version control menu.

## See also

- [Working with Subversion](working-with-subversion.md)