# .NET Example with Healenium

[![Docker Pulls](https://img.shields.io/docker/pulls/healenium/hlm-backend.svg?maxAge=25920)](https://hub.docker.com/u/healenium)
[![License](https://img.shields.io/badge/license-Apache-brightgreen.svg)](https://www.apache.org/licenses/LICENSE-2.0)

.NET + NUnit + MSBuild project with healenium usage example

[1. Start Healenium components](#1-start-healenium-components)
* [Healenium with Selenoid](#run-healenium-with-selenoid)
* [Healenium with Selenium-Grid](#run-healenium-with-selenium-grid)

[2. Configuration RemoteWebDriver for Healenium](#2-configuration-remotewebdriver-for-healenium)

[3. Run tests](#3-run-tests)

[4. Monitoring tests running](#4-monitoring-tests-running)

## How to start

### 1. Start Healenium components

Go into healenium folder

```sh
cd healenium
``` 

#### Run Healenium with Selenoid:

> Note: `browsers.json` consists of target browsers and appropriate versions.
> Before run healenium you have to manually pull selenoid browser docker images with version specified in browsers.json

Example pull selenoid chrome image:
```sh
docker pull selenoid/vnc:chrome_102.0
```
Full list of browser images you can find [here](https://hub.docker.com/u/selenoid)

Run healenium with Selenoid:
```sh
docker-compose up -d
```

#### Run Healenium with Selenium-Grid:
```sh
docker-compose -f docker-compose-selenium-grid.yaml up -d
```

<b>ATTENTION</b>

Verify the next images are <b>Up</b> and <b>Running</b>
- `postgres-db` (PostgreSQL database to store etalon selector / healing / report)
- `hlm-proxy` (Proxy client request to Selenium server)
- `hlm-backend` (CRUD service)
- `selector imitator` (Convert healed locator to convenient format)
- `selenoid`/`selenium-grid` (Selenium server)

### 2. Configuration RemoteWebDriver for Healenium

To run using Healenium create RemoteWebDriver with URL ```http://<remote webdriver host>:8085```:

```java
    var optionsChrome = new ChromeOptions();
    optionsChrome.AddArguments("--no-sandbox");
    _driver = new RemoteWebDriver(new Uri("http://localhost:8085"), optionsChrome);
```


### 3. Run tests
You can run tests via Test Explorer
To run tests for specified test project in terminal with nunit3-console you need to go to ```/bin/Debug/``` project folder

If you want to execute tests from Healenium.Selenium.Tests project, please use the command: 
```sh
nunit3-console Healenium.Selenium.Tests.dll --where "class=~MarkupTests"
```

In case you want to run all tests in project use this command:
```sh
nunit3-console Healenium.Selenium.Tests.dll
```

If you want to get a Report Portal report you could use this command:
```sh
nunit3-console Healenium.SeleniumRP.Tests.dll --where "class=~MarkupTests"
```

>Do not forget to specify your rp.uuid and rp.project values in `ReportPortal.config.json` file
> 
>How to configure Report Portal with NUnit you can read here: https://github.com/reportportal/agent-net-nunit


### 4. Monitoring tests running

You can monitor tests running if you using Healenium with Selenoid plus Selenoid Ui, go to :<br/>
```sh
http://localhost:8080
```

## Community / Support

* [Telegram chat](https://t.me/healenium)
* [YouTube Channel](https://www.youtube.com/channel/UCsZJ0ri-Hp7IA1A6Fgi4Hvg)
