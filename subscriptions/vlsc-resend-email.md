---
title: Visual Studio Subscriptions - Resend Assignment Emails from VLSC 
Author: evanwindom
Ms.author: jaunger
Manager: evelynp
Ms.date: 1/23/2018
Ms.topic: Get-Started-Article
Description:  Learn how to resend subscription assignment emails from within VLSC
Ms.prod: vs-subscription
Ms.technology: vs-subscriptions
Searchscope: VS Subscription
---

# How to Resend Subscription Assignment Emails from within Volume License Service Center (VLSC)

Occasionally, a subscriber to whom a subscription has been assigned will ask an administrator to resend their subscription assignment notification email.  In the new subscription management portal, https://manage.visualstudio.com, this is a simple process.  However, if your organization is still using the Volume License Service Center (VLSC), there is no feature to automatically resend the notification email.  

To resend the assignment notification email from within VLSC, an administrator needs to use the following workaround:

## Resending the assignment email:

In order for VLSC to generate a new notification, it is necessary to edit the subscriber’s email information once and then change it back to the original email on the same transaction. This will cause VLSC to react as if a new subscription has been assigned, and send the Assignment Email again.

1.  Visit the [Volume Licensing Service Center (VLSC)](https://www.microsoft.com/Licensing/servicecenter/default.aspx) and sign-in.
2.  Click the **Subscriptions** tab and choose **Visual Studio Subscriptions**.
3.  Click the **Agreement Number** associated with the Visual Studio subscription.
4.  Click the down arrow on the Search bar. 
5.  Search for the Subscriber using the **Email Address** field.
6.  Locate the subscriber in the search results, and click on the last name. 
7.  Click **Edit**.
8.  Make an edit to the subscription. For example, remove a character from the subscriber’s email address. Click the **Save** button.
9.  Once the information is saved, click **Edit** again, reverse the change you just made, and click **Save**.  

This will cause the subscription to be treated as a new assignment, and will resend the assignment notification email to the subscriber.  