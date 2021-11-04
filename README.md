# healenium
.NET + NUnit + MSBuild project with healenium usage example 

## How to start
### 1.Start Healenium backend from 'infra' folder

```cd infra```

```docker-compose up -d```

Verify that images ```healenium/hlm-backend```, ```postgres:11-alpine```, ```healenium/hlm-selector-imitator:1```, ```healenium/hlm-selenium-4-standalone-xpra``` and ```healenium/hlm-proxy``` are up and running

### 2. Project structure
```
|__Healenium.NET solution
   |__src
      |__Healenium.Selenium
         |__pages
   |__tests
      |__Healenium.Selenium.Tests
         |__tests
            |__selenium tests
      |__Healenium.SeleniumRP.Tests
         |__tests
            |__selenium RP tests
         |__ReportPortal.config.json
      |__Healenium.Selenoid.Tests
         |__tests
            |__selenoid tests
   |__infra
      |__docker-compose.yml

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
You can monitor tests running
To do this go to ```http://<remote webdriver host>:8086```
