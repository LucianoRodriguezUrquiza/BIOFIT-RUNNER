# BIOFIT RUNNER — Incorporación de Trash Dash (28/11/2026)

## Qué se verificó
- Unity publica **Endless Runner | Mobile Sample Project (Trash Dash)** versión **2.0.0**, fecha 21/09/2026, EULA de Unity Asset Store. La ficha declara compatibilidad con **Unity 6000.3 URP**.
- El [repositorio GitHub histórico](https://github.com/Unity-Technologies/EndlessRunnerSampleGame) es un proyecto **Unity 2019.3**, con Git LFS. En `Assets/EndlessRunner_Third-PartyNotice.txt` el propio autor indica Asset Store EULA, con licencia Apache 2.0 para la fuente Luckiest Guy.
- Solo se incorporó un **git submodule** fijado al upstream histórico; no se subieron archivos originales a nuestro Git público.

## Recomendación — conservar el juego que ya funcione en la PC
Si ya tenés Trash Dash importado y jugable en Unity, **no lo reinstales ni lo reemplaces**. Identificá su carpeta de proyecto (contiene `Assets/`, `Packages/`, `ProjectSettings/`) y verificá si tiene un repositorio Git antes de tocarlo:
```powershell
cd "RUTA_REAL_DE_TU_PROYECTO_TRASH_DASH"
git status
```
Si dice `not a git repository`, la carpeta no está conectada; se puede vincular a BIOFIT-RUNNER una sola vez **después de revisar qué archivos locales deben conservarse**. No correr una secuencia de Git destructiva ni agregar todo sin revisar.

## Si todavía no existe un proyecto local
1. En Unity Hub, crear **un proyecto nuevo** con Unity 6.3 LTS y plantilla **Universal 3D (URP)**. Crear una sola carpeta para RUNNER.
2. Abrir el Editor y descargar **Endless Runner | Mobile Sample Project** desde `Window > Package Manager > My Assets` con la cuenta que tiene la licencia. Importar el paquete.
3. Abrir la escena de inicio indicada por el paquete **instalado**. No asumir los mismos nombres de escena que la versión GitHub 2019.
4. Ejecutar el juego en **Play** y verificar carriles, salto, slide, obstáculos, monedas, menú y errores de Console.
5. Registrar versión exacta de Editor/paquete y estructura de carpetas. **No generar APK antes de que el Editor funcione.**

## Incorporar las mejoras BIOFIT del repositorio
La carpeta `Assets/BIOFIT-RUNNER/` contiene scripts propios que no dependen de las clases internas de Trash Dash. Primero se conecta el proyecto local al repositorio público o se incorpora esa carpeta **sin sobreescribir** recursos importados. Al vincular Git, preservar todos los archivos existentes y revisar el estado.

El script `BiofitRunnerInputBridge` permite invocar acciones semánticas `LEFT/RIGHT/JUMP/SLIDE`. Su componente expone eventos para asociar en el Inspector con métodos del controlador del juego; **no está conectado a Trash Dash hasta realizar esa configuración y probarla en Unity**.

En la **versión histórica** el controlador `CharacterInputController` expone `ChangeLane(int)`, `Jump()` y `Slide()`; no se garantiza que el paquete 2.0.0 tenga la misma API sin inspección de los archivos locales.

### Referencia histórica (opcional, no necesaria para Unity 6.3)
Si querés inspeccionar la fuente antigua vinculada, con Git LFS instalado:
```powershell
git lfs install
git submodule update --init ThirdParty/TrashDash-Upstream
git -C ThirdParty/TrashDash-Upstream lfs pull
```
Esa carpeta es un proyecto distinto (Unity 2019.3) y **no debe abrirse como si fuera la versión 2.0.0 ni mezclarse automáticamente en Assets**.

## Git público y assets protegidos
El `.gitignore` del repositorio protege por defecto todo `Assets/` salvo `Assets/BIOFIT-RUNNER/` y sus metadatos. De esta forma, el paquete Asset Store sigue **en la copia local** y no aparece en el staging por accidente. Esto no sustituye la inspección de cada archivo: otros recursos de terceros ubicados fuera de `Assets/` también deben revisarse. No ejecutar `git add .` sin revisar.

Si más adelante se quiere que Git contenga el proyecto Unity con los assets completos editables, la alternativa es **un repositorio privado** con acceso limitado a usuarios licenciados, previa revisión del EULA. No cambiar la visibilidad del repositorio sin autorización.

## Siguiente validación R0.1
- Proyecto Unity existente e identificado;
- edición exacta de Trash Dash instalada;
- Play funciona sin errores bloqueantes;
- se conoce la escena y el controlador real de esa edición;
- `git status` confirma protección de recursos externos.

**Aún no se ejecutó una compilación Unity ni APK de este repositorio.**
