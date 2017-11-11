# Run a TensorFlow model in the cloud
In this tutorial, we will run a TensorFlow model using the [MNIST dataset](http://yann.lecun.com/exdb/mnist/) in an Azure [Deep Learning](https://docs.microsoft.com/azure/machine-learning/data-science-virtual-machine/deep-learning-dsvm-overview) virtual machine. 

The MNIST database has a training set of 60,000 examples, and a test set of 10,000 examples of handwritten digits.

## Prerequisites
Before you begin, ensure you have the following installed and configured:

### Setup Azure Deep Learning Virtual Machine

> [!NOTE] 
> Set **Location** to US West 2 and **OS type** as Linux.

Instuctions for setting up Deep Learning Virtual Machine can be found [here](https://docs.microsoft.com/azure/machine-learning/data-science-virtual-machine/provision-deep-learning-dsvm). 

### Install cuDNN
Connect into the deep learning virtual machine and install cuDNN.

```bash
wget http://developer.download.nvidia.com/compute/redist/cudnn/v6.0/cudnn-8.0-linux-x64-v6.0.tgz
tar -xzvf ./cudnn-8.0-linux-x64-v6.0.tgz
sudo mkdir /usr/local/cudnn-6.0
sudo cp -r cuda /usr/local/cudnn-6.0
```

### Edit Bash RC to support not running interactively (comment out the case statement)

```bash
# If not running interactively, don't do anything
#case $- in
#    *i*) ;;
#      *) return;;
#esac
```

### Add Path Variables
```bash
export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:/usr/local/cuda/lib64
export PATH=$PATH:/usr/local/cuda/bin
export LD_LIBRARY_PATH=/usr/local/cudnn-6.0/cuda/lib64:$LD_LIBRARY_PATH
export PATH=/anaconda/envs/py35/bin:$PATH
``` 

### Download sample code
Download this [GitHub repository](https://github.com/Microsoft/samples-for-ai) containing samples for getting started with deep learning across TensorFlow, CNTK, Theano and more. 

## Open project

- Launch Visual Studio and select **File > Open > Project/Solution**.

- Select the **Tensorflow Examples** folder from the samples repository dowloaded and open the **TensorflowExamples.sln** file. 

![Open project](media\tensorflow-local\open-project.png)

![Open solution](media\tensorflow-local\open-solution.png)

## Add Azure Remote VM

In Server Explorer, right click the **Remote Machines** node under the AI Tools node and select "Add…". Enter the Remote Machine display name, IP host, SSH port, user name and password/key file. 

![Add a new remote machine](media\tensorflow-vm\add-remote-vm.png)

## Submit job to Azure VM
Right click on MNIST project in **Solution Explorer** and select **Submit Job**.

![Job submission to a remote machine](media\tensorflow-vm\job-submission.png)

In the submission window:

- In the list of **Cluster to use**, select the remote machine (with "rm:" prefix) to submit the job to.

- Enter a **Job name**. 

- Click **Submit**. 

## Check status of job 
To see status and details of jobs: expand the virtual machine you submitted the job to in the **Server Explorer**. Double click on **Jobs**.

![Job browser](media\tensorflow-vm\job-browser.png)

## Clean up resources

Stop the VM if you plan on using it in the near future. If you are finished with this tutorial, run the following command to clean up your resources:

```azure-interactive
az group delete --name myResourceGroup
```