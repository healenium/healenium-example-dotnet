# healenium
.NET + NUnit + MSBuild project with healenium usage example 

## How to start
### 1.Start Healenium backend from 'infra' folder

```cd infra```
To work with Healenium and Selenoid plus Selenoid Ui, use:
<pre>
    <b>docker-compose up -d</b>

    To download docker-compose.yaml file into your project use this command:

    <b>$ curl https://raw.githubusercontent.com/healenium/healenium-example-dotnet/master/infra/docker-compose.yaml -o docker-compose.yaml</b>
</pre>
To work with Healenium and standard Selenium hub with nodes, use:
<pre>
    <b>docker-compose -f docker-compose-selenium-v3.yaml up -d</b>

    To download docker-compose-selenium-v3.yaml file into your project use this command:

    <b>$ curl https://raw.githubusercontent.com/healenium/healenium-example-dotnet/master/infra/docker-compose-selenium-v3.yaml -o docker-compose-selenium-v3.yaml</b>
</pre>
Create <b>/db/sql</b> folder on the same level in your project.
<pre>
    Add init.sql file into ./db/sql/init.sql folder in your project via command:

    <b>$ curl https://raw.githubusercontent.com/healenium/healenium/master/db/sql/init.sql -o init.sql</b>
</pre>
Verify the next images are <b>Up</b> and <b>Running</b>
<pre>
    * postgres:14.2-bullseye
    * healenium/hlm-backend:3.2.3
    * healenium/hlm-selector-imitator:1.1
    * healenium/hlm-proxy:1.0.0
    * healenium/hlm-selenoid:0.1.0
    * aerokube/selenoid-ui:1.10.5
</pre>
### 2. Project structure
```
|__healenium-example-dotnet (root)
    |__infra
        |__db
            |__sql
                |__init.sql
        |__docker-compose.yaml
        |__docker-compose-selenium-v3.yaml
    |__src
        |__Healenium.Selenium
            |__constants
            |__pages
            |__Properties
            |__search
            |__Healenium.Selenium.csproj
            |__packages.config
    |__tests
        |__Healenium.Selenium.Tests
            |__Properties
            |__tests
            |__Healenium.Selenium.Tests.csproj
            |__packages.config
        |__Healenium.SeleniumRP.Tests
            |__Properties
            |__tests
            |__app.config
            |__Healenium.SeleniumRP.Tests.csproj
            |__packages.config
            |__ReportPortal.config.json
``` 
			   
### 3.Run test
You can run tests via Test Explorer
To run tests for specified test project in terminal with nunit3-console you need to go to ```/bin/Debug/``` project folder

> If you want to execute tests from Healenium.Selenium.Tests project, please use the command: 
```nunit3-console Healenium.Selenium.Tests.dll --where "class=~MarkupTests" ```
>> In case you want to run all tests in project use this command:
```nunit3-console Healenium.Selenium.Tests.dll```

>  If you want to get a Report Portal report you could use this command:
```nunit3-console Healenium.SeleniumRP.Tests.dll --where "class=~MarkupTests" ```
>>Do not forget to specify your rp.uuid and rp.project values in ````ReportPortal.config.json file```
>>>How to configure Report Portal with NUnit you can read here: https://github.com/reportportal/agent-net-nunit


### 4. Monitoring tests running
You can monitor tests running if you using Healenium with Selenoid plus Selenoid Ui, use:
<pre>
    go to <b>http://localhost:8080</b>
</pre>
