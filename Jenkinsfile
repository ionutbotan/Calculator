pipeline {
    agent any
	stages{
        stage('Build'){
            steps{
                checkout scm
                script {
                    // def msbuild = tool name: 'msbuild'
                    bat "dotnet build Calculator.sln"
                } 
            }
        }
        // stage('Test'){
        //     steps{
        //         script {
        //             // def mstest = tool name: 'mstest'
        //             bat "dotnet test Hello.Tests\\Hello.Tests.csproj -v n"
        //         } 
        //     }
        // }
    } 
}