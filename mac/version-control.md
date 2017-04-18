---
id: 49917483-28AA-4598-A847-71F1F2E0DCB5
title: Version Control
subtitle: Using Git and Subversion in Xamarin Studio.
brief: This document provides an overview of the Version Control Systems in Xamarin Studio.
dateupdated: 2016-09-13
---

# Overview

Version control is a system of managing files over many different versions, and – in software development – is generally contributed to by many developers. The principal purpose of any version control system (_VCS_) is to find a solution that enables all users to read and write to files simultaneously.


At the core of any version control system is a _repository_, which acts as the central data store for all the different files – similar to a file server. However, unlike a file server, the repository contains the entire history of the project and all revisions that have been made.

If the repository is the central data store, it is logical for each user to have a local store of the data, allowing them to work on it. This is called a _working copy_. In Xamarin Studio your working copy will appear just as any other local directory on your machine, allowing you to read and write from any of the files. However, because Xamarin Studio has Version control system integration, you can leverage the power of Subversion and Git without leaving the IDE.

Subversion is a centralized version control system. This means that there is a single server that contains all files and revisions from which users can check out any version of any file. When files are checked out from a remote Subversion repository, the user will get a snapshot of the repo at that particular point in time.

Git is a distributed version control system that allows teams to work on the same documents simultaneously. This means that there is a single server that contains all the files, but whenever a repository is checked out from this central source, the entire repository is cloned locally to your machine.

This guide will explore setting up Git and Subversion repositories through Xamarin Studio, and also simple functionality such as reviewing, committing, and pushing changes.

# Basic Concepts 

## Setting Up a Git Repository

To set up a Git repository, execute the following steps:

1. Create a new Git repo at github.com:</br>[ ![](Images/git1-sml.png)](Images/git1.png)
2. Set Repo Name, description, and privacy. Do **not** initialize Repo. Set .gitignore and license to None:</br>[ ![](Images/git2.png)](Images/git2.png)
3. The next place will give you an option to display either the HTTPS or SSH address to the repo you have just created:</br>[ ![](Images/git3.png)](Images/git3.png)
  You will need the HTTPS address to point Xamarin Studio to this repo.
