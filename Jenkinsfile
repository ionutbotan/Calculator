pipeline {
    agent any
	stages{
        stage('Build'){
            steps{
                checkout scm
                script {
                    bat "dotnet build Calculator.sln"
                } 
            }
        }
        stage('Test'){
            steps{
                script {
                    bat "dotnet test Calculator.Tests\\Calculator.Tests.csproj -v n"
                } 
            }
        }
    } 
}