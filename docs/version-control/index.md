---
layout: LandingPage
title: Version control
description: Guide to getting started with version control in Visual Studio
keywords: VSTS, TFS, Version Control
author: steved0x
ms.manager: jillfra
ms.author: sdanie
ms.date: 12/15/2017
ms.topic: landing-page
ms.prod: .net-core
ms.assetid: 2c119a5f-0272-48c0-8d6c-806196944aea
ms.workload:
  - "multiple"
---
# Version Control in Visual Studio

Version control systems help you track changes to code over time. As you make changes, the version control system takes a snapshot of your files. The version control system saves that snapshot permanently so you can recall it later if you need it. Visual Studio provides [Git](/azure/devops/repos/git/index?view=vsts) and [Team Foundation Version Control (TFVC)](/azure/devops/repos/tfvc/index?view=vsts). To decide between the two systems, see [Choosing the right version control for your project](/azure/devops/repos/tfvc/comparison-git-tfvc?toc=/visualstudio/version-control/toc.json&bc=/azure/devops/repos/git/breadcrumb/vc/toc.json).

## Git

Git is the most commonly used version control system today and is quickly becoming the standard for version control. Git is a distributed version control system, meaning your local copy of code is a complete version control repository. These fully functional local repositories make it is easy to work offline or remotely. You commit your work locally, and then sync your copy of the repository with the copy on the server. This paradigm differs from centralized version control where clients must synchronize code with a server before creating new versions of code.

<!-- markdownlint-disable MD033 -->
<ul class="panelContent cardsFTitle">
    <li>
        <a href="/azure/devops/git/what-is-git">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img width="48" height="48" alt="" src="https://docs.microsoft.com/media/common/i_git-mark.svg" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Learn Git</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="/azure/devops/repos/git/share-your-code-in-git-vs-2017">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img width="48" height="48" alt="" src="https://docs.microsoft.com/media/common/i_git-mark.svg" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Get started with Git in Visual Studio</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="/azure/devops/repos/git/clone">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img width="48" height="48" alt="" src="https://docs.microsoft.com/media/common/i_git-mark.svg" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Clone an existing Git repo</h3>
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
        <a href="/azure/devops/repos/tfvc/overview">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img width="48" height="48" alt="" src="https://docs.microsoft.com/media/logos/logo_visual-studio.svg" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Learn TFVC</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
    <li>
        <a href="/azure/devops/repos/tfvc/share-your-code-in-tfvc-vs">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img width="48" height="48" alt="" src="https://docs.microsoft.com/media/logos/logo_visual-studio.svg" />
                        </div>
                    </div>
                    <div class="cardText">
                        <h3>Get started with TFVC in Visual Studio</h3>
                    </div>
                </div>
            </div>
        </div>
        </a>
    </li>
   <li>
        <a href="/azure/devops/repos/tfvc/get-code-reviewed-vs">
        <div class="cardSize">
            <div class="cardPadding">
                <div class="card">
                    <div class="cardImageOuter">
                        <div class="cardImage">
                            <img width="48" height="48" alt="" src="https://docs.microsoft.com/media/logos/logo_visual-studio.svg" />
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

- [Pro Git book](https://git-scm.com/book/en/v2)
- [Plan your migration to Git](https://docs.microsoft.com/azure/devops/git/centralized-to-git)
- [Migrate from TFVC to Git](https://docs.microsoft.com/azure/devops/git/migrate-from-tfvc-to-git)
- [Version control (Visual Studio for Mac)](/visualstudio/mac/version-control)