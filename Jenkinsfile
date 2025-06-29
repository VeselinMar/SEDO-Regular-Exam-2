pipeline {
    agent any

    stages {
        stage('Run CI on main') {
            when {
                branch 'main'
            }

            stages {
                stage('Checkout') {
                    steps {
                        checkout scm
                    }
                }

                stage('Restore') {
                    steps {
                        sh 'dotnet restore'
                    }
                }

                stage('Build') {
                    steps {
                        sh 'dotnet build --no-restore --configuration Release'
                    }
                }

                stage('Test') {
                    steps {
                        sh 'dotnet test --no-build --configuration Release --verbosity normal'
                    }
                }
            }
        }
    }
}