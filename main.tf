# Define the provider
provider "azurerm" {
  features = {}
}

# Resource group
resource "azurerm_resource_group" "rg" {
  name     = "devsecops-rg-ria"
  location = "East US"
}
