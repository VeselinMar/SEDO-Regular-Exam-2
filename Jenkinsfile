pipeline {
    agent any

    when {
        branch 'main'
    }

    stages {
	    stage ('Checkout') {
		    steps { 
			    checkout scm
		}
	}
        stage('Restore the project') {
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Build the project') {
            steps {
                sh 'dotnet build --no-restore'
            }
        }
        stage('Test the project') {
            steps {
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
