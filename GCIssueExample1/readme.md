# GC Issue - allocating new array many times

In this example we simmulate 'Garbage Collector issue'. The sample app contains two scenario's:
1. Keep reference sample: A situation in which manny array's are created and added to another array, so the memory consumption will raise forever.
2. Don't keep reference sample: A situation in which we create over and over an array, but don't keep a reference to it.


## Keep reference sample - GC Stats
Perform the following steps to diagnost the issue in PrefView:
1. Start the sample app GCIssueExample1.exe and choose option 1.
2. Start PrefView.
3. Click __Collect__ and __Collect__.
4. Click __Start Collection__.
5. Let the program run for 1 minute and click __Stop Collection__.
6. Wait until the PrefView has processed the data.
7. Double-click the __GCStats__, and navigate to __d__.

You will see interesting information like:
![GC process keeps reference](/images/GC-process-keeps-reference1.png)

Now let's also look at the memory dump
8. Click __Memory__ and __Take heap snapshot__.
9. Select the process and click __Dump GC Heap__.

You will see interesting information like:
![GC process keeps reference](/images/GC-process-keeps-reference2.png)

Which shows you that the static variable (the main arra ) is referencing all most all the memory of the program.

## Don't Keep reference sample - GC Stats
Perform the following steps to diagnost the issue in PrefView:
1. Start the sample app GCIssueExample1.exe and choose option 2.
2. Start PrefView.
3. Click __Collect__ and __Collect__.
4. Click __Start Collection__.
5. Let the program run for 1 minute and click __Stop Collection__.
6. Wait until the PrefView has processed the data.
7. Double-click the __GCStats__, and navigate to __d__.

You will see interesting information like:
![GC process keeps reference](/images/gc-process-does-not-keep-reference.png)


