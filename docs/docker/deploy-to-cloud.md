## Deploying to the cloud

Now that we have run our App locally we can start to think about running it in the cloud so other people can access it and make use of it. To do this we will use Docker Contexts, a Context is the place where you are currently working with containers, right now we only have our ‘default’ context, so we will need to add a cloud one and deploy our App to it. 

## Creating our Cloud Context 
1. To start we can see what Contexts we have by looking at the contexts section of the Docker panel:

![Shows only default context](media/defaultcontext.png)

You should only see your default context for local work.

2. To deploy to the cloud we will want to create a new ACI context, but to do this we first need the Azure account extension so we can authenticate with Azure 

![Adding Azure extension](media/addazureextension.png)

You will need to setup an Azure account if you don’t already have one. 

3. Now we can create our new ACI context 

![Creating our ACI context](media/createnewcontext.png)

This will ask us what resource group we want to run these containers under, either select an existing group using the arrow keys or use the default option to use the new group.

![Selecting our resource group](media/selectresourcegroup.png)

 We can now see our ACI context listed and can right click it to make it our current focus/in use context:

 ![New ACI context can be selected](media/listofcontexts.png)

## Running containers in the cloud 

1. Now we want to use our ACI context and run our container 
   ```bash
   docker context use myacicontext
   docker run  -dp 3000:3000 bengotch/getting-started
   ```

2. Having run this we can now have a look at the container in our context

 ![Container running in our ACI context](media/contextcontainer.png)

3. To check this is all working properly we can now right click on our running container and say ‘view in browser’ 

 ![Container in ACI with public IP](media/containerinaci.png)

And we can see that the container is running in a public IP and working correctly!

4. Lastly to clean up our working space and to make sure we are not being charged for continuing to run our test container we can simply right click on our running container and say remove. 

## Recap
Fantastic, we have now taken our workload and deployed it to the cloud successfully for the first time. You can do all of this from the command line as well from within your ACI context using docker run and also using docker compose up to run your multi container applications. To find out more about running your containers in the cloud read through our extended [documentation on using ACI](https://docs.docker.com/engine/context/aci-integration/)
