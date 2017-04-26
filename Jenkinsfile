pipeline {
  agent any
  stages {
    stage('Build Test') {
      steps {
        git(url: 'https://github.com/QAABTASSOC/AbtFramework.git', branch: 'Master', changelog: true, poll: true, credentialsId: 'Test1')
      }
    }
  }
}