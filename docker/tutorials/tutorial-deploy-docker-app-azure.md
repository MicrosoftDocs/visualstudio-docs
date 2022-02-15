---
title: "Tutorial: Deploy a Docker app to Azure"
description: Learn how to deploy your Docker app to the cloud.
author: ucheNkadiCode
ms.author: uchen
ms.prod: vs-code
ms.topic: tutorial
ms.date: 02/15/2022
ms.custom: template-tutorial

# Under contractual obligation with Docker Inc. to provide this content. Contact is: nebuk89. Mike Morton has context on MSFT side, but has moved on to another role. 
---

<!--
Remove all the comments in this template before you sign-off or merge to the 
main branch.
-->

<!--
This template provides the basic structure of a tutorial article.
See the [tutorial guidance](contribute-how-to-mvc-tutorial.md) in the contributor guide.

To provide feedback on this template contact 
[the templates workgroup](mailto:templateswg@microsoft.com).
-->

<!-- 1. H1 
Required. Start with "Tutorial: ". Make the first word following "Tutorial: " a 
verb.
-->

# Tutorial: Deploy your Docker app to the Azure cloud

<!-- 2. Introductory paragraph 
Required. Lead with a light intro that describes, in customer-friendly language, 
what the customer will learn, or do, or accomplish. Answer the fundamental “why 
would I want to do this?” question. Keep it short.
-->

[Add your introductory paragraph]

<!-- 3. Tutorial outline 
Required. Use the format provided in the list below.
-->

In this tutorial, you learn how to:

> [!div class="checklist"]
> * All tutorials include a list summarizing the steps to completion
> * Each of these bullet points align to a key H2
> * Use these green checkboxes in a tutorial

<!-- 4. Prerequisites 
Required. First prerequisite is a link to a free trial account if one exists. If there 
are no prerequisites, state that no prerequisites are needed for this tutorial.
-->

## Prerequisites

