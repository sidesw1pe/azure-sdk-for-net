# Azure.Communication.CallAutomation

From Folder that contains autorest.md, Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

```yaml
tag: package-2024-01-22-preview
model-namespace: false

require:
     - https://raw.githubusercontent.com/Azure/azure-rest-api-specs/69f49579e23dc77495a219588f98e9697ead6506/specification/communication/data-plane/CallAutomation/readme.md

title: Azure Communication Services

generation1-convenience-client: true

```
