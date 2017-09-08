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

Version control systems are software that help you track changes you make in your code over time. As you edit your code, you tell the version control system to take a snapshot of your files. The version control system saves that snapshot permanently so you can recall it later if you need it.

Visual Studio provides two models of version control: [Git](/vsts/git/index), which is distributed version control, and [Team Foundation Version Control (TFVC)](/vsts/tfvc/index), which is centralized version control. If you're deciding which type of VSTS/TFS version control to use, see [Choosing the right version control for your project](/vsts/tfvc/comparison-git-tfvc).

## Git
Git is the most commonly used version control system today and is quickly becoming the standard for version control. Git is a distributed version control system, meaning your local copy of code is a complete version control repository. These fully-functional local repositories make it is easy to work offline or remotely. You commit your work locally, and then sync your copy of the repository with the copy on the server. This paradigm differs from centralized version control where clients must synchronize code with a server before creating new versions of code.

Git’s flexibility and popularity make it a great choice for any team. Many developers and college graduates already know how to use Git. Git’s user community has created many resources to train developers and Git’s popularity make it easy to get help when you need it.  Nearly every development environment has Git support and Git command line tools run on every major operating system.

Learn the basics of working in Git with these guides.

<ul class="panelContent cardsFTitle">
    <li>
        <a href="/vsts/git/create-new-repo">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="media/web.png" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Create a Git repo using the VSTS web portal</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="/vsts/git/share-your-code-in-git-vs">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="media/vs-ide.png" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Manage your code using Git with Visual Studio</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/import-git-repository">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Import a repo from GitHub, BitBucket, GitLab and others into a blank VSTS Git repo</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/creatingrepo">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Create a new repo</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/clone">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Clone an existing repo</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/commits">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Save work with commits</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/branches">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Create work in branches</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/pushing">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Share code with push</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/pulling">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Update code with fetch and pull</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/pullrequest">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Review code with pull requests</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/rebase">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Apply changes with rebase</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/cherry-pick">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Copy changes with cherry-pick</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/merging">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Resolve merge conflicts</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/undo">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Undo changes</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/ignore-files">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Ignore files</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/git/tutorial/history">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="/media/common/i_git-mark.svg" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Review history</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
</ul>

## TFVC

Team Foundation Version Control (TFVC) is a centralized version control system. Typically, team members have only one version of each file on their dev machines. Historical data is maintained only on the server. Branches are path-based and created on the server.

<ul class="panelContent cardsFTitle">
    <li>
        <a href="/vsts/tfvc/share-your-code-in-tfvc-vs">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="media/vs-ide.png" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Manage your code using TFVC with Visual Studio</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="/vsts/tfvc/day-life-alm-developer-suspend-work-fix-bug-conduct-code-review">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="media/vs-ide.png" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Day in the life of a devops developer: suspend work, fix a bug, and conduct a code review</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/vsts/tfvc/get-code-reviewed-vs">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img src="media/vs-ide.png" alt="" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Review your code</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
</ul>


## Resources 

- [What is Git?](https://www.visualstudio.com/learn/what-is-git/)  
- [What is version control?](https://www.visualstudio.com/learn/what-is-version-control/)  
- [Plan your migration to Git](https://www.visualstudio.com/learn/centralized-to-git/)  
- [Migrate from TFVC to Git](https://www.visualstudio.com/learn/migrate-from-tfvc-to-git/)  
- [Git at Scale](https://www.visualstudio.com/learn/git-at-scale/)   
- [Marketplace extensions](https://marketplace.visualstudio.com/search?target=VSTS&category=Code&sortBy=Downloads)
 

