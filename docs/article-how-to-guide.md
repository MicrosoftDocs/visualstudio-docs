---
title: "How To article"
description: See how to use the How To article pattern. Find out what components it contains and view examples of the pattern and its parts.
author: Jim-Parker
ms.author: jimpark
ms.date: 06/13/2024
ms.service: learn
ms.topic: contributor-guide
ms.custom: internal-contributor-guide

#customer intent: As a writer, I want to see how to create a How To article that efficiently and effectively meets customer needs and conforms to publishing criteria.
---
 
# How To

This article helps you:

> [!div class="checklist"]
>
> * Decide whether to write a How To article for a product or service.
> * Identify what content to include in a How To article.

<br />

---

## What is this pattern?

_How To_ is an article pattern that shows a user how to do a task so that they can complete the task in their own environment.

How To articles are focused on helping the user produce a job-based deliverable or achieve an outcome. When a user finishes a How To article, they've completed a task from start to finish.

How To articles are primarily procedural with steps that are organized into sections. However, sections can provide alternative or optional steps to complete the task. Unlike in a Tutorial article, the alternative or optional steps in a How To article accommodate more scenarios in which the user might not need to complete the exact steps that are described in the article to complete a task.

How To articles should:

* Be focused on a single deliverable or decision.
* Be practical and describe the same steps that a typical user would take when they do the task on the job.
* Include concise explanations of why the user takes the actions that the article describes. These explanations help inform the decisions that a user must make when they complete a task.
* Be prescriptive. Users want us to tell them the right way to use Microsoft products and services.

How To articles help the user complete a specific task, but they also give them context for understanding the solution. We want users to understand how the individual steps of the task fit together and how the task fits into the larger picture of their work.

Using a standardized pattern for this type of article has several advantages:

* **Audience**: The title format tells the audience what they'll find in this pattern.
* **Author**: The structure helps the author determine what content to include.
* **Portfolio managers**: The structure helps documentation portfolio managers measure coverage and identify content gaps.

> [!NOTE]  
> The Structured How-to is a version of the How-to pattern implementation that a YAML template and schema validation to support the pattern requirements. The development of the structured how to is in a pilot. For more information see, [How-to structured content for Learn.microsoft.com (Pilot)](../library/structured-content-feature-description.md)

<br />

---

## When to use this pattern

Use this article pattern when you want to show customers how to complete a procedural set of tasks to produce a specific deliverable.

Frameworks, such as jobs to be done or a job task analysis, can be used to determine the deliverables that users want to achieve. You can break down those deliverables into the individual steps that a user would need to complete for that deliverable. A How To article is typically appropriate for each one of these task-based deliverables.

<br />

---

### Examples of this pattern

| Example | Analysis |
| ----- | ----- |
| [Create and use append-only ledger tables](/sql/relational-databases/security/ledger/ledger-how-to-append-only-ledger-tables) | Contains prerequisites and a procedure that has specific steps. |
| [Deploy an IPv6 dual stack application with Basic Load Balancer in Azure - Template](/azure/load-balancer/basic/ipv6-configure-template-json) | Lists configuration tasks as H2 sections. |
| [Enable attack surface reduction rules](/microsoft-365/security/defender-endpoint/attack-surface-reduction-rules-deployment-implement) | Uses a diagram to introduce the task, followed by sections with procedures. |
| [How to: Create a data-driven unit test](/visualstudio/test/how-to-create-a-data-driven-unit-test) | Introduces the task with a short, numbered list and provides detailed procedures in H2 sections. |
| [Troubleshoot and diagnose workflow failures in Azure Logic Apps](/azure/logic-apps/logic-apps-diagnosing-failures) | Lists tasks to accomplish and provides a troubleshooting section. |
| [Walkthrough: Create a custom action project item with an item template, Part 1](/visualstudio/sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1) | Starts a series of articles that describes a complex task. Be sure to explain the scope of such a task upfront. |

<br />

---

## Pattern summary

Here's a summary of the elements of the How To pattern:

