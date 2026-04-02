param(
    [string]$Configuration = "Release"
)

$ErrorActionPreference = "Stop"

$root = Split-Path -Parent $PSScriptRoot
$project = Join-Path $root "src\G8.PosDemo.Web\G8.PosDemo.Web.csproj"
$output = Join-Path $root "publish\G8.PosDemo.Web"

Write-Host "Publishing G8.PosDemo.Web..." -ForegroundColor Cyan
Write-Host "Project: $project"
Write-Host "Output : $output"

if (Test-Path $output) {
    Remove-Item $output -Recurse -Force
}

& dotnet publish $project -c $Configuration -o $output

Write-Host ""
Write-Host "Publish complete." -ForegroundColor Green
Write-Host "Output folder: $output"
