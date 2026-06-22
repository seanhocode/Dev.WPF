<#
.SYNOPSIS
建立一個包含 WPF 專案的 .NET 方案

.DESCRIPTION
此腳本會在指定的路徑下建立一個新的 .NET 方案

.PARAMETER ProjectPath
方案的根目錄路徑
.PARAMETER FirstProjectName
第一個 WPF 專案的名稱
.PARAMETER SolutionName
方案的名稱
.PARAMETER Framework
WPF 專案使用的 .NET 框架版本

.EXAMPLE
. 'C:\Code\Dev.WPF\Script\CreateWPFSolution.ps1'
#>

param (
    [string]$ProjectPath = "C:\Code\Dev.WPF",
    [string]$FirstProjectName = "Example",`
    [string]$SolutionName = "Dev.WPF",
    [string]$Framework = "net8.0"
)

New-Item -ItemType Directory -Force -Path $ProjectPath | Out-Null
Set-Location -Path $ProjectPath

Write-Host "Create solution: $SolutionName.sln"
dotnet new sln -n $SolutionName --format sln

$SrcDir = Join-Path $ProjectPath "Src"
New-Item -ItemType Directory -Force -Path $SrcDir | Out-Null

Write-Host "Create WPF project in Src directory: $FirstProjectName ($Framework)"
$FirstProjectDir = Join-Path $SrcDir $FirstProjectName
dotnet new wpf -n $FirstProjectName -o $FirstProjectDir -f $Framework

Write-Host "Add project to solution..."
$ProjectFile = Join-Path $FirstProjectDir "$FirstProjectName.csproj"
dotnet sln add $ProjectFile

Write-Host "Operation completed. Solution path: $ProjectPath"