4. Return to your open solution in Xamarin Studio. 
5. In the Menu bar, select *Version Control > Publish in Version Control…*:</br>[ ![](Images/git4-sml.png)](Images/git4.png)
6. This will display the **Select Repository** dialog. Choose the **Registered Repositories** tab, and press the **Add** button:</br>[ ![](Images/git5.png)](Images/git5.png)
7. Enter the name of the repository as you would like it to display locally, and paste in the URL from step #3. Your Repository Configuration dialog should look similar to the following, press OK: </br>[ ![](Images/git6.png)](Images/git6.png)
8. To attempt to publish the app to Git, select the repository just created,  and ensure that both **Module Name** and **Message** text fields are completed: </br>[ ![](Images/git7.png)](Images/git7.png)
9. Click **Okay**, and then **Publish** from the alert dialog: </br>[ ![](Images/git8-sml.png)](Images/git8.png)
10. If you have not already entered your Git credentials in Xamarin Studio preferences, enter them now. First, you need to create an Access Token, which is used in place of a password. Follow the steps in the Git [Access Token](https://help.github.com/articles/creating-an-access-token-for-command-line-use/) documentation to do this.
11. Enter the username and Personal Access Token, and press **Okay**:</br>[ ![](Images/git9-sml.png)](Images/git9.png)
12. After a few seconds, the Solution should be published. Confirm this by browsing the Version Control menu item, which should now be populated with many options: </br>[ ![](Images/git10.png)](Images/git10.png)
13. Finally, select **Push Changes…** to push the changes to the **remote** repository. This will allow all appropriate users to view it on github.com:  </br>[ ![](Images/git11.png)](Images/git11.png)

## Setting Up a Subversion Repository

Before starting to use Subversion,  the Xcode command line tools must be installed, which includes the correct svn packages. You can check that SVN is installed in Terminal with the following command:

`svn h`

1. Create a free SVN repository online. For this example [Assembla](https://app.assembla.com/) was used. Once created, a URL will be provided, which will be used to connect to the repository: </br>[ ![](Images/subversion1-sml.png)](Images/subversion1.png)

2. Open or create a Xamarin Studio Project.

3. Right click on the solution and select *Version Control -> Publish in Version Control…*: </br>[ ![](Images/subversion2.png)](Images/subversion2.png)

4. In the **Connect to Repository** tab, select **Subversion** from the top drop down.

5. Enter the URL from step 1. This should populate the other fields by default: </br>[ ![](Images/subversion3.png)](Images/subversion3.png)

7. Click **OK** and then confirm by pressing **Publish**: </br>[ ![](Images/subversion4.png)](Images/subversion4.png)

7. You might be prompted to enter your credentials for the site on which you create the repository. Enter  these as illustrated below: </br>[ ![](Images/subversion5.png)](Images/subversion5.png)

8.	All of the version control commands available should now be visible in the version control menu.



# Working with Git

As mentioned earlier, Git is a distributed version control system that allows teams to work on the same documents simultaneously. This means that there is a central server that contains all the files, but when a repository is checked out from this central source, the entire repository is cloned to the local machine.

The sections below will explore how Git can be used for version control in Xamarin Studio.

## Git version control menu

The image below illustrates the options provided by Xamarin Studio by the Version Control menu item:

[ ![](Images/gitVersionControlMenu.png)](Images/gitVersionControlMenu.png)

## Push and Pull 

Pushing and Pulling are two of the most commonly used actions within Git. To synchronize changes that other people have made to the remote repository, you must **Pull** from there. This is done in Xamarin Studio by selecting *Version Control > Update Solution*.

Once you have updated your files, reviewed and committed them, you then have to **Push** them to the remote repository to allow others to access your changes. This is done in Xamarin Studio by selecting *Version Control > Push Changes*. This will display the Push dialog, allowing you to view the committed changes, and select the branch to push to:

[ ![](Images/gitPush.png)](Images/gitPush.png)

You can also Commit and Push your changes at the same time, via the Commit dialog:

[ ![](Images/commitPush.png)](Images/commitPush.png)

## Blame, Log, and Merge

At the bottom of the window, there are five tabs displayed, as illustrated below:

[ ![](Images/gitTabs.png)](Images/gitTabs.png)

These allow the following actions:

* **Source** – Displays your source code file.
* **Changes** – Displays the change in code between your local file and the base file. You can also compare different versions of the file from different hashes:</br>[ ![](Images/gitChange.png)](Images/gitChange.png)
* **Blame** – Displays the username of the user associated with each section of code.
* **Log** – Displays all the commits, times, dates, messages, and users that are responsible for the file:</br>[ ![](Images/gitLog.png)](Images/gitLog.png) 
* **Merge** – This can be used if you have a merge conflict when committing your work. It shows a visual representation of the changes made by you and the other developer, allowing you to combine both sections of code cleanly. 

## Switching Branches 

By default, the first branch created in a repository is known as the **Master** branch. There isn't technically anything different between the master branch and any other, but the master branch is the one that is most often thought of in development teams as the 'live' or 'production' branch.

An independent line of development can be created by branching off Master (or any other branch, for that matter). This provides a new version of the master branch at a particular point in time, allowing developing independently from that is 'live.' Using branches in this way is often used for features in software development

Users can create as many branches as they like for each repository, but it is recommended that once they have finished using a branch, it is deleted it to keep the repository organized.


Branches can be viewed in Xamarin Studio by browsing to *Version Control > Manage Branches and Remotes…*:

[ ![](Images/gitBranch2.png)](Images/gitBranch2.png)

Switch to another branch by selecting it in the list and pressing the **Switch to Branch** button.

To create a new branch select the **New** button in the Git repository configuration dialog. Enter the new branch name:

[ ![](Images/gitBranch.png)](Images/gitBranch.png)

You can also set a remote branch to your _tracking_ branch. Read more about tracking branches in the [Git documentation](https://git-scm.com/book/en/v2/Git-Branching-Remote-Branches#Tracking-Branches).

See the current branch in the Solution Pad, next to the project name:

[ ![](Images/gitBranchName.png)](Images/gitBranchName.png)

## Reviewing and Committing 

To review changes in the files, you can use the Changes, Blame, Log, and Merge tabs on each document, as illustrated [above]()

Review all changes in your project, by browsing to the **Version Control > Review Solution and Commit** menu item:

[ ![](Images/gitReviewCommit.png)](Images/gitReviewCommit.png)

This allows viewing of all the changes in each file of a project with the option to Revert, Create a Patch, or Commit.

To commit a file to the remote repository, press **Commit…**, enter a commit message, and confirm with the Commit Button:

[ ![](Images/gitCommit.png)](Images/gitCommit.png)

Once you have committed your changes, push them to the remote repository to allow other users to see them.

# Working with Subversion

As mentioned earlier in this article, Subversion is the centralized version control system that enables you to check out a single master copy of the centralized data. In contrast to Git, checking out a Subversion repository does not clone the entire repository, it only takes a snapshot of that point in time.

Subversion uses a copy-modify-merge model to allow users to work on the same repository simultaneously. This means that each user creates a local, or working, copy of the centralized data, which they can then work on independently. The changes to users working copies are merged in a chronological fashion.

For example, imagine User A and User B each check out a copy from the remote repository and they each modify files. User A finishes the modifications and commits them remotely. Before User B commits their work, they will have to update their working copy with changes from the remote, thereby merging in User A's changes.

In the sections below we will explore how Subversion can be used for version control in Xamarin Studio.

## Subversion Menu

The image below illustrates the options provided by Xamarin Studio by the Version Control menu item:

[ ![](Images/svnVersionControlMenu.png)](Images/svnVersionControlMenu.png)

The sections below will explain each in more detail.

### Checkout…

Before starting to use a remote Subversion repository, you will need to check out the repo to create a local, or working, copy of that directory on your local machine.

To check out using the Checkout feature in Xamarin Studio, follow the steps in the [Setting up a Subversion repository]() section.

### Update Solution

When using a remote repository, it is important to remember that other users may be modifying files, making your working copy outdated. In anticipation of this, it is always recommended to pull any changes from the repository into your solution before starting work, and before committing. To do this, select the *Version Control > Update Solution* menu item.

### Review Solution and Commit

To review changes in files, use the Changes, Blame, Log, and Merge tabs on each document, as illustrated below:

[ ![](Images/vcTabs.png)](Images/vcTabs.png)

Review all changes in a project by browsing the **Version Control > Review Solution and Commit** menu item:

[ ![](Images/vcStatus.png)](Images/vcStatus.png)

This allows viewing all the changes in each file of a project with the option to Revert, Create Patch, or Commit.

To commit a file to the remote repository, press Commit…, enter a commit message, and confirm with the Commit Button:


[ ![](Images/svnCommit.png)](Images/svnCommit.png)

This will send the changes to the repository where they create the new revision of all your modifications.

<!--# Version control icons - relevant issue-->

#Summary

This document introduced the capabilities of VCS in Xamarin Studio. It explained how to set up Git and Subversion repositories via Xamarin Studio, and demonstrated how to use them during a typical workflow.
