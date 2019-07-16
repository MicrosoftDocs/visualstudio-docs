---
title: Administrator Responsibilities | Visual Studio Marketplace
author: evanwindom
ms.author: jaunger
manager: evelynp
ms.date: 03/13/2018
ms.topic: conceptual
description:  Learn about responsibilities of subscriptions administrators.
---
# Overview of administrator responsibilities
As an administrator, you have the ability to manage subscriptions for your organization.  The administrator role also carries responsibilities to ensure that the subscriptions are managed in accordance with the license terms. This article outlines the responsibilities, benefits, and limitations of the administrator role.

## Roles & responsibilities
A Visual Studio administrator has four key responsibilities:

1. **Understand the benefits and restrictions of Visual Studio subscriptions.** Correctly understanding your benefits can enable you to reduce hardware costs by using cloud services, and reduce software costs with per-user licenses for pre-production environments. 
2. **Assign Visual Studio subscriptions to specific, named individuals and encourage usage.** Your contract requires that Visual Studio subscriptions be assigned to specific, named individuals. Follow up with your assigned individuals to ensure they access and take full advantage of the benefits included in their Visual Studio subscription.
3. **Accurately inventory your pre-production environment.** This is essential to ensure all users who interact with Visual Studio-licensed software are appropriately licensed with their own Visual Studio subscription. 
4. **Track user assignment changes and acquire additional licenses on schedule.** Microsoft Volume Licensing (VL) Agreements and MPSA give you flexibility in how you use and assign Visual Studio subscriptions. In return, you are expected to track changes to software usage and user assignments and process orders for additional licenses on the schedule outlined in the agreement.

## Benefits and limitations
Visual Studio subscriptions allow development team members to install and use software to design, develop, test, evaluate, and demonstrate other software. Visual Studio Subscriptions software is not licensed for production environments.

|                                          |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
|------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| User-based licensing                     | MSDN Platforms and all levels of Visual Studio subscriptions are licensed on a per-user basis. Each development team member that will interact (install, configure, or access) with the software included with these products and services requires their own Visual Studio subscription.                                                                                                                                                                                                                                                                                                                                  |
| Unlimited installations                  | Each licensed user may install and use the software on any number of devices to design, develop, test, evaluate, and demonstrate software. The exception is Microsoft Office, which is licensed for one desktop. Visual Studio-licensed software can be installed and used at work, home, school, and on devices at a customer’s office or on dedicated hardware hosted by a third party.                                                                                                                                                                                                                                  |
| Not intended for production environments | Visual Studio subscriptions software is not licensed for production environments, including any environment accessed by end users for more than acceptance testing or feedback, an environment connecting to a production database, supporting disaster recovery or production backup, or used for production during peak periods of activity. Exceptions to this include specific benefits for certain subscription levels, outlined in the [Visual Studio Licensing White Paper](https://aka.ms/vslicensing).                                                                                            |
| License reassignment                     | When a user leaves a team and no longer requires a license, you may reassign the license after 90 days have passed. When you reassign a license, any product keys that were already used will still be available but will not be replaced. For organizations that have Enterprise Agreements (EA), any benefits that were used by the original user, such as Pluralsight training, will be reset.                                                                                                                                                                                                                                                 |
| Exception for end users                  | At the end of a software development project, end users typically review an application and determine whether it meets the necessary criteria for release. This process is called user acceptance testing (UAT). Team members such as a business sponsor or a product manager can act as proxies for end users. End users who do not have a Visual Studio subscription may access the software for UAT if use of the software otherwise complies with all Visual Studio licensing terms. It is rare that someone whose primary role is designing, developing,or testing the software would also qualify as an “end user”. |

## Inventory of pre-production environment
Visual Studio subscriptions simplify asset management by counting users rather than devices.

Visual Studio administrators must assign Visual Studio Subscriptions to **specific, named individuals**. Naming conventions such as Dev1, Dev2, or Dev3 are **not allowed**.

Here are some ways to simplify taking inventory of your pre-production environment:
- Review your user assignments. Microsoft provides a website called the [Visual Studio Administration Portal](https://manage.visualstudio.com/) to help you track Visual Studio subscription assignments.
- Use your on-premise or cloud-based Active Directory to list users. If you use Active Directory to manage user access, you may be able to identify development and test users by their directory membership.
- Use automated tools to inventory systems. You may also need to use a software inventory tool to help manage your software assets and distinguish pre-production environments from production ones. Many customers with Microsoft System Center create naming conventions to help automate this part of the inventory process.
- Get help with manual reconciliation. Enlist your staff to help reconcile your development and test users with your development and test environment.

## Large teams and external contractors
Visual Studio subscriptions administrators are responsible for ensuring that each user who interacts with Visual Studio-licensed software is appropriately licensed with their own Visual Studio subscription.

### Internal teams
Typically, modern software organizations include stakeholders from several groups. Identify contacts from each group who can help you keep track of user inventory and changes.
Every organization is different, but a typical list of teams involved in development might include:
- Software engineering teams.
- Business teams, including product owners and business analysts.
- Project management teams.
- Quality teams, including QA staff and manual testers.
- IT operations, including pre-production and lab infrastructure managers.

### External contractors and partners
External contractors may bring licenses to engage with your Visual Studio-licensed environment. Microsoft Certified Partners may receive a few free Visual Studio subscriptions for their internal use. However, these subscriptions do not cover revenue-generating activities such as developing custom software for a customer. Ask partners to send you a certified letter that explains the licenses they are providing and ones they need you to procure.

## Track user assignment and process orders
Visual Studio subscriptions administrators are expected to track Visual Studio usage and process orders for any increases in usage on the schedule outlined in their Volume Licensing agreement or Microsoft Products and Services Agreement. The new Visual Studio Subscriptions Administration portal has made this simple with a helpful tracker showing your available and used licenses.

### High water mark of usage
**Your company's obligation to purchase Visual Studio subscriptions takes effect immediately when:**
- A license is assigned to a user.
- A user interacts with Visual Studio software.

Your complete purchase obligation is determined by the **high watermark of usage**. This watermark is
the high point either in daily user assignments or in users interacting with Visual Studio software, whichever is higher.

1. Visual Studio subscriptions administrators may increase the high watermark of usage by assigning Visual Studio Subscriptions to individuals.
2. Visual Studio subscriptions administrators may reassign subscriptions from one subscriber to another if 90 days have passed since the time of the original assignment. To avoid an artificially high watermark, always do this by first removing the existing subscription and then adding the new one.
3. Visual Studio subscriptions administrators may change the assigned subscription level for an individual, which would constitute a decrease in one assignment and an increase in another. When you lower a subscriber’s assigned subscription level, the individual must immediately stop using and uninstall anything that is only in the higher-level subscription. 

### Cloud Subscriptions, Open License or Open Value
You may be assigning subscriptions through a program like Microsoft Cloud subscriptions, Open License or Open Value. If so, then you must process your order for additional users during the month in which users (employees or external contractors) begin interacting with Visual Studio-licensed software.

### Enterprise, MPSA and Select Agreements
Microsoft Enterprise Agreements (EA), MPSA and Select Plus Agreements give you flexibility in how you use and license Visual Studio software over time. Visual Studio administrators must make an annual True-Up order to bring their software licenses up to the high watermark of usage established during the agreement period.
