pipeline {
  environment {
    imagename = "godoyq/basicapidotnet"
    registryCredential = 'docker_hub_ssh'
    dockerImage = ''
  }
  agent any
  stages {
    stage('Initialize'){
        steps{
            script{
            def dockerHome = tool 'myDocker'
            env.PATH = "${dockerHome}/bin:${env.PATH}"
            }
        }
    }
    stage('Cloning Git') {
      steps {
        git([url: 'https://github.com/GustavoGodoy/BasicDotNetApi.git', branch: 'main', credentialsId: 'git_ssh_gustavo'])
      }
    }
    stage('Building image') {
      steps{
        script {
          dockerImage = docker.build imagename
        }
      }
    }
    stage('Deploy Image') {
      steps{
        script {
          docker.withRegistry( 'https://hub.docker.com/godoyq', registryCredential ) {
            dockerImage.push("$BUILD_NUMBER")
             dockerImage.push('latest')

          }
        }
      }
    }
  }
}
