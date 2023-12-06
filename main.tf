terraform {
    required_providers  {
        azurerm =   {
            source  =   "hashicorp/azurerm"
        }
    }
    backend "azurerm" {
        resource_group_name  = "tfstate"
        storage_account_name = "tfstate10403"
        container_name       = "tfstate"
        key                  = "leave-management.tfstate"
    }
}

provider "azurerm" {
  client_id       =   var.client_id
  client_secret   =   var.client_secret
  subscription_id =   var.subscription_id
  tenant_id       =   var.tenant_id

  features {}
}

resource "azurerm_resource_group" "resource_group" {
  name     = "leave-management-rg"
  location = "westeurope"
}

resource "azurerm_service_plan" "app_service_plan" {
  name                = "leave-management-app-service-plan"
  location            = azurerm_resource_group.resource_group.location
  resource_group_name = azurerm_resource_group.resource_group.name
  os_type             = "Linux"
  sku_name            = "B1"
}

resource "azurerm_linux_web_app" "web_app" {
  name                = "leave-management-app-service"
  location            = azurerm_resource_group.resource_group.location
  resource_group_name = azurerm_resource_group.resource_group.name
  service_plan_id = azurerm_service_plan.app_service_plan.id

  site_config {
    always_on = true
  }

  connection_string {
    name  = "DefaultConnection"
    type  = "SQLAzure"
    value = "Server=tcp:azurerm_mssql_server.sql.fully_qualified_domain_name;Database=azurerm_mssql_database.db.name;User ID=azurerm_mssql_server.sql.administrator_login;Password=azurerm_mssql_server.sql.administrator_login_password;Trusted_Connection=False;Encrypt=True;"
  }
}

resource "azurerm_mssql_server" "sql" {
  name                         = "leave-management-sql-server"
  resource_group_name          = azurerm_resource_group.resource_group.name
  location                     = azurerm_resource_group.resource_group.location
  Version                      = "12.0"
  administrator_login          = var.sql_admin_login
  administrator_login_password = var.sql_admin_password
}

resource "azurerm_mssql_database" "db" {
  name           = "leave-management-sql-db"
  server_id      = azurerm_mssql_server.sql.id
  collation      = "SQL_Latin1_General_CP1_CI_AS"
  license_type   = "LicenseIncluded"
  sku_name       = "S0"
  zone_redundant = false
}
