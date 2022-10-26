pipeline {
    agent any

    stages {
         stage('Restoring the packeges') {
            steps {
                echo 'Restoring..'
                bat "dotnet restore"
            }
        }
        stage('Build') {
            steps {
                echo 'Building..'
                bat "dotnet build --configuration Release"
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
