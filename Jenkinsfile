pipeline {
    agent any

    tools { 
        "org.jenkinsci.plugins.terraform.TerraformInstallation" "terraform"
    }

    environment {
        ARM = credentials('b8989b85-3121-4662-bea6-7d41277deba9')
        ARM_ACCESS_KEY = credentials('37b62107-d4a3-430b-beaf-3cc32187d553')
        DB_ADMIN = credentials('2e8b7929-7c59-4b33-ba4f-b2bcc40f173b')
    }

    stages {
        // stage('Install Dependencies') {
        //     steps {
        //         script {
        //             sh 'dotnet restore LeaveManagement.web/LeaveManagement.web.csproj'
        //         }
        //     }
        // }

        // stage('Build') {
        //     steps {
        //         script {
        //             sh 'dotnet build LeaveManagement.web/LeaveManagement.web.csproj'
        //         }
        //     }
        // }

        // stage('Terraform Setup') {
        //     steps {
        //         script {
        //             sh '''
        //                 terraform init -input=false -backend-config="access_key=$ARM_ACCESS_KEY" -var "client_id=$ARM_CLIENT_ID" -var "client_secret=$ARM_CLIENT_SECRET" -var "subscription_id=$ARM_SUBSCRIPTION_ID" -var "tenant_id=$ARM_TENANT_ID" -var "sql_admin_login=$DB_ADMIN_USR" -var "sql_admin_password=$DB_ADMIN_PSW"
        //             '''
        //         }
        //     }
        // }

        // stage('Terraform Apply') {
        //     steps {
        //         script {
        //             sh 'terraform apply -input=false -auto-approve -var "client_id=$ARM_CLIENT_ID" -var "client_secret=$ARM_CLIENT_SECRET" -var "subscription_id=$ARM_SUBSCRIPTION_ID" -var "tenant_id=$ARM_TENANT_ID" -var "sql_admin_login=$DB_ADMIN_USR" -var "sql_admin_password=$DB_ADMIN_PSW"'
        //         }
        //     }
        // }

        stage('Update Database') {
            steps {
                script {
                    sh '''
                        echo $(dotnet ef --version)
                        connectionString=$(terraform output -json connection_string | jq -r ".[0].value")
                        dotnet ef database update --connection "$connectionString" --project LeaveManagement.web/LeaveManagement.web.csproj
                    '''
                }
            }
        }

        // stage('Docker Build') {
        //     steps {
        //         script {
        //             sh 'docker build -t alabenhmouda/leave-management .'
        //         }
        //     }
        // }

        // stage('Docker Push') {
        //     steps {
        //         withCredentials([usernamePassword(credentialsId: 'cfcabbf3-82d8-40f5-9311-983452136145', usernameVariable: 'DOCKERUSER', passwordVariable: 'DOCKERPASS')]) {
        //             sh 'docker login -u $DOCKERUSER -p $DOCKERPASS'
        //             sh 'docker push alabenhmouda/leave-management'
        //         }
        //     }
        // }

        // stage('Azure Deploy') {
        //     steps {
        //         script {
        //             sh 'az login --service-principal -u $ARM_CLIENT_ID -p $ARM_CLIENT_SECRET --tenant $ARM_TENANT_ID'
        //             sh 'az webapp create --resource-group leave-management-rg --plan leave-management-app-service-plan --name leave-management-app-service --deployment-container-image-name alabenhmouda/leave-management'
        //         }
        //     }
        // }

        stage('Cleanup') {
            steps {
                script {
                    cleanWs()
                }
            }
        }
    }

    post {
        success {
            echo 'Build and tests passed'
        }
        failure {
            echo 'Build or tests failed. Take necessary actions.'
        }
    }
}
