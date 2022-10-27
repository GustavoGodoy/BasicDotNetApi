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
          sh "docker run -v /var/run/docker.sock:/var/run/docker.sock"
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
          docker.withRegistry( '', registryCredential ) {
            dockerImage.push("$BUILD_NUMBER")
             dockerImage.push('latest')

          }
        }
      }
    }
    stage('Remove Unused docker image') {
      steps{
        sh "docker rmi $imagename:$BUILD_NUMBER"
         sh "docker rmi $imagename:latest"
      }
    }
  }
}
