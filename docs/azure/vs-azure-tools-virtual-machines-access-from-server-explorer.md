---
title: Accessing Azure Virtual Machines from Server Explorer | Microsoft Docs
description: Get an overview of how to view create and manage Azure virtual machines (VMs) in Server Explorer in Visual Studio.
author: ghogen
manager: jillfra
assetId: eb3afde6-ba90-4308-9ac1-3cc29da4ede0
ms.custom: vs-azure
ms.workload: azure-vs
ms.topic: conceptual
ms.date: 8/31/2017
ms.author: ghogen
---
# Accessing Azure Virtual Machines from Server Explorer

If you have virtual machines hosted by Azure, you can access them in Server Explorer. You must first sign in to your Azure subscription to view your mobile services. To sign in, open the shortcut menu for the Azure node in Server Explorer, and choose **Connect to Microsoft Azure**.

1. In Cloud Explorer, choose a virtual machine, and then choose the F4 key to show its properties window.

    The following table shows what properties are available, but they are all read-only. To change them, use the [Azure portal](https://login.microsoftonline.com/common/oauth2/authorize?resource=https%3a%2f%2fmanagement.core.windows.net%2f&response_mode=form_post&response_type=code+id_token&scope=user_impersonation+openid&state=OpenIdConnect.AuthenticationProperties%3d0bcVTGXPE96h4gnpOtjIlKTihdLBz4VQZ1vDXRtvd7cnhZIM9hQgMWckW4ihPnsqR_Qn6VkCoPMMd38ep32nmICGLbCnFQ_jvmXzKyVMcuyTAmlwtUAqRd8cfypKsK6eavhBrIHHb_WY2svqateCJk6USWvsHPx6HrXRjUV7n_fKShOMkzq-FBHEJf3PnOTe7xYc4qJwPbqPat4P46t2XzvMUk2P8TvdOUDqcW_VSvxdi_DiNGhGwfuaZaIKhN_tOruF2ANYE20cewKgKPqWAAV0i5wufc2psaAO-_Xzd0GknAaGxWZ5AUX1PK9EFPUO0yx3xm2BRyM_jo32oxmnKcuvLBH8nkPcFAM5ftaxFTI&nonce=637072910801639754.YjFhMmQ4OGItNmEzOS00NmMyLWJlMmQtZjZhYzMyMDIyNWQ5M2ZmNDFjOTMtMzg0NC00ODljLTlhMTktOTljOWZlM2UyN2Iw&client_id=c44b4083-3bb0-49c1-b47d-974e53cbdf3c&redirect_uri=https%3a%2f%2fportal.azure.com%2fsignin%2findex%2f%3ffeature.refreshtokenbinding%3dtrue&site_id=501430&client-request-id=a3022f08-704f-468e-be6a-5d40e067f9a6&x-client-SKU=ID_NET&x-client-ver=1.0.40306.1554).

   | Property | Description |
   | --- | --- |
   | DNS Name |The URL with the Internet address of the virtual machine. |
   | Environment |For a virtual machine, the value of this property is always Production. |
   | Name |The name of the virtual machine. |
   | Size |The size of the virtual machine, which reflects the amount of memory and disk space that’s available. For more information, see [Virtual Machine Sizes](https://docs.microsoft.com/azure/cloud-services/cloud-services-sizes-specs). |
   | Status |Values include Starting, Started, Stopping, Stopped, and Retrieving Status. If Retrieving Status appears, the current status is unknown. The values for this property differ from the values that are used on the [Azure portal](https://login.microsoftonline.com/common/oauth2/authorize?resource=https%3a%2f%2fmanagement.core.windows.net%2f&response_mode=form_post&response_type=code+id_token&scope=user_impersonation+openid&state=OpenIdConnect.AuthenticationProperties%3d4vrZSb-eU-kuxU55oQ9K22TV0yfodERRJxCIT1tUOTtx5hSRk3YRE-g_94pwSCQl8PM8_WLWng0l1BjwLJjXfsCfIrjbGwZB-JmlDWDOrF2wf1YD_tchhWH2Vs8zipZ7EhCEAlBtwQ2nn46wP6xVTngQLBa_OHKMZ3IfQv2EA43v0wicnzqPzjXwHJmlFueTkNPzrcRC-D4zyeFLJ-oXLHYMpDjY3PFYA0QM4-QfhTiURxvzpLhHl-JPaQyYCQrnS98JNSW-6LQGNd_MNjDvhnnkEYM-uAhantKBjvBRMOppCDLC99yq3VtPQGSQKTZbnxNeDFc990YXj5-KiPFwheLF5XI-ihpM-wzeeJr1UM0&nonce=637072910816640310.NmUzNTQ3N2ItM2E4MS00MzdhLWE3NDgtZTI4MWQzZWEwMzE3NTc2NmY4NjQtM2JkZC00OGY2LWIzMTgtODcwZDgwM2Y5YmI1&client_id=c44b4083-3bb0-49c1-b47d-974e53cbdf3c&redirect_uri=https%3a%2f%2fportal.azure.com%2fsignin%2findex%2f%3ffeature.refreshtokenbinding%3dtrue&site_id=501430&client-request-id=a3022f08-704f-468e-be6a-5d40e067f9a6&x-client-SKU=ID_NET&x-client-ver=1.0.40306.1554). |
   | SubscriptionID |The subscription ID for your Azure account. You can show this information on the [Azure portal](https://login.microsoftonline.com/common/oauth2/authorize?resource=https%3a%2f%2fmanagement.core.windows.net%2f&response_mode=form_post&response_type=code+id_token&scope=user_impersonation+openid&state=OpenIdConnect.AuthenticationProperties%3d_HBOkwaNf2ice0j6nZRV60ml6hMwqf5C9MiK-7svsFClom4qbv8Y9qkg032Y18zsb2b6_z0TfV0v0GZtiRR77_aJyEjTtr9aCzlpRPIlyrOJB1kYSk6Sq2QyaugYyyepOfffQT0GvGKY-Xpzy6AIkXGebGrk-wBDeUILdG2UkRrUNStkeVPVLOhDmvkvA57o44bCCCcxMA4f2mDf7up7m0h-7nyxAl4ev7FWYcwFDduSLbTEhWQgNLQZSi2rkPdoQQWsGoK1SkUgQOlgfCq4RbxYxMVb5MYBR5M01VvwQZ7nraEwPODLZozmbCf3wvwNzxjtBlWGbLUZP1tvllrm3afXDEjdMIMjI0mM2c9cpWA&nonce=637072910829245022.NWU5YmYzNzUtYmZlZC00ZGYwLWFmZDQtYWEwOThiMThmMjlkOTljYzRhMDktNzBhOS00MmMwLWI2ZDYtOTY5NjIyNDAzZjM1&client_id=c44b4083-3bb0-49c1-b47d-974e53cbdf3c&redirect_uri=https%3a%2f%2fportal.azure.com%2fsignin%2findex%2f%3ffeature.refreshtokenbinding%3dtrue&site_id=501430&client-request-id=a3022f08-704f-468e-be6a-5d40e067f9a6&x-client-SKU=ID_NET&x-client-ver=1.0.40306.1554) by viewing the properties for a subscription. |
2. Choose an endpoint node, and then view the **Properties** window.
3. The following table describes the available properties of endpoints, but they are read-only. To add or edit the endpoints for a virtual machine, use the [Azure portal](https://login.microsoftonline.com/common/oauth2/authorize?resource=https%3a%2f%2fmanagement.core.windows.net%2f&response_mode=form_post&response_type=code+id_token&scope=user_impersonation+openid&state=OpenIdConnect.AuthenticationProperties%3dnmzTuHGM_z3NObUXQhp32gl68wkOMQJIt7tnlhe2jm-5PAgPNFaVdkDljg7MOt1mK6at7iU7J44IAEXUNkLA_Qz9Q-AxEEBTJVezd-nIDJ-Eg2yGJUkiX0cwG4up8JKNs69J46ZBVziogznFEsQsfduR6JkIzNEzsRiPGXQhRNI89ZjOqVWiI58MmS3XoFZZZdyMwAAP1rjzb8PFbpamolPieFp4Yny3XqATDfSVj4mRyk2cwvGgPLfbLJG3ZMfvJ3Q3c6eEYtgaHiOaFO2Oy0Lb7_vte8H8Dw6UxG36uCHNMtGFjWpBwtHTCFNTMuEkpOipqAYNv8T_SVakULykpLD7R57aRcY6re_P04N_rRw&nonce=637072910841248984.Y2YzYTk3YjctYzhjZS00ODVkLWFjM2ItMjZiYjgxMWUwMWJkOWFkZTliZGUtMzQxNy00N2Y2LWFjOWItNmNiN2ZiOGJiYjBj&client_id=c44b4083-3bb0-49c1-b47d-974e53cbdf3c&redirect_uri=https%3a%2f%2fportal.azure.com%2fsignin%2findex%2f%3ffeature.refreshtokenbinding%3dtrue&site_id=501430&client-request-id=a3022f08-704f-468e-be6a-5d40e067f9a6&x-client-SKU=ID_NET&x-client-ver=1.0.40306.1554).

   | Property | Description |
   | --- | --- |
   | Name |An identifier for the endpoint. |
   | Private Port |The port for network access internal to your application. |
   | Protocol |The protocol that the transport layer for this endpoint uses, either TCP or UDP. |
   | Public Port |The port that’s used for public access to your application. |
