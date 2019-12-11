---
title: "How to: Set Permissions | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling, setting permissions"
  - "security [Visual Studio ALM], setting permissions"
  - "permissions [Visual Studio ALM], profiling"
  - "profiling tools, setting profiling permissions"
  - "performance tools, setting profiling permissions"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# How to: Set permissions

This article describes how an Administrator of a computer grants the security permissions required for profiling to a user or group that does not have Administrator permissions on that computer.

A basic security principle states that applications should run with no more than the permissions they need. This principle also applies to users. If users can be fully effective when they are logged on as members of the Users group instead of the Administrators group, they should not be granted Administrator permissions. The first procedure, "To create a user account that has User permissions," describes how to create a user account for a member of the Users group.

Members of the Users group will need access to the folders and files on disk that are shared with other members of the team. The second procedure, "To grant access to shared project files," describes how to grant that access.

Members of the Users group can run the profiling tools if an administrator grants them access to the software driver for the profiling tools. The last procedure, "To grant access to the profiling driver," describes how to grant access to that driver.

> [!NOTE]
> You need administrator permissions to follow the steps in these procedures.

## To create a user account that has User permissions

1. Right-click **My Computer** and then click **Manage**.

     The **Computer Management** window opens.

2. Expand **Local Users and Groups**.

3. Right-click the **Users** folder and then click **New User**.

     The **New User** dialog box appears.

4. Complete the fields in this dialog box with the information for the user account you are creating. Specify a password. Optionally, select the check box that requires that the user change the password at the next logon.

5. Click **Create** and then click **Close**.

     The new user appears in the Users group, a group of users who do not have Administrator permissions.

## To grant access to shared project files

1. In Windows Explorer (or File Explorer), locate the root of the folder tree for project files used by this user and shared by the project team.

     The path of this folder might resemble the following:

    ```cmd
    D:\ourProject
    ```

2. Right-click the folder and then click **Properties**.

     The **\<folder name> Properties** dialog box appears.

3. Click the **Security** tab.

4. Click the name of the user's account in the **Group or user names** box.

5. In the **Permissions for \<user name>** box, select the check box for **Full Control**.

6. Click **OK**.

     This grants permissions to the user for the shared folder tree that begins with the folder selected in step 5.

## To grant access to the profiling driver

1. Open a command prompt as an administrator.

2. Change the directory to:

    ```cmd
    <drive>:\Program Files\Microsoft Visual Studio 14\Team Tools\Performance Tools
    ```

3. Run the following command:

    ```cmd
    vsperfcmd /admin:driver,start /admin:service,start
    ```

     This command installs and starts the driver for the profiling tools.

     This command starts the profiling driver and service so that non-admin users may use profiling features that are available in their User process space. Only an Administrator may run the command; and it will fail for non-administrative Users.

     Notice that the effects of this step are undone after the computer restarts, unless you also perform the final step in this procedure.

4. Run the command to allow access to profiling driver functionality by a user or group that does not have administrator access to the computer:

    ```cmd
    vsperfcmd /admin:security,allow,<right[,right],<user name|group name>
    ```

     This command grants the \<user name> or \<group name> account access to the Profiling tools. The \<right> option determines the profiling functionality the user can access. The \<right> option can be one or more of the following values:

    - FullAccess - allows access to all profiling methods including collecting performance data from services, sampling, and cross session profiling.

    - SampleProfiling - allows access to sample profiling methods

    - CrossSession - allows access to cross session profiling which is required for profiling services.

5. (Optional) To preserve the results of any of the previous steps after computer restarts, run the following command:

    ```cmd
    vsperfcmd /admin:driver,autostart,on
    ```

   The specified users, after logging on, will now be able to use the profiling tools without Administrator permissions.

## See also

[Configure performance sessions](../profiling/configuring-performance-sessions.md)
[VSPerfCmd](../profiling/vsperfcmd.md)
[Profiling and Windows Vista Security](../profiling/profiling-and-windows-vista-security.md)
