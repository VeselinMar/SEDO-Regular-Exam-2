pipeline {
    agent any

    stages {
        stage('Checkout') {
            when {
                expression { env.BRANCH_NAME == 'main' }
            }
            steps {
                checkout scm
            }
        }
        stage('Restore the project') {
            when {
                expression { env.BRANCH_NAME == 'main' }
            }
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Build the project') {
            when {
                expression { env.BRANCH_NAME == 'main' }
            }
            steps {
                sh 'dotnet build --no-restore'
            }
        }
        stage('Test the project') {
            when {
                expression { env.BRANCH_NAME == 'main' }
            }
            steps {
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
