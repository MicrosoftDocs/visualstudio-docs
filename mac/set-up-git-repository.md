---
title: Setting up a Git Repository in Visual Studio for Mac
description: Using Git and Subversion in Visual Studio for Mac.
author: asb3993
ms.author: amburns
ms.date: 04/14/2017
ms.topic: article
ms.assetid: E992FA1D-B2AD-4A28-ADC6-47E4FC471060
---

# Setting Up a Git Repository

Git is a distributed version control system that allows teams to work on the same documents simultaneously. This means that there is a single server that contains all the files, but whenever a repository is checked out from this central source, the entire repository is cloned locally to your machine.

To set up a Git repository, execute the following steps:

1. Create a new Git repo at github.com:

    ![Create new git repo](media/version-control-git1-sml.png)

2. Set Repo Name, description, and privacy. Do **not** initialize Repo. Set .gitignore and license to None:

    ![Set details of git repo](media/version-control-git2.png)

3. The next place will give you an option to display and copy either the HTTPS or SSH address to the repo you have just created:

    ![view and copy address](media/version-control-git3.png)
  You will need the HTTPS address to point Visual Studio for Mac to this repo.

4. Return to your open Project in Visual Studio for Mac. 

5. In the Menu bar, select **Version Control > Checkout**:

    ![Start checkout in Visual Studio for Mac](media/version-control-git4-sml.png)

6. This will display the **Select Repository** dialog. Choose the **Registered Repositories** tab, and press the **Add** button:

    ![](media/version-control-git5.png)

7. Enter the name of the repository as you would like it to display locally, and paste in the URL from step #3. Your Repository Configuration dialog should look similar to the following, press OK: 

    ![Enter git details dialog](media/version-control-git6.png)

8. To attempt to publish the app to Git, select the repository just created,  and ensure that both **Module Name** and **Message** text fields are completed:

    ![Attempt to publish project to git](media/version-control-git7.png)

9. Click **Okay**, and then **Publish** from the alert dialog: 

    ![Start Publishing dialog](media/version-control-git8-sml.png)

10. If you have not already entered your Git credentials in Visual Studio for Mac preferences, enter them now. First, you need to create an Access Token, which is used in place of a password. Follow the steps in the Git [Access Token](https://help.github.com/articles/creating-an-access-token-for-command-line-use/) documentation to do this.

11. Enter the username and Personal Access Token, and press **Okay**:

    ![Enter username and password for git](media/version-control-git9-sml.png)

12. After a few seconds, the Solution should be published. Confirm this by browsing the Version Control menu item, which should now be populated with many options: 

    ![Version Control Menu](media/version-control-git10.png)

13. Finally, select **Push Changes…** to push the changes to the **remote** repository. This will allow all appropriate users to view it on github.com: 

    ![Push Changes to remote repository](media/version-control-git11.png)