> [!div class="checklist"]
>
> * To promote consistency, [start from a template](#use-a-template).
> * Set the metadata [ms.topic attribute](#set-mstopic) to `how-to`.
> * Set the metadata [title attribute](#set-title). The `title` metadata attribute provides key SEO for searches.
> * Set the metadata [description attribute](#set-description). The `description` attribute value appears with the `title` attribute value in search results.
> * Include a statement of [customer intent](#write-the-customer-intent) in the metadata block.
> * Use the format "\<verb\> \* \<noun\>" to write an H1 [article headline](#write-the-article-headline) that describes the content. Don't include "How to".
> * Begin with an [introduction](#write-an-introduction) that doesn't include links or alerts. Include information that helps the user determine whether the article is relevant for them.
> * Use an optional H2 [Prerequisites](#list-prerequisites) section to list items that are needed to complete all tasks and steps in the article.
> * Describe [each major task](#describe-tasks-in-h2-sections) in a separate H2 section.
> * Keep the content concise by using [low-density text](#use-low-text-density).
> * Consider adding an optional [Clean up resources section](#clean-up-resources).
> * Consider adding a link to a next, consecutive article or a list of links to related articles in an optional [Next step or Related content](#consider-adding-a-next-step-or-related-content-section) section.

Here's an image that shows the structural elements of the pattern:

:::image type="content" border="false" source="./media/article-how-to-guide/how-to-elements.png" alt-text="Diagram that shows the elements of a How To article." :::

<br />

---

## How to use this pattern

This section describes elements of the article pattern in detail, including rationale and use cases if they're relevant.

<br />

---

### Use a template

To promote consistency, start with a template:

* For this pattern, generally use the [standard How To template](global-how-to-template.md).
* If a template for a specific product, service, or technology is available in the [repo-specific section of the documentation contributor guide](../../contribute/repo-specific-overview.md), use that template.

<br />

---

### Set the metadata

In the metadata block for a How To article, include values for the following four elements:

* `ms.topic`
* `title`
* `description`
* `#customer intent`

<br />

---

#### Set ms.topic

Set the `ms.topic` attribute value to `how-to`.

<br />

---

#### Set title

Follow the guidance that's described in [How to optimize meta titles](../../platform/seo-meta-title.md).

<br />

---

#### Set description

Follow the guidance that's described in [How to optimize meta descriptions](../../platform/seo-meta-description.md).

<br />

---

#### Write the customer intent

Write a statement of customer intent to help focus on the user's need. It also keeps the intent visible for other contributors who update the article in the future.

In the metadata block, include a customer intent as a comment by using this format:

`#customer intent: As a <type of user>, I want <what> so that <why>.`

<br />

---

### Write the article headline

The article headline (H1) is the primary heading that appears at the top of the article.

Use this guidance to write an H1 for this article pattern:

* Use the format "\<verb\> \* \<noun\>".
* Don't use "how to" in the H1.
* Don't use "tutorial" or "quickstart" in the H1.
* Use an H1 that clearly conveys what the article is about.
* Identify the technology or service involved, like App Service, and any relevant language or framework, such as JavaScript or Django.
* Don't number the H1.
* Use this same format in the TOC title if your product or service name doesn't cause the title to wrap.

Make the H1 and `title` metadata value an action statement about what the article helps the user do. These titles often start with an action verb such as _build_, _deploy_, or _configure_. Phrase article titles and headings in the user's language of what they want to do.

The H1 is one of the most important factors for SEO. Also, users tend to search for what they want to do or the outcome they're trying to achieve. For these reasons, the H1 should reflect what the user is trying to accomplish instead of leading with product or feature names.

However, product names are appropriate when they pertain to what the user wants to do. For example, a user might enter "deploy django app to Azure" in a search engine. In this scenario, it's appropriate to include Django (and Flask, another Python web framework) in the title if it:

* Helps SEO results.
* Helps the user know that they are in the right place when they select a link to go to the article.

> [!TIP]
> It's important to think about the article title and the H1 article headline _from the user's point of view_.

Here are some examples:

| Example | Analysis |
| ----- | ----- |
| [Deploy and configure Azure Firewall by using the Azure portal](/azure/firewall/tutorial-firewall-deploy-portal) | Metadata `title` attribute is _Deploy & configure Azure Firewall by using the Azure portal_. A `title` value is sometimes shorter than the H1 for readability. |
| [Migrate data from regular tables to ledger tables](/sql/relational-databases/security/ledger/ledger-how-to-migrate-data-to-ledger-tables) | Metadata `title` attribute is _Migrate data from regular tables to ledger tables - SQL Server_. Check whether your project adds the technology name (_SQL Server_, in this case) and write your titles accordingly. |
| [Use a script to add users to a hold in a eDiscovery (Standard) case](/microsoft-365/compliance/use-a-script-to-add-users-to-a-hold-in-ediscovery) | The author chose to highlight the fact that this article is about scripts, so that fact is first in the H1 and title. If possible, consider a stronger verb than _use_. |
| [View the status of Azure Import/Export jobs](/azure/import-export/storage-import-export-view-drive-status) | Metadata `title` attribute is _View status of Azure Import/Export jobs_. |

<br />

---

### Write an introduction

Start this article pattern with an introductory paragraph. The goal of the introduction is to help users quickly determine whether the article is relevant for them.

Write a light introduction that uses approachable, friendly language to define what the customer will do. Answer the fundamental question, "Why would I want to complete this how-to?"

Use this guidance:

* Place your introduction immediately after the H1.
* Don't use any alerts (Note, Important, Tip, Warning) before or in the introduction.
* Don't use an H2 for the introduction section.
* Write the introduction section in 1 to 3 paragraphs. You can go into more detail later in the article.
* Don't include a bulleted list of article sections (no inline TOC).
* Consider including artwork or videos _after_ the introduction section.

When you write the introduction, describe in approachable, friendly language what the user will be able to accomplish or do by completing this How To article. Users should have a clear idea of what they'll do in this article after they read the introduction.

Use these tips when you write your How To article introduction:

* **Be specific about what the user can accomplish by reading this How To article**. The information helps the user know before they read the entire article whether it's a resource that helps them solve a specific problem or if it instead answers a specific question.
* **Answer the fundamental question, "Why would I want to do this?"** What problem might the user have that this article helps them solve? Lead with describing the problem the user has and how the article helps them solve that problem. Don't list product features or use technical jargon.
* **It's OK to use product and feature names**. Just be sure that they're framed in the context of what problem the user has that this product or feature helps solve.
* **If an article applies only to certain versions of software, tell the user upfront**. It can be as important to tell the user who the article _isn't for_ as who it is for. Nothing is more frustrating than getting most the way through an article to find out it will not work for your circumstances. For example, if an Azure service supports only certain versions of Node.js, use a paragraph in the introduction to explain that information. Be upfront with the user about who and what this article is for.
* **Introduction sections should be from 1 to 3 paragraphs**. Don't include nonpertinent conceptual details in the introduction section of a How To article. Focus on the objective, and make sure that each word counts. You can link to an Overview article that has context and other important conceptual details.

Here are some examples:

| Example | Analysis |
| ----- | ----- |
| [Migration guide: IBM Db2 to SQL Server](/sql/sql-server/migrate/guides/db2-to-sql-server) | A short paragraph explains the goal of the article. |
| [Create and use append-only ledger tables](/sql/relational-databases/security/ledger/ledger-how-to-append-only-ledger-tables) | The introduction explains the steps that are described in the article. |
| [Run Python and R scripts in Azure Data Studio notebooks with SQL Server Machine Learning Services](/sql/machine-learning/install/sql-machine-learning-azure-data-studio) | Short paragraph explains the goal of the article. |
| [View the status of Azure Import/Export jobs](/azure/import-export/storage-import-export-view-drive-status) | A short paragraph explains the goal of the article. |
| [Deploy an IPv6 dual-stack application with Basic Load Balancer in Azure - Template](/azure/load-balancer/basic/ipv6-configure-template-json) | A short paragraph explains the templates that the article uses. The second paragraph directs the user to a different technology. |
| [Set up a Git repository](/visualstudio/mac/set-up-git-repository) | Three paragraphs explain the goal of the article and the technology that's used. The introduction mentions the product, Visual Studio for Mac. |

<br />

---

### List prerequisites

In this article pattern, a **Prerequisites** section is optional. Clearly identifying any required prerequisites lets users know what they need to do before they start.

* If you include prerequisites, make **Prerequisites** the first H2 in the article.
* If there aren't any prerequisites for the task, don't include a **Prerequisites** unit.

Use this guidance:

**Standardize language**

* List any items that are needed to complete the task, such as permissions or tools/software.
* Don't include a preliminary or introductory text block before the list.
* Replace imperative phrases like “you must” with more neutral language, like “ensure,” “verify,” or “have”.

**Use clear and consistent language**. Follow the pattern of clear and concise prerequisites, **using least privilege required:**
* Unclear: “Install the latest version of the software.”
* Clear: “Have version 3.0.1 or later installed. You can download it from our official website.”
* Wrong: “Have Basic access or greater.”
* Right: “Have at least Basic access.” (Bold the access level, replace “Have Basic access or higher/or greater”)

**Ensure prerequisites highlight permissions, access levels, and any other security-related requirements.**

**Include links to installers and downloadable files** that the user needs to complete the steps in the article. If the prerequisite is something to install, link to the specific, applicable installer or download.

**Follow these suggestions**

* To keep the list brief and easy to scan, list each prerequisite as an _item_, and not as instructions. For example, use "Python 3.6" instead of "Install Python 3.6." Include an action word only if it's necessary to make the meaning clear.
* If there aren't any prerequisites, for this pattern, don't include a **Prerequisites** section.

For applicable prerequisites, you should typically list them in this order:

1. Completion of a previous article if the current one depends or builds on it. Use the language "Completion of \<title\>," where \<title\> is the link to the prerequisite article.
1. Language runtimes, like Python, Node.js, or .NET.
1. Packages, like from pip, npm, or NuGet.
1. Tools, like Visual Studio Code, *if they're required*. Don't include tools if they're automatically installed with another tool or language runtime. For example, pip is installed with Python. Don't include optional tools like text editors. Include tools only if the procedure uses them.
1. Sample code.
1. Specialized hardware.
1. Other preparatory work, like creating a virtual machine. (It's OK to link to another article that describes how to accomplish this prerequisite.)
1. Service keys.

<br />

---

### Describe tasks in H2 sections

A section contains a major grouping of steps that help users complete a task. Each section is represented as an H2 in the article.

Use this guidance:

* At least one task H2 should exist in the article. The task should have two or more procedural steps.
* Use the format "\<verb\> \* \<noun\>" for the H2.
* Don't start the H2 heading with a gerund.
* Follow each H2 with a paragraph of fewer than 200 words that sets expectations for the content in that section.
* Provide a numbered list of procedural steps.
* Insert a screenshot, code block, or other graphical element, if appropriate, after the numbered step that it illustrates. Placing the graphical element after the numbered step supports accessibility.
* For this pattern, don't number H2s.

Organizing content into task H2 sections helps the user visualize the overall process of building the solution. Also, H2s automatically appear in the _In this article_ navigation menu and make it easy for users to jump to a specific section.

If necessary, you can add optional or alternative groups of steps to a section. Here's an example of H3 sections that describe two options to complete the H2 task:

:::image type="content" source="media/article-how-to-guide/how-to-options-h3s.png" alt-text="Screenshot that shows H3 sections that describe two options to complete the H2 task.":::

Here are some example articles:

| Example | Analysis |
| ----- | ----- |
| [Set up a Git repository](/visualstudio/mac/set-up-git-repository) | Two H2 sections each contain short procedures. |
| [Use a script to add users to a hold in eDiscovery](/microsoft-365/compliance/use-a-script-to-add-users-to-a-hold-in-ediscovery) | Three sections describe parts of the task.   |
| [Migrate data from regular tables to ledger tables](/sql/relational-databases/security/ledger/ledger-how-to-migrate-data-to-ledger-tables) | Two H2 sections describe the task. |
| [View the status of Azure Import/Export jobs](/azure/import-export/storage-import-export-view-drive-status) | The first H2 section describes how to view the status. The next sections drill down into the types of descriptions.
| [Use packet capture for proactive network monitoring with alerts and Azure Functions](/azure/network-watcher/network-watcher-alert-triggered-packet-capture) | An H2 section describes the scenario that's used for the article. The next three sections describe creating a function, configuring an alert, and viewing results. |

<br />

---

### Consider adding images

You can use representational screenshots that are associated with the procedure when the interface is complex. Add cueing graphics, like a red border, to draw the eye to critical parts of a complex image or to what is described in preceding text.

Here's an example of screenshots that are used to demonstrate steps in a procedure in a How To article:

:::image type="content" source="media/article-how-to-guide/how-to-images.png" alt-text="Screenshot that shows screenshots that are used to demonstrate the procedure in a How To article.":::

If a procedure is complex and comprised of subtasks, it might be useful to include a diagram of the solution that's being built in the How To article. A diagram helps the user create a mental picture of the solution that they can refer back to when they work through the article. If a diagram is appropriate, include it between the first and second paragraphs in the article.

<br />

---

### Use low text density

Strive for low text density when you write all articles, but especially in How To articles. Each step in a How To article should contain at most one or two paragraphs that have two or three lines each of explanation. Follow this explanation with a code block, screenshot, or another graphical element to demonstrate what the user needs to do.

Explanations should inform the user why they're completing the step. The explanations should connect the step to the overall task that they want to accomplish, and not simply restate what is already shown in the code block or screenshot.

Here's an example of low text density in a How To article:

:::image type="content" source="media/article-how-to-guide/how-to-low-text-density.png" alt-text="Screenshot that demonstrates low text density in a How To article.":::

Here are some example articles:

| Example | Analysis |
| ----- | ----- |
| [Set up a Git repository](/visualstudio/mac/set-up-git-repository) | The steps in the procedure are approximately one line each. Screenshots show the steps that are described. |
| [Create and use append-only ledger tables](/sql/relational-databases/security/ledger/ledger-how-to-append-only-ledger-tables) | Uses short procedure steps that begin with verbs. Each step introduces a code block. |

<br />

---

### Clean up resources

If you're creating a standalone article that isn't part of a series, consider including guidance on how to clean up or delete resources that the user creates to complete the tasks and steps in the article.

* Create a **Clean up resources** H2.

* In a paragraph, use text like this example:

   ```md
   If you no longer need them, delete the resource group, virtual machine, and all related resources. To do so, select the resource group for the VM and select **Delete**.
   ```

* Immediately follow the **Clean up resources** H2 section with the **Next step** or **Related content** H2 section.

Here are some examples:

* [Tutorial: Configure replication between two managed instances](/azure/azure-sql/managed-instance/replication-between-two-instances-configure-tutorial)
* [Tutorial: Use .NET and AI to generate searchable content from Azure blobs](/azure/search/cognitive-search-tutorial-blob-dotnet)

<br />

---

### Consider adding a Next step or Related content section

You have two options for manually curated links in this pattern:

* **Next step**
* **Related content**

You're not required to use either section, but don't use both.

In Microsoft documentation, the connected experience right rail automatically provides links to related resources in our documentation. To keep links from becoming overwhelming or redundant, be judicious in adding manually curated links.

> [!TIP]
> * These sections are _not required_.
> * Don't use **Next step** and **Related content** in the same article.

[!INCLUDE [manually curated links](../includes/manually-curated-links.md)]