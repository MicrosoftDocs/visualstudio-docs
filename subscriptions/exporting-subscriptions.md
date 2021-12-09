---
title: Export subscription information in Visual Studio subscriptions| Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: 14e4cffb-a695-436c-b269-7820f7411f4e
ms.date: 08/31/2021
ms.topic: conceptual
description:  Learn how to export a list of subscribers and details of their subscription assignments.
---

# Export subscription information
In the Visual Studio Subscriptions [Administration Portal](https://manage.visualstudio.com), you can export a list of your subscribers and details about their assignments. This information includes their name, email address, alternate email address, subscription level, assigned date, activation status, expiration date, reference field, whether downloads are enabled, country, language, subscription status, and subscription GUID.  The list is exported as a CSV file, which can easily be opened in Microsoft Excel for the creation of charts, pivots, and other artifacts.

Having all your subscriber information in one place can help you do things like:
- Get an overall view of which subscriptions are in use by team and/or location across your organization.
- Develop plans and budgets for future subscription purchases. 
- Encourage users who have subscriptions assigned to activate.
- Take proactive action before subscriptions expire.  
- Identify where subscriptions may be over-allocated. 
- Assign subscriptions using the subscription ID to control which expiration date your subscribers have on their subscriptions. 

## Export your subscriptions
To perform the export:
1. Sign in to the [Administration Portal](https://manage.visualstudio.com).
2. Select the **Export** tab. The file will download to your local machine. The file will include the name of the agreement that contains your user subscriptions, and the date of the export.
> [!div class="mx-imgBorder"]
> ![Export subscribers](_img/exporting-subscriptions/exporting-subscriptions.png "Click Export to download a complete list of your assigned subscriptions.")
3. The exported list will appear as a .csv file in your normal downloads location. The file name will include the agreement number and the date you exported the list.  

## Resources
- [Subscriptions Support](https://aka.ms/vsadminhelp)

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
- For more information about managing subscriptions, see these helpful topics:
    - [Expired subscriptions](handle-expired-license.md)
    - [Overallocations](handle-overclaimed-license.md)
    - [Maximum usage](maximum-usage.md)
