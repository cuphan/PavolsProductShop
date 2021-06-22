pipeline {
  agent { node { label 'linux-slave-1' } }

  environment {
    dotnet = '/usr/bin/dotnet'
  }

  stages {
    stage('Checkout') {
      steps {
        checkout scm
      }
    }

    stage('Restore') {
      steps {
        sh "$dotnet restore"
      }
    }

    stage('Clean') {
      steps {
        sh "$dotnet clean"
      }
    }

    stage('Build Production') {
      when {
        branch 'main'
      }
      steps {
        sh "$dotnet build --configuration Production"
      }
    }

    stage('Build Test') {
      when {
        branch 'test'
      }
      steps {
        sh "$dotnet build --configuration Test"
      }
    }

    stage('Build') {
      steps {
        sh "$dotnet build --configuration Release"
      }
    }
  }
}