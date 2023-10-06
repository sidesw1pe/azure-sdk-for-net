# Azure.Communication.CallAutomation

From Folder that contains autorest.md, Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

```yaml
tag: package-2024-01-22-preview
model-namespace: false

require:
     - https://raw.githubusercontent.com/Azure/azure-rest-api-specs/32dcbdeb8ab9fce338116cf5f5b44c38bb92c480/specification/communication/data-plane/CallAutomation/readme.md

title: Azure Communication Services

generation1-convenience-client: true

```
