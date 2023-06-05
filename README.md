# Oracle Cloud Infrastructure SDK for .NET

## About

The oci-dotnet-sdk provides an SDK for .NET that you can use to manage your Oracle Cloud Infrastructure resources.

The project is open source and maintained by Oracle Corp.

## Open in Code Editor:

Open the repository in OCI Code Editor: [![Open in Code Editor](https://github.com/hyddel/oci-dotnet-sdk/blob/main/ccl-image-3.png?raw=true)](https://cloud.oracle.com/?region=us-ashburn-1&configoverride={"plugins":{"cloudshell":{"name":"cloudshell","path":"/cloudshell","url":"https://cloud-staging.oracle.com/plugins/cloudshell/latest/staging-oc1-index.tpl.html?cloudshellBackend=dev","type":"Sandbox"}},"features":{"code-editor":true,"cloudshellBackend":"dev","cse-enabled":"true"}}&tenant=bmc_operator_access&provider=ocna-saml&override_tenant=ocid1.tenancy.oc1..aaaaaaaau2kvkmgovgfzrfnuhh47x3kxmtkuqe6hzsfby5yst2hhr5comnda&cs_repo_url=https://github.com/hyddel/oci-dotnet-sdk.git&cs_open_ce=true&cs_readme_path=README.md&cs_branch=main&cs_initscript_path=run-audit-example.sh)

## Open in Code Editor:(uses Fahd's team tenancy)

Open the repository in OCI Code Editor: [![Open in Code Editor](https://github.com/hyddel/oci-dotnet-sdk/blob/main/ccl-image-3.png?raw=true)](https://cloud.oracle.com/?region=us-ashburn-1&configoverride={"plugins":{"cloudshell":{"name":"cloudshell","path":"/cloudshell","url":"https://cloud-staging.oracle.com/plugins/cloudshell/latest/staging-oc1-index.tpl.html?cloudshellBackend=dev","type":"Sandbox"}},"features":{"code-editor":true,"cloudshellBackend":"dev","cse-enabled":"true"}}&tenant=bmc_operator_access&provider=ocna-saml&override_tenant=ocid1.tenancy.oc1..aaaaaaaasu7rvefmsyk5kqczfmdqi5clpddejfjk2attdqnk6sbk72wajq5q&cs_repo_url=https://github.com/hyddel/oci-dotnet-sdk.git&cs_open_ce=true&cs_readme_path=README.md&cs_branch=main&cs_initscript_path=run-audit-example.sh)

## Dependencies

- [.NETStandard 2.0](https://dotnet.microsoft.com/platform/dotnet-standard)

## SDK Organization

The oci-dotnet-sdk contain the following 3 groups of packages:

- **Common package**: Found in the [Common](/Common) and [Commontests](/Commontests) (unit tests for common package) directories.
  The common package provides supporting classes and methods used by service packages.
  It includes HTTP request/response (de)serialization, request signing, JSON parsing, and other helper functions.
  Most of the functions in this package are meant to be used by the service packages.
- **Examples package**: Found in the [Examples](/Examples) directory. It includes some working examples on how to use
  oci-dotnet-sdk to manage Oracle Cloud Infrastracture resources.
- **Service packages**: All packages except [Common](/Common), [Commontests](/Commontests), and [Examples](/Examples). These packages represent
  the Oracle Cloud Infrastructure services supported by the .NET SDK. Each package represents a service.
  These packages include the service client(s) with methods to interact with the service, classes for the requests,
  responses, and input and output parameters.

## Install Packages

The SDK is published as Nuget packages.

Use either dotnet CLI or Visual Studio to install and consume a package from [nuget.org](https://www.nuget.org/profiles/oci-dotnet-sdk).

- **dotnet CLI**:

```
dotnet add package <PACKAGE_ID> --version <VERSION> (If version not specified then it pulls the latest version)

Example:
dotnet add package OCI.DotNetSDK.Core (Installs the latest version of the Core Service package)
dotnet add package OCI.DotNetSDK.Identity -v 1.0.0 (Installs version 1.0.0 of the Identity Service package)

NOTE: To avoid dependency conflicts, you should use the same versions of all OCI .NET SDK Nuget packages within an application.
```

- **Visual Studio**:
  Right-click a project and select "Manage Nuget Packages" and then search for the package name and version number to install.

## Documentation

Public documentation and API Reference for the sdk can be found [here](https://docs.cloud.oracle.com/en-us/iaas/Content/API/SDKDocs/dotnetsdk.htm).

## Working with the .NET SDK

To start working with oci-dotnet-sdk, you need to create a .NET project, install packages, create a client, and then use that client to send requests to service endpoint.

### Configuring

Before using the SDK, set up a config file with the required credentials. See [SDK and Tool Configuration](https://docs.us-phoenix-1.oraclecloud.com/Content/API/Concepts/sdkconfig.htm) for instructions.

### Creating Client

To create a service client, you need to set up the client to use the credentials.
Check [here](https://docs.cloud.oracle.com/en-us/iaas/Content/API/SDKDocs/dotnetsdkgettingstarted.htm#configuring) on how to configure it.

Example that shows creating the Audit Service client using ConfigFileAuthenticationDetailsProvider Class for configuring credentials:

```
var provider = new ConfigFileAuthenticationDetailsProvider("DEFAULT");
var client = new AuditClient(provider, new ClientConfiguration());
```

### Sending Request

To send a request to an Oracle Cloud Infrastructure service endpoint, build a request object and send it using the client created above.

```
var listEventsRequest = new ListEventsRequest
{
    // Assumption: the compartment id has been set in environment variable.
    CompartmentId = compartmentId,
    StartTime = DateTime.Now.AddDays(-1),
    EndTime = DateTime.Now
};

try
{
    var response = await client.ListEvents(listEventsRequest);
}
catch (Exception e)
{
    // Handle the exception.
}
```

### Enable Logging

NLog package is used for logging in .NET projects. This package gets auto-installed as a dependency when you install OCI .NET SDK package. In order to view .NET SDK logs, you will need to:

* Add NLog.config file at the project root directory. A sample NLog.config file can be found [here](https://github.com/NLog/NLog/wiki/Configuration-file#nlog-config-xml).
* Add ItemGroup section in the project file:
```
<ItemGroup>
     <Content Include="PATH TO NLog.config File" >
          <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
     </Content>
</ItemGroup>
```
* To enable logging in user application, create a logger:
```
var logger = NLog.LogManager.GetCurrentClassLogger();
logger.Info("Hello World");
```
---
**NOTE**

Only SDK logging will be captured if logger is not created in user application.

---

## Examples

Examples can be found [here](/Examples).

Examples for all supported services can be found at the [API reference](https://docs.cloud.oracle.com/en-us/iaas/tools/dotnet/latest/api/index.html) under their respective reference doc.

To use the example code: copy the sample, change the parameter values to values that make sense for your use case (ex: OCI instance ID with your OCI instance ID), and then you can run the code to have a working automation against OCI.


## Building and Testing

### Build

Building the SDK can be done at the root of the whole solution or at individual project level under it.
At the root level, to build the whole solution, run with dotnet cli command:

```
dotnet build
```

or use the included Makefile:

```
make build
```

The Makefile also provides an option to build individal projects from the root level:

```
make build PROJECT_PATH=Common
```

Alternatively, individual project and be built using dotnet cli inside project directory.

### Test

The common package has corresponding [unit tests](/Commontests).
These tests can be run using dotnet cli command or through Makefile.
To run the unit tests from the root, a test filter needs to be provided:

```
dotnet test --filter Category=Unit
```

Alternatively, running tests inside common_tests project does not require the filter.
To run tests using Makefile:

```
make unit-test
```

## Help

* The [Issues](https://github.com/oracle/oci-dotnet-sdk/issues) page of this GitHub repository.
* [Stack Overflow](https://stackoverflow.com/), use the [oracle-cloud-infrastructure](https://stackoverflow.com/questions/tagged/oracle-cloud-infrastructure) and [oci-dotnet-sdk](https://stackoverflow.com/questions/tagged/oci-dotnet-sdk) tags in your post.
* [Developer Tools](https://community.oracle.com/community/groundbreakers/oracle-cloud/cloud-infrastructure/content) section of the Oracle Cloud forums.
* [My Oracle Support](https://support.oracle.com/portal/).

## Contributing

`oci-dotnet-sdk` is an open source project. See [CONTRIBUTING](/CONTRIBUTING.md) for details.

Oracle gratefully acknowledges the contributions to oci-dotnet-sdk that have been made by the community.

## License

Copyright (c) 2020, 2021 Oracle and/or its affiliates. All rights reserved.

This SDK is dual licensed under the Universal Permissive License 1.0 and the Apache License 2.0.

See [LICENSE](/LICENSE.txt) for more details.

## Changes

See [CHANGELOG](/CHANGELOG.md)

## Known Issues

You can find information on any known issues with the SDK at [Oracle Cloud Infrastructure Known Issues](https://docs.cloud.oracle.com/en-us/iaas/Content/knownissues.htm) and under the [Issues](https://github.com/oracle/oci-dotnet-sdk/issues) tab of this project's GitHub repository.