- <!-- An Azure account with an active subscription. [Create an account for free]
  (https://azure.microsoft.com/free/?WT.mc_id=A261C142F). -->
- <!-- prerequisite 2 -->
- <!-- prerequisite n -->

<!-- 5. H2s
Required. Give each H2 a heading that sets expectations for the content that follows. 
Follow the H2 headings with a sentence about how the section contributes to the whole.
-->

10:  


# Deploy to the cloud

Now that you have run your app locally, you can start to think about running it in the cloud so other people can access it and make use of it. To do this, you'll use Docker contexts. A context is the place where you're currently working with containers. Right now, you only have your "default" context, so you'll need to add a cloud one and deploy your app to it.

## Create your cloud context

1. To start, you can see what contexts you have by looking at the contexts section of the Docker panel:

   ![Shows only default context](media/defaultcontext.png)

You should only see your default context for local work.

1. To deploy to the cloud, you need to create a new ACI context, but to do this, you first need the Azure account extension to authenticate with Azure.

   ![Adding Azure extension](media/addazureextension.png)

You'll need to set up an Azure account if you don’t already have one.

1. Now you can create your new ACI context. You can do this by clicking the plus button on the **Contexts** section of the Docker view.

   ![Creating your ACI context](media/createnewcontext.png)

This will ask you what resource group you want to run these containers under. Either select an existing group using the arrow keys, or use the default option to use the new group.

![Selecting your resource group](media/selectresourcegroup.png)

You can now see your ACI context listed and can right-click it to make it your current focus/in use context:

![New ACI context can be selected](media/listofcontexts.png)

## Run containers in the cloud

1. Now, use your ACI context and run the container.

   ```bash
   docker context use myacicontext
   docker run  -dp 3000:3000 <username>/getting-started
   ```

1. Having run this, now look at the container in your context.

   ![Container running in your ACI context](media/contextcontainer.png)

1. To check this is all working properly, you can right-click on the running container and choose **View in browser**.

   ![Container in ACI with public IP](media/containerinaci.png)

And, you can see that the container is running in a public IP and working correctly!

1. Now, you can have a look at our running container to see how it is working. You can start by having a look at the container logs:
 
 ```bash
   docker logs distracted-jackson
   ```

1. You can also exec into your container as you would with a local container.
 
 ```bash
   docker exec -it distracted-jackson sh
   ```

1. Lastly to clean up your working space and to make sure you're not being charged for continuing to run the test container, you can simply right-click on the running container and choose **Remove**.

## Recap

Fantastic, you've now taken your workload and deployed it to the cloud successfully for the first time. You can do all of this from the command line as well from within your ACI context using `docker run` and also using `docker compose up` to run your multi-container applications. To find out more about running your containers in the cloud, read through the extended [documentation on using ACI](https://docs.docker.com/engine/context/aci-integration/).

## Next steps

Continue with the tutorial!

> [!div class="nextstepaction"]
> [What's next](whats-next.md)


what next:


# What's next

Although you're done with your tutorial, there's still a LOT more to learn about containers!
You're not going to go deep-dive here, but here are a few other areas to look at next!

## Container orchestration

Running containers in production is tough. You don't want to log into a machine and simply run a
`docker run` or `docker-compose up`. Why not? Well, what happens if the containers die? How do you
scale across several machines? Container orchestration solves this problem. Tools like Kubernetes,
Swarm, Nomad, and AKS all help solve this problem, all in slightly different ways.

The general idea is that you have "managers" who receive **expected state**. This state might be
"I want to run two instances of my web app and expose port 80." The managers then look at all of the
machines in the cluster and delegate work to "worker" nodes. The managers watch for changes (such as
a container quitting) and then work to make **actual state** reflect the expected state.

## Cloud Native Computing Foundation projects

The CNCF is a vendor-neutral home for various open-source projects, including Kubernetes, Prometheus, 
Envoy, Linkerd, NATS, and more! You can view the [graduated and incubated projects here](https://www.cncf.io/projects/)
and the entire [CNCF Landscape here](https://landscape.cncf.io/). There are a LOT of projects to help
solve problems around monitoring, logging, security, image registries, messaging, and more!

So, if you're new to the container landscape and cloud-native application development, welcome! Please
connect to the community, ask questions, and keep learning! We're excited to have you!

## Working with Docker in VS Code

Learn more about using the VS Code Docker extension:

- [VS Code Docker Extension overview](https://code.visualstudio.com/docs/containers/overview)
- [Get started with Node.js](https://code.visualstudio.com/docs/containers/quickstart-node)
- [Get started with Python](https://code.visualstudio.com/docs/containers/quickstart-python)
- [Get started with .NET Core](https://code.visualstudio.com/docs/containers/quickstart-aspnet-core)
- [Debug containerized apps](https://code.visualstudio.com/docs/containers/debug-common)




## [Section 1 heading]
<!-- Introduction paragraph -->

1. Sign in to the [<service> portal](url).
1. <!-- Step 2 -->
1. <!-- Step n -->

## [Section 2 heading]
<!-- Introduction paragraph -->
1. <!-- Step 1 -->
1. <!-- Step 2 -->
1. <!-- Step n -->

## [Section n heading]
<!-- Introduction paragraph -->
1. <!-- Step 1 -->
1. <!-- Step 2 -->
1. <!-- Step n -->

<!-- 6. Clean up resources
Required. If resources were created during the tutorial. If no resources were created, 
state that there are no resources to clean up in this section.
-->

## Clean up resources

If you're not going to continue to use this application, delete
<resources> with the following steps:

1. From the left-hand menu...
1. ...click Delete, type...and then click Delete

<!-- 7. Next steps
Required: A single link in the blue box format. Point to the next logical tutorial 
in a series, or, if there are no other tutorials, to some other cool thing the 
customer can do. 
-->

## Next steps

Advance to the next article to learn how to create...
> [!div class="nextstepaction"]
> [Next steps button](contribute-how-to-mvc-tutorial.md)

<!--
Remove all the comments in this template before you sign-off or merge to the 
main branch.
-->