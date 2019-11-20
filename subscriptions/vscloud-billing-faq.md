---
title: Billing FAQ for Visual Studio Enterprise and Visual Studio Professional cloud subscriptions
author: evanwindom
ms.author: lank
manager: lank
ms.date: 07/28/2019
ms.topic: conceptual
description:  Billing questions for cloud subscriptions.
---
# Visual Studio cloud subscriptions billing FAQ
Make sure to [compare cloud subscription benefits and pricing](https://visualstudio.microsoft.com/vs/pricing/) to understand the benefits of each Visual Studio subscription,
with comparisons between cloud and standard Visual Studio subscriptions, details on subscriber benefits, and more.

## General purchasing questions
### Q: Can I buy Visual Studio cloud subscriptions using a Purchase Order?
A: No. All Visual Studio cloud subscriptions must be purchased using an Azure subscription. (Think of it as your Azure billing account.)

### Q: What types of Azure subscriptions can be used to buy Visual Studio cloud subscriptions?
A: Most Azure subscriptions can be used--we support Azure subscriptions connected to your
[Enterprise Agreement (EA)](https://azure.microsoft.com/pricing/enterprise-agreement/), Azure subscriptions set up by
Cloud Solution Providers (CSPs), Azure subscriptions set up through Microsoft Open License resellers, and Pay-As-You-Go Azure subscriptions.

Some types of Azure subscriptions, including [Azure Free Trial](https://azure.microsoft.com/pricing/free-trial/) and subscriptions included as subscriber benefits in Visual Studio subscriptions cannot be used.

### Q: Am I required to buy other Azure services?
A: Not at all. If you only want to buy Visual Studio cloud subscriptions via Azure, you can do that.

## Enterprise Agreement (EA) customers
### Q: Can I use an Enterprise Agreement to buy Visual Studio cloud subscriptions?
A: Yes, you can. You'll need to be an owner or contributor for an Azure subscription that was created for your EA. Please make sure that you make your
purchases for Visual Studio cloud subscriptions directly in the Visual Studio Marketplace. You cannot purchase Visual Studio cloud subscriptions using a
Purchase Order.

### Q: How can I tell whether I have the necessary privileges to buy services in the Visual Studio Marketplace through my organization's Enterprise Agreement?
A: The easiest approach to determine if you have the right privileges is to click the **Buy** button for a service offered in the Visual Studio Marketplace.
You need to select an Azure subscription (which is a billing account) from a presented list of Azure subscriptions that are currently linked to your login.
Because the name of the Azure subscription defaults to the type of billing account ("Pay-As-You-Go", "Enterprise Agreement", etc.), it is often clear if the
Azure subscription is part of your Enterprise Agreement.

Another approach is to attempt to visit the [Azure Enterprise Portal](https://ea.azure.com).  If you can reach it successfully, then you already have either
the Enterprise Admin or the Account Owner role. Only Account Owners can set up new Azure billing accounts in an Enterprise Agreement. If you cannot access
the Azure Enterprise Portal, then please inquire within your organization to find out who your Enterprise Admin is, and ask that person to add you as an
Account Owner within the Azure Enterprise Portal.  If you are unable to find this person, you can [submit a support ticket](https://aka.ms/AzureEntSupport)
and request the contact information.  You need your organization's name and your Enterprise Agreement enrollment number for the support ticket.

### Q: Can I use the Azure Monetary Commitment funds from my Enterprise Agreement to buy Visual Studio cloud subscriptions?
A: No, these prepaid funds are not eligible for purchasing Visual Studio cloud subscriptions. When you choose an Azure subscription that was created for your
EA to purchase Visual Studio cloud subscriptions, the charges will appear on your next "overage" invoice. Typically this happens monthly, but due to historical
rules for some EA customers, an overage invoice might not be issued for several months. Please consult a licensing specialist for your EA if you need to know
what amount of additional purchases (purchases which are not eligible for Azure Monetary Commitment funds) will trigger an overage invoice.

## How charges are processed
### Q: How are **monthly** cloud subscription charges processed?
A: At the first purchase, we bill a prorated quantity to cover the remaining days in the current month. For instance, if a purchase of 10 Visual Studio Professional monthly
cloud subscriptions was made on April 15, then we would charge 5 units because 50% of the month remains (15 days of a 30-day month).
On the first of May, and each month thereafter until you cancel, the full 10 units will be billed.

When you increase the paid quantity later, we also prorate the increased units to cover the remaining days in the current month. So if you bought 1 more Visual Studio
Professional monthly cloud subscription on May 10, we would bill roughly 0.677 units (21 days remaining in the 31-day month of May).

### Q: How are **annual** cloud subscription charges processed?
A: At each purchase, we bill the full quantity purchased immediately. Charges are not spread over the year and there is no prorating. If you buy annual cloud subscriptions
at different times in the year, you will have subscriptions renewing in different months. We do not make all of a customer's annual cloud subscriptions coterminous as is
common with Microsoft volume licensing agreement purchasing.

### Q: How do cancelations work?
A: When you cancel a Visual Studio cloud subscription, you are canceling automatic renewal. The subscription continues until its normal renewal date and then simply expires.
At expiration, the Visual Studio subscriber can no longer use Visual Studio or any other benefits from the subscription.

With monthly cloud subscriptions, cancelations take effect the first day of the next month. If you only cancel some of your monthly cloud subscriptions,
be sure to remove users on the first of the next month to ensure that the correct people continue to have active subscriptions assigned.

For annual cloud subscriptions, cancelations take effect the first day of the month following 12 months from the original purchase, or 12 months from the last annual
renewal charge. For instance, if you bought a Visual Studio Professional annual cloud subscription on January 3, 2018 then it remains active until February 1, 2019 when
it automatically renews for another year. If you cancel at any time between then and February 1, 2020 then the subscription will expire on February 1, 2020. There is no
rebate for canceling part way through the subscription year with annual cloud subscriptions.

### Q: What kind of volume discounts are available for Visual Studio subscriptions?
A:  You get a 5% discount on the 6th and all subsequent subscriptions *within each type* of subscription:

* Visual Studio Professional monthly
* Visual Studio Professional annual
* Visual Studio Enterprise monthly
* Visual Studio Enterprise annual

So for example, if you buy 6 Visual Studio Professional monthly subscriptions and 5 Visual Studio Enterprise monthly subscriptions, you'll pay the regular price on 5 Professional, get a 5% discount on the 6th Professional, and pay regular price on all 5 Enterprise subscriptions.

Also, the discount only applies to charges in a given monthly billing period. So if you buy 5 Visual Studio Professional annual subscriptions in one month, and then you buy 5 more the next month, you'll pay the regular price on all 10 subscriptions.

> [!NOTE]
> Microsoft no longer offers Visual Studio Professional Annual subscriptions and Visual Studio Enterprise Annual subscriptions in Cloud Subscriptions. There will be no change to existing customers experience and ability to renew, increase, decrease, or cancel their subscriptions. New customers are encouraged to go to [https://visualstudio.microsoft.com/vs/pricing/](https://visualstudio.microsoft.com/vs/pricing/) to explore different options to purchase Visual Studio.

## Other questions
### Q: Can I use the monthly Azure DevTest individual credit as a Visual Studio subscriber to buy more Visual Studio cloud subscriptions?
A: No, you can't use your [monthly Azure DevTest individual credit](https://azure.microsoft.com/pricing/member-offers/credit-for-visual-studio-subscribers/) as a Visual Studio subscriber to pay for Visual Studio Marketplace purchases. Any Visual Studio cloud subscription purchases will be billed to your credit card.
Before you make purchases, you will need to [remove your spending limit](https://azure.microsoft.com/pricing/spending-limits/).

### Q: What's the difference between annual and monthly cloud subscriptions?
A:  Monthly cloud subscriptions include Visual Studio plus use of Azure DevOps Services and TFS. Annual cloud subscriptions have this too, but also include subscriber
benefits, including use of Windows and other Microsoft software to install and run for development and testing, a monthly Azure DevTest individual credit to use for experimenting with Azure services and doing development and testing in the cloud, training, support, and much more.
[Compare cloud subscription benefits and pricing](https://visualstudio.microsoft.com/vs/pricing/)

### Q: Do I get new versions of Visual Studio if I buy a Visual Studio cloud subscription?
A:  Yes. As new versions are released, you can download and run them. Plus you can continue to run previous versions too.

### Q: Can I buy Visual Studio cloud subscriptions from my software reseller?
A:  Yes, you can, if your reseller participates in the Cloud Solution Provider (CSP) program. Just ask them.

## Related resources
- [Visual Studio Subscriptions Administration portal](https://manage.visualstudio.com/)
- [Visual Studio subscription support](https://visualstudio.microsoft.com/vs/support/)
- [Visual Studio cloud subscription purchasing for CSPs](vscloud-csp.md)

## Next steps
Buy cloud subscriptions now
- [Visual Studio Professional monthly](https://marketplace.visualstudio.com/items?itemName=ms.vs-professional-monthly)
- [Visual Studio Enterprise monthly](https://marketplace.visualstudio.com/items?itemName=ms.vs-enterprise-monthly)