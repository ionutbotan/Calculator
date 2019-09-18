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
        //dotnet publish -c Release -r win10-x64
        stage('Test'){
            steps{
                script {
                    bat "dotnet test Calculator.Tests\\Calculator.Tests.csproj -v n"
                } 
            }
        }
        stage('Deploy'){
            steps{
                script {
                    bat "dotnet publish -c Release -r win10-x64"
                } 
            }
        }
    } 
}