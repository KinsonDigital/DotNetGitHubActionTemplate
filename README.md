<h1 align="center">

**DOTNET Action Template**<!--TODO: Update this-->
</h1>

<div align="center">

<div hidden>TODO: ADD BADGES HERE</div>

</div>


<div align="center">

<!--
    TODO: Update this and update link at the bottom that sends you back to here
-->
## **What is it?**
</div>

<!--TODO: Add description of what the github action is-->

<div align="center"><h2 style="font-weight:bold">⚠️Quick Note⚠️</h2></div>

This GitHub action is built using C#/NET and runs in a docker container.  If the job step for running this action is contained in a job that runs on **Windows**, you will need to move the step to a job that runs on **Ubuntu**.  You can split up your jobs to fulfill `runs-on` requirements of the GitHub action. This can be accomplished by moving the step into it's own job.  You can then route the action step outputs to the job outputs and use them throughout the rest of your workflow. For more information, refer to the Github documentation links below:

For more info on step and job outputs, refer to the GitHub documentation links below:
- [Defining outputs for jobs](https://docs.github.com/en/actions/using-jobs/defining-outputs-for-jobs)
- [Setting a step action output parameter](https://docs.github.com/en/actions/using-workflows/workflow-commands-for-github-actions#setting-an-output-parameter)

<!--TODO: Add simple description-->

<div align="center"><h2 style="font-weight:bold">Quick Example</h2></div>


```yaml
# TODO: Add YAML example
```

<div align="left">
<a href="#examples">More Examples Below!! 👇🏼</a> TODO: This might not be required to be here
</div>

---

<div align="center"><h2 style="font-weight:bold">What does it do?</h2></div>

TODO: Explain what it does

---

<div align="center">

## **Action Inputs**
</div>

TODO: Show action inputs in table

| Input Name | Description | Required | Default Value |
|---|:----|:---:|---|
| sample-input | Just a sample!! | yes | N/A |

---

<div align="center">

## **Action Outputs**
</div>

TODO: Show action outputs in table

<table align="center">
    <tr>
        <th>Output Name</th>
        <th>Description</th>
        <th>Values Returned</th>
    </tr>
    <tr align="center">
        <td>valid-output</td>
        <td align="left">Just a sample!! <span style="font-weight: bold">true</span> or <span style="font-weight: bold">false</span> indicating whether or not the branch is valid.</td>
        <td><span style="font-weight: bold">true</span> or <span style="font-weight: bold">false</span></td>
    </tr>
</table>

---

<div align="center" style="font-weight:bold">

## **Examples**
</div>

TODO: Show examples if required

<div align="center">

### **Example 1 - (Example 1)**
</div>

<div align="center">

### **Example 2 - (Example 2)**
</div>

---

<div align="center">

## **Other Info**
</div>

<div align="left">

### License

<!--TODO: Update this-->
- [MIT License - DotNetGitHubActionTemplate]()
</div>

<div align="left">

### Maintainer
</div>

TODO: Update these links

<!--TODO: Update all of these links-->
- [Calvin Wilkinson](https://github.com/CalvinWilkinson) (Owner and main contributor of the GitHub organization [KinsonDigital](https://github.com/KinsonDigital))
  - [NET GitHub Action Sample](https://github.com/KinsonDigital/DotNetGitHubActionTemplate) is used in various projects for this organization with great success.
- Click [here](https://github.com/KinsonDigital/DotNetGitHubActionTemplate/issues/new/choose) to report any issues for this GitHub action!!

<div align="right">
<a href="#what-is-it?">Back to the top!👆🏼</a>
</div>
