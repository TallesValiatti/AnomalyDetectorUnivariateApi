// az group create -n rg-app-eastus -l eastus
// az deployment group create --resource-group rg-app-eastus --template-file main.bicep

// Default Location
param defaultLocation string = resourceGroup().location

var anomalyDetectorName = 'ade-app-${defaultLocation}'

resource anomalyDetectorResource 'Microsoft.CognitiveServices/accounts@2022-12-01' = {
  name: anomalyDetectorName
  location: defaultLocation
  sku: {
    name: 'F0'
  }
  kind: 'AnomalyDetector'
  properties: {
    networkAcls: {
      defaultAction: 'Allow'
      virtualNetworkRules: []
      ipRules: []
    }
    publicNetworkAccess: 'Enabled'
  }
}
