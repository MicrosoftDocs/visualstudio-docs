---
title: "How to: unlock Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 7/20/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ffb580a1-8b5d-48f5-b811-87f8036f50ea
caps.latest.revision: 8
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---

# How to: unlock Visual Studio
You can evaluate Visual Studio for free up to 30 days. Signing into the IDE extends the trial period to 90 days. To continue using Visual Studio, unlock the IDE by  
  
1.  using an online subscription, or,  
2.  entering a product key.  
  
## To unlock Visual Studio using an online subscription  
To unlock Visual Studio using an MSDN or Visual Studio Team Service subscription associated with a Microsoft account, or a work or school account:  
  
1.  Click on the "Sign in" button in the upper right corner of the IDE (or go to File > Account Settings to open the Account Settings dialog and click on the "Sign in" button.)  
  
2.  Enter the credentials for either a Microsoft account or a work or school account. Visual Studio finds an MSDN subscription or Visual Studio Team Services subscription associated with your account.  
  
> [!IMPORTANT]
>  Visual Studio automatically looks for associated online subscriptions when you connect to a Visual Studio Team Services account from the Team Explorer tool window. When you connect to a Visual Studio Team Services account, you can sign in using both Microsoft and work or school accounts. If an online subscription exists for that user account, Visual Studio will automatically unlock the IDE for you.  
  
## To unlock Visual Studio with a product key  
  
1.  Select **File > Account Settings** to open the Account Settings dialog and click on the "**License with a Product Key**" link.  
2.  Enter the product key in the space provided.  
  
> [!TIP]
>  Prerelease versions of Visual Studio do not have product keys. You must sign in to the IDE to use prerelease versions.  
  
## Address license problem states  
  
### Update stale licenses  
 You may have seen the below message that your license is going stale in Visual Studio, which reads, "Your license has gone stale and must be updated."
  
 ![Visual Studio stale license message](../ide/media/vs2017_stale-license.png)  
  
 This message indicates that while your subscription may still be valid, the license token Visual Studio uses to keep your subscription up to date hasn't been refreshed and has gone stale due to one of the following reasons:  
  
1.  You have not used Visual Studio or have had no internet connection for an extended period of time.   
2.  You signed out of Visual Studio.  
  
Before the license token goes stale, Visual Studio first shows a warning message asking you to reenter your credentials.  
  
If you do not reenter your credentials, the token starts to go stale and the Account Settings dialog tells you how many days you have left before your token will fully expire. After your token expires, you will need to reenter your credentials for this account or license with another method above before you can continue using Visual Studio.  
  
> [!Important]
>  If you are using Visual Studio for extended periods in environments with limited or no internet access, you should use a product key to unlock Visual Studio in order to avoid interruption.  
  
### Update expired licenses  
 If your subscription has expired completely, and you no longer have access rights to Visual Studio, you must:  
  
1.  Renew your subscription. To see more information about the license you are using, go to **File > Account Settings** and look at the license information on the right side of the dialog.  
  
1.  If you have another subscription associated with a different account, add that account to the **All Accounts** list on the left side of the **File > Account Settings** dialog by selecting the **Add an account...** link.  
  
## See also  
[Signing in to Visual Studio](../ide/signing-in-to-visual-studio.md)  
[Connected environment](../ide/connected-environment.md)  
