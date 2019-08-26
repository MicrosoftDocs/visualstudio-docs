---
title: Visual Studio cloud subscription purchasing for CSPs
author: evanwindom
ms.author: lank
manager: lank
ms.date: 07/28/2019
ms.topic: conceptual
description:  Information for Cloud Solution Providers on how to buy and manage Visual Studio cloud subscriptions for your customers.
---
# Buy and manage Visual Studio cloud subscriptions for your customers
Partners in the [Cloud Solution Provider (CSP)](https://partner.microsoft.com/cloud-solution-provider) program can purchase
Visual Studio Enterprise and Visual Studio Professional cloud subscriptions for their customers.

[Compare cloud subscription options](https://visualstudio.microsoft.com/vs/pricing)

> [!NOTE]
> Microsoft no longer offers Visual Studio Professional Annual subscriptions and Visual Studio Enterprise Annual subscriptions in Cloud Subscriptions. There will be no change to existing customers experience and ability to renew, increase, decrease, or cancel their subscriptions. New customers are encouraged to go to [https://visualstudio.microsoft.com/vs/pricing/](https://visualstudio.microsoft.com/vs/pricing/) to explore different options to purchase Visual Studio.

## Prerequisites
You must first set up your customer tenant in the Partner Center and create an Azure subscription for this tenant.

[Learn more](/azure/devops/organizations/billing/csp/set-up-csp-customer)

## Who can buy Visual Studio subscriptions?
Anyone with [owner or contributor access](https://na01.safelinks.protection.outlook.com/?url=https%3A%2F%2Fdocs.microsoft.com%2Fen-us%2Fvsts%2Forganizations%2Fbilling%2Fadd-backup-billing-managers%3Fview%3Dvsts%2520%2520sa&data=02%7C01%7C%7Cb9e717e8abff47b0cd7e08d618edd860%7C72f988bf86f141af91ab2d7cd011db47%7C1%7C0%7C636723807145220358&sdata=aIaamEXHhx94KCYVY%2FFibqFzNBEqKPntpql867xAMgU%3D&reserved=0) to the Azure subscription can purchase Visual Studio subscriptions.

## How to buy

1. Log into the [Microsoft Partner Center](https://partnercenter.microsoft.com).
0. Choose **Customers** and select a customer to buy for.
0. Choose **Service Management**.
0. Choose **Visual Studio Marketplace**.
0. Make sure you're customer's name is in the upper right corner.
0. Choose **Subscriptions**.
0. Choose Enterprise or Professional for Visual Studio.
0. Choose **Buy**.
0. Choose the Azure subscription to bill for the purchase.
0. Enter the number of users your customer needs.
0. Review the order and **Confirm** it.

>[!NOTE]
> You will need to follow these steps every time you purchase Visual Studio subscriptions as a CSP. At this time, there is no API
> for automation of purchasing.

Once you confirm the purchase, you can choose **Manage** to assign subscriptions to your customer's end users.  You can
also access the Subscription Administration portal from the Partner Center by choosing **Service management**.  From there see the steps or video below.

## How to manage Visual Studio cloud subscriptions for your customer

1. Log in to the [Microsoft Partner Center](https://partnercenter.microsoft.com).
0. Choose **Customers** and the customer's name.
0. Choose **Service Management**.
0. Choose **Manage Visual Studio Subscriptions**.

If you have more than one Azure subscription for this customer, use the drop-down menu to choose the Azure subscription through which you made the purchases.  The **License Summary** shows you the number of subscriptions that have been assigned and how many are available for each Visual Studio cloud subscription option.  The summary also allows you to purchase additional subscriptions or reduce the number of subscriptions.

Choose **add** to assign a subscription to a new user.  The displayed count updates, and the end user receives an email notification. The end user can then sign in using the email address you provided to activate their Visual Studio subscription in the [Visual Studio subscriber portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs).

To reassign a Visual Studio subscription to a different user, you can delete the current subscriber and add a new subscriber.

If a subscriber hasn't activated their Visual Studio subscription, it may be because they missed the invitation email.  You can request that we resend the activation invitation to the user from within the Visual Studio admin portal too.

## View Visual Studio pricing for CSP partners
To view Visual Studio pricing for CSP partners, log into the [Partner Center](https://partnercenter.microsoft.com).  Choose **Pricing and offers** from the left nav.  Choose the current month pricing file under **usage-based services** in the upper right. Once the Excel spreadsheet downloads, go to the **Azure Price List** sheet, and filter the **Meter Category** column to **Visual Studio**.

Here's how to interpret what you see on this spreadsheet:

| Meter category    |   Name                 |  Units                                |           What this is                          |
|-------------------|------------------------|---------------------------------------|-------------------------------------------------|
| Visual Studio     | Enterprise             |  Subscription                         | Visual Studio Enterprise monthly subscription   |
| Visual Studio     | Professional           |  Subscription                         | Visual Studio Professional monthly subscription |

We offer a 5% discount on the 6th unit you buy (for a given customer) each month of each Visual Studio subscription. That's why you see two rows for each subscription option. One row shows a "Minimum Value" of 0, which you should interpret as the base price for units 1 through 5. The other row shows a "Minimum Value" of 5, so this is the 5% discount price that applies to units 6 and above.

## Frequently asked questions
### Q: How are **monthly** cloud subscription charges processed?
A: At the first purchase, we bill a prorated quantity to cover the remaining days in the current month. For instance, if a purchase of 10 Visual Studio Professional monthly cloud subscriptions was made on April 15, then we would charge 5 units because there are 15 days left in the 30-day month, or 50% and we prorate the units charged by 50%. On the first of May, and each month thereafter until you cancel, the full 10 units will be billed.

When you increase the paid quantity later, we also prorate the increased units to cover the remaining days in the current month. So if you bought 1 more Visual Studio Professional monthly cloud subscription on May 10, we would bill roughly 0.677 units (21 days remaining in the 31-day month of May).

### Q: How do cancellations work?
A: When you cancel a Visual Studio cloud subscription, you are canceling automatic renewal. The subscription continues until its normal renewal date and then simply expires. At expiration, the Visual Studio subscriber can no longer use Visual Studio or any other benefits from the subscription.

With monthly cloud subscriptions, cancellations take effect the first day of the next month. If you only cancel some of your customer's monthly cloud subscriptions, be sure to remove users on the first of the next month to ensure that the correct people continue to have active subscriptions assigned.

For annual cloud subscriptions, cancellations take effect the first day of the month following 12 months from the original purchase, or 12 months from the last annual renewal charge. For instance, if you bought a Visual Studio Enterprise annual cloud subscription on January 3, 2018 then it remains active until February 1, 2019 when it automatically renews for another year. If you cancel at any time between then and February 1, 2020 then the subscription will expire on February 1, 2020. There is no rebate for canceling part way through the subscription year with annual cloud subscriptions.

### Q: What kind of volume discounts are available for Visual Studio subscriptions?
A:  You get a 5% discount on the 6th and all subsequent subscriptions *within each type* of subscription:
- Visual Studio Professional monthly
- Visual Studio Enterprise monthly

So, for example, if you buy 6 Visual Studio Professional monthly subscriptions and 5 Visual Studio Enterprise monthly subscriptions, you'll pay the regular price on five Professional, get a 5% discount on the 6th Professional, and pay regular price on all five Enterprise subscriptions.

Also, the discount only applies to charges in a given monthly billing period. So if you buy 5 Visual Studio Professional annual subscriptions in one month, and then you buy 5 more the next month, you'll pay the regular price on all ten subscriptions.

These discounts are reflected in the pricing data within the [Partner Center](https://partnercenter.microsoft.com).

### Q: Are there renewal discounts?
A:  No, prices for Visual Studio subscriptions are flat. The same price is offered for new subscriptions and continuing subscriptions.

### Q: Are there Azure dev/test pricing options for CSPs?
A: Not at this time. Your customers can take advantage of [Azure dev/test pricing](https://aka.ms/azuredevtestpricing), but we do not have anything specifically for CSPs.

