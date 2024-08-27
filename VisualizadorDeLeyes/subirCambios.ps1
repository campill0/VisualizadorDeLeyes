# Script PowerShell para actualizar el contenido del repositorio EstudiaLeyes y volver al directorio original

# Configuración
$repoUrl = "https://github.com/campill0/EstudiaLeyes.git"
$branchName = "main"  # Asumimos que es 'main', cambia a 'master' si es necesario
$targetPath = "bin\Release\net8.0\browser-wasm\publish\wwwroot"

# Guardar el directorio original
$originalPath = Get-Location

# Función para ejecutar comandos Git y manejar errores
function Invoke-GitCommand {
    param(
        [string]$command,
        [bool]$allowNonZeroExitCode = $false
    )
    $output = Invoke-Expression "git $command 2>&1"
    if ((-not $allowNonZeroExitCode) -and ($LASTEXITCODE -ne 0)) {
        Write-Error "Error al ejecutar 'git $command': $output"
        Set-Location -Path $originalPath
        exit 1
    }
    Write-Output $output
}

# Obtener la ruta del script actual
$scriptPath = Split-Path -Parent $MyInvocation.MyCommand.Definition

# Construir la ruta completa al directorio objetivo
$fullTargetPath = Join-Path $scriptPath $targetPath

# Navegar a la carpeta correcta
try {
    Set-Location -Path $fullTargetPath -ErrorAction Stop
    Write-Output "Cambiado al directorio: $fullTargetPath"
}
catch {
    Write-Error "No se pudo cambiar al directorio $fullTargetPath. Error: $_"
    Set-Location -Path $originalPath
    exit 1
}

# Verificar si el repositorio ya está inicializado
if (-not (Test-Path ".git")) {
    Invoke-GitCommand "init"
}
else {
    Write-Output "Repositorio Git ya inicializado."
}

# Añadir todos los archivos
Invoke-GitCommand "add ."

# Intentar hacer commit, permitiendo que falle si no hay cambios
$commitOutput = Invoke-GitCommand "commit -m 'Actualización del repositorio EstudiaLeyes'" -allowNonZeroExitCode $true
if ($commitOutput -match "nothing to commit, working tree clean") {
    Write-Output "No hay cambios para hacer commit."
}
else {
    Write-Output "Commit realizado: $commitOutput"
}

# Verificar si el remoto 'origin' ya existe
$remoteExists = git remote | Where-Object {$_ -eq 'origin'}
if ($remoteExists) {
    Write-Output "Actualizando URL del remoto 'origin'..."
    Invoke-GitCommand "remote set-url origin $repoUrl"
}
else {
    Write-Output "Añadiendo remoto 'origin'..."
    Invoke-GitCommand "remote add origin $repoUrl"
}

# Forzar push
Invoke-GitCommand "push -f origin $branchName"

Write-Output "Repositorio EstudiaLeyes actualizado exitosamente."

# Volver al directorio original
Set-Location -Path $originalPath
Write-Output "Volviendo al directorio original: $originalPath"