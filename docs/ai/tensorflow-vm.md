# Run a TensorFlow model in the cloud
In this tutorial, we will run a TensorFlow model using the [MNIST dataset](http://yann.lecun.com/exdb/mnist/) in a Azure [Deep Learning](https://docs.microsoft.com/azure/machine-learning/data-science-virtual-machine/deep-learning-dsvm-overview) virtual machine. Start by installing the following:

## Setup Azure Deep Learning Virtual Machine

> [!NOTE] 
> Set **Location** to US West 2 and **OS type** as Linux.

Instuctions for setting up Deep Learning Virtual Machine can be found [here](https://docs.microsoft.com/azure/machine-learning/data-science-virtual-machine/provision-deep-learning-dsvm). 

### Install cuDNN
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

## Download sample code
Download this [GitHub repository](https://github.com/Microsoft/samples-for-ai) containing samples for getting started with deep learning across TensorFlow, CNTK, Theano and more. 

## Open Project 

1. Launch Visual Studio and select **File > Open > Project/Solution**.

2. Select the folder containing the samples dowloaded earlier.

## Add Azure Remote VM

In Server Explorer, right click the **Remote Machines** node under the AI Tools node and select "Add…". Users need to provide Remote Machine display name, IP host, SSH port, user name and password/key file. 

![Add a new remote machine](media\tensorflow-vm\add-remote-vm.png)

## Submit Job to Azure VM
Right click on MNIST project in **Solution Explorer** and select **Submit Job**.

![Job submission to a remote machine](media\tensorflow-vm\job-submission.png)

In the submission window:

1. In the list of "Cluster to use", users can select the remote machine (with "rm:" prefix) to submit the job to.

2. The "Job name" allows users to enter a name for this job to show it up in the cluster.

3. AI Tools provides a default script to run the project on remote machine. User only need to provide the startup program (e.g. "python"), environment variables (e.g. setting CUDA_VISIBLE_DEVICES="0" to use only one GPU), and arguments (e.g." --log_dir=/tmp/output --output_dir=/tmp/output --input_dir=/tmp/input"). The following command will be executed on your remote machine:

```text
CUDA_VISIBLE_DEVICES="0" python script.py --log_dir=/tmp/output --output_dir=/tmp/output --input_dir=/tmp/input
```

4. User can use a customized startup bash script by click "Start bash script" and select the file by "Browse…". This script will be transmitted to the remote machine with UTF-8/Linux EOL format

5. Default output and log directories are exported bo $LOG_DIR and $OUTPUT_DIR environment variables that user can use directly.

> [!NOTE] 
> - Only the files in project and customized startup bash script will be transmitted to remote machine while submitting. All the files in project will keep the same structure as working directory.
> - Only the customized startup bash script will be auto-encoded to UTF-8 with Linux EOL.
> - The startup command or script will be executed in non-interactive shell mode, under the root of the working directory.


## Monitor NVIDIA GPUs on a Remote Machine
AI Tools provides a graphical representation of GPU information such as GPU spec and usage. Right-click a remote machine node in the left Server Explorer, and then click the "Show Heat Map" context menu.

![Heat Map context menu](media\tensorflow-vm\heat-map-context.png)

![Heat Map tool window](media\tensorflow-vm\heat-map-tool.png)