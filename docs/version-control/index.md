---
title: Version control in Visual Studio | VSTS & TFS
description: Guide to getting started with version control in Viual Studio 
keywords: VSTS, TFS, Version Control
author: steved0x
ms.manager: douge
ms.author: sdanie
ms.date: 09/07/2017
ms.topic: article
ms.prod: .net-core
ms.assetid: 2c119a5f-0272-48c0-8d6c-806196944aea
---

# Version Control in Visual Studio

Version control systems are software that help you track changes you make in your code over time. As you edit to your code, you tell the version control system to take a snapshot of your files. The version control system saves that snapshot permanently so you can recall it later if you need it.

Without version control, you’re tempted to keep multiple copies of code on your computer. This is dangerous-it’s easy to change or delete a file in the wrong copy of code, potentially losing work. Version control systems solve this problem by managing all versions of your code but presenting you with a single version at a time.

Visual Studio Team Services and TFS provide two models of version control: [Git](/vsts/git/index), which is distributed version control, and [Team Foundation Version Control (TFVC)](/vsts/tfvc/index), which is centralized version control. This article provides an overview and a starting point for using Team Foundation Version Control. If you're deciding which type of Team Services/TFS version control to use, see [Choosing the right version control for your project](/vsts/tfvc/comparison-git-tfvc).

* [Git](#git)
* [Team Foundation Version Control (TFVC)](#TFVC)

## Git
Git is the most commonly used version control system today and is quickly becoming the standard for version control. Git is a distributed version control system, meaning your local copy of code is a complete version control repository. These fully-functional local repositories make it is easy to work offline or remotely. You commit your work locally, and then sync your copy of the repository with the copy on the server. This paradigm differs from centralized version control where clients must synchronize code with a server before creating new versions of code.

Git’s flexibility and popularity make it a great choice for any team. Many developers and college graduates already know how to use Git. Git’s user community has created many resources to train developers and Git’s popularity make it easy to get help when you need it.  Nearly every development environment has Git support and Git command line tools run on every major operating system.

### Git 5-Minute Quickstarts 

Get started by creating a repo, uploading your code, and inviting developers to work in the repo. You can use any one of these clients or IDEs: 

<table>
<tr valign="middle" align="center">
<td>![Web](media/web.png)<br/>[Web](/vsts/git/create-new-repo)</td>
<td>![VS](media/vs-ide.png)<br/>[Visual Studio](/vsts/git/share-your-code-in-git-vs)</td>
</tr>
</table>    


Or, you can [import an existing repo](/vsts/git/import-git-repository) from GitHub, BitBucket, GitLab, or other location to a new, empty repo. 

### Git Step-by-Step Tutorials  

Learn the basics of working in Git with these tutorials which show tasks performed using Visual Studio.

- [Create a new repo](/vsts/git/tutorial/creatingrepo)  
- [Clone an existing repo](/vsts/git/tutorial/clone)  
- [Save work with commits](/vsts/git/tutorial/commits)  
- [Create work in branches](/vsts/git/tutorial/branches)  
- [Share code with push](/vsts/git/tutorial/pushing)  
- [Update code with fetch and pull](/vsts/git/tutorial/pulling)  
- [Review code with pull requests](/vsts/git/tutorial/pullrequest)  
- [Apply changes with rebase](/vsts/git/tutorial/rebase)  
- [Copy changes with cherry-pick](/vsts/git/tutorial/cherry-pick)  
- [Resolve merge conflicts](/vsts/git/tutorial/merging)  
- [Undo changes](/vsts/git/tutorial/undo)  
- [Ignore files](/vsts/git/tutorial/ignore-files)  
- [Review history](/vsts/git/tutorial/history)  


### Git Videos 
 
[![Git at scale video](media/git-at-scale-video-img.png)](https://channel9.msdn.com/Events/Build/20-7/P4-0-/player)  

[![Creating a repo video](media/create-a-git-repo-video-img.png)](https://channel9.msdn.com/series/Team-Services-Git-Tutorial/Git-Tutorial-Create-a-Git-repo-in-Visual-Studio-20-5/player)



### Git Resources 

- [What is Git?](https://www.visualstudio.com/learn/what-is-git/)  
- [What is version control?](https://www.visualstudio.com/learn/what-is-version-control/)  
- [Plan your migration to Git](https://www.visualstudio.com/learn/centralized-to-git/)  
- [Migrate from TFVC to Git](https://www.visualstudio.com/learn/migrate-from-tfvc-to-git/)  
- [Git at Scale](https://www.visualstudio.com/learn/git-at-scale/)   
- [Marketplace extensions](https://marketplace.visualstudio.com/search?target=VSTS&category=Code&sortBy=Downloads)


## TFVC

Team Foundation Version Control (TFVC) is a centralized version control system. Typically, team members have only one version of each file on their dev machines. Historical data is maintained only on the server. Branches are path-based and created on the server.

### TFVC 5-Minute Quickstarts 

Get started by creating a team project, configuring your workspace, and reviewing and sharing your code.

<table>
<tr valign="middle" align="center">
<td>![VS](_img/index/vs-ide.png)<br/>[Visual Studio](/vsts/tfvc/share-your-code-in-tfvc-vs)</td>
</tr>
</table>    

### TFVC Step-by-Step Tutorials  

Learn the basics of working in TFVC with the following tutorial which shows a day in the life of a devops developer using Visual Studio and TFVC.

* [Day in the life of a devops developer: suspend work, fix a bug, and conduct a code review](/vsts/tfvc/day-life-alm-developer-suspend-work-fix-bug-conduct-code-review)
* [Visual Studio: Review Code](/vsts/tfvc/get-code-reviewed-vs)


### TFVC Resources 

- [What is version control?](https://www.visualstudio.com/learn/what-is-version-control/)  
- [Migrate from TFVC to Git](https://www.visualstudio.com/learn/migrate-from-tfvc-to-git/)  

