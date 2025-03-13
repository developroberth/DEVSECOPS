# Define the provider
provider "azurerm" {
  features = {}
}

# Resource group
resource "azurerm_resource_groupria" "rg" {
  name     = "microservices-rg"
  location = "East US"
}