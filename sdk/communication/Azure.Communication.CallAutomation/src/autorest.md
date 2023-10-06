# Azure.Communication.CallAutomation

From Folder that contains autorest.md, Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

```yaml
tag: package-2024-01-22-preview
model-namespace: false

require:
     - https://raw.githubusercontent.com/Azure/azure-rest-api-specs/72311575ea0dc9a6a8a2df57d33cb4381a84821e/specification/communication/data-plane/CallAutomation/readme.md

title: Azure Communication Services

generation1-convenience-client: true

```
