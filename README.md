# healenium
.NET + NUnit + MSBuild project with healenium usage example 

## How to start
### 1.Start Healenium backend from 'infra' folder

```cd infra```

```docker-compose up -d```

To download this file into your project use this command:

```$ curl https://raw.githubusercontent.com/healenium/healenium-example-dotnet/master/infra/docker-compose.yml -o docker-compose.yml```

Create /db/sql folder on the same level in your project. Add init.sql file into ```./db/sql/init.sql``` folder in your project via command:

```$ curl https://raw.githubusercontent.com/healenium/healenium-client/master/example/init.sql -o init.sql```

Verify that images ```healenium/hlm-backend:3.2.2```, ```postgres:14.2-bullseye```, ```healenium/hlm-selector-imitator```, ```healenium/hlm-selenoid``` and ```healenium/hlm-proxy:0.2.5.2``` are up and running

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
To do this go to ```http://localhost:8080```
