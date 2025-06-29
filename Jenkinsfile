// Simple Pipeline
// pipeline {
//     agent any
    
//     stages {
// 	    stage ('Checkout') {
// 		    steps { 
// 			    checkout scm
// 		}
// 	}
//         stage('Restore the project') {
//             steps {
//                 sh 'dotnet restore'
//             }
//         }
//         stage('Build the project') {
//             steps {
//                 sh 'dotnet build --no-restore'
//             }
//         }
//         stage('Test the project') {
//             steps {
//                 sh 'dotnet test --no-build --verbosity normal'
//             }
//         }
//     }
// }

// Multibranch pipeline (may require github credentials for jenkins)
pipeline {
    agent any

    stages {

        stage('Checkout') {
            when {
                branch 'main'
            }
            steps {
                checkout scm
            }
        }

        stage('Restore the project') {
            when {
                branch 'main'
            }
            steps {
                sh 'dotnet restore'
            }
        }

        stage('Build the project') {
            when {
                branch 'main'
            }
            steps {
                sh 'dotnet build --no-restore'
            }
        }

        stage('Test the project') {
            when {
                branch 'main'
            }
            steps {
                sh 'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
