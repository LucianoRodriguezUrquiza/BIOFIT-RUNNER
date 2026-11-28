# BIOFIT RUNNER — Relevo operativo vigente

**Actualización: 27/11/2026.** Este documento es el punto de entrada en nuevas conversaciones sobre RUNNER. Leer primero [README](../README.md), [Método de trabajo](METODO_DE_TRABAJO.md) y después los archivos específicos del cambio. Las notas históricas no reemplazan el estado actual. Verificar en GitHub los HEAD y ramas reales antes de actuar.

## 1. Decisión del usuario y propósito
- Juego elegido: **Trash Dash**, como base para un Endless Runner 3D Android con tres carriles, obstáculos, monedas, saltos y deslizamientos.
- Repositorio propio: https://github.com/LucianoRodriguezUrquiza/BIOFIT-RUNNER.
- Independiente de https://github.com/LucianoRodriguezUrquiza/BIOFIT-DASH; no se crea una rama perpetua de DASH ni se copia su proyecto.
- Firmware común en https://github.com/LucianoRodriguezUrquiza/BIOFIT-GAME-Firmware; no reflashear por iniciar RUNNER.
- Meta futura: dos tobillos Waveshare QMI8658, BLE, reconocer caminar/correr en el lugar y luego combinar marcha con saltos/cambios de carril. Joystick/muñecas/VR no forman parte del primer hito.

## 2. Estado verificado
- En `main`, al iniciar este trabajo, solo existían `README.md` y `.gitignore`. No hay carpeta `Assets/`, `Packages/` ni `ProjectSettings/`; no afirmar que el juego fue importado.
- No existe, según estos archivos, una APK Runner construida ni validación de BLE/IMU.
- Se propone la edición actual de Trash Dash desde Unity Asset Store; el repositorio histórico de Unity en GitHub corresponde a otra generación del proyecto. **No mezclar** ambas distribuciones sin comprobar compatibilidad.
- Unity inicial previsto: 6.3 LTS, versión exacta y soporte real pendientes de instalación y prueba.
- Este hito solo fija el método de trabajo, sin modificar DASH, firmware, escenas o activos del juego.

## 3. Arquitectura prevista, no implementada
```text
Tracker izq. + Tracker der. (QMI8658/ESP32-S3)
                 | BLE
                 v
    Receptor Android / capa BIOFIT
                 |
       Eventos y clasificación
    STEP / WALK / RUN / JUMP / ...
                 |
         Adaptador de control
                 |
        Trash Dash en Unity
```
- Priorizar recepción correcta, trazabilidad por tracker y sincronización temporal.
- Mantener separado el significado físico del movimiento y las acciones del juego.
- No asumir que `BiofitInputEngine` de DASH ya detecta STEP/WALK/RUN con calidad validada; revisar código y evidencia antes de trasladar.
- Tratar el salto bilateral como función previamente desarrollada en DASH, sin alterar sus parámetros por defecto.

## 4. Próximo lote recomendado
**R0.1 — Base del juego en Editor:** obtener Trash Dash desde la cuenta del usuario, importar en **un proyecto local nuevo e independiente**, documentar versión del paquete y Unity, ejecutar partida original, registrar errores y dependencias. Sin sensores, sin modificaciones estéticas ni nuevas APK si el Editor falla.

**R0.2 — Android original:** después de aprobar R0.1, generar e instalar una APK, verificar controles táctiles, escenario infinito, obstáculos, UI, audio y rendimiento.

**R0.3 — Receptor BLE:** sólo después de una base jugable; reutilización selectiva y sin regresión de firmware.

## 5. Regla de sincronización
- Una vez fijada la ruta real de RUNNER, preservar esa instalación; Unity cerrado antes de Git.
- `git status`, `git branch --show-current`, `git log -1 --oneline`, `git fetch origin`; `git pull --ff-only` únicamente si no hay conflictos y la rama es la esperada.
- No subir a GitHub público assets de Asset Store, audio, animaciones ni modelos sin comprobar la licencia. `.gitignore` general de Unity **no** protege automáticamente esos archivos.
- No hacer merges, resets ni limpieza destructiva sin autorización. Versiones aceptadas van a `main`.

## 6. Evidencias / límites
- Documentación revisada: `BIOFIT-DASH/docs/RELEVO_PROYECTO.md`, `CRITERIOS_DE_TRABAJO_BIOFIT_GAME.md`, `CONTEXTO_VIVO.md`, `CONSOLIDACION_V66.md` y `.github/workflows/latency-regression.yml`.
- V6.6 de DASH fue aceptada por el usuario en Unity/Android; esto **no** acredita que Runner funcione.
- No hay todavía compilación ni prueba de RUNNER. El repositorio no contiene los archivos del proyecto Trash Dash.

## 7. Cómo documentar cada avance
Registrar en [REGISTRO_AVANCES.md](REGISTRO_AVANCES.md): fecha, rama y SHA, archivos cambiados, comportamiento antes/después, pruebas efectivas, pruebas pendientes, recursos externos y decisión de aceptación. Mantener el método ICC/DIPL/RFD/BRO/FLM/RCA de [METODO_DE_TRABAJO.md](METODO_DE_TRABAJO.md).

## Incorporación inicial de Trash Dash — 28/11/2026
- Rama de trabajo: `feat/trash-dash-bootstrap` (propuesta sin merge a main).
- Referencia Git upstream oficial **fijada** a `8a11421d45637c1565508c55548b959a1a58ace8` en `ThirdParty/TrashDash-Upstream`. Es un submódulo (no copia). Unity 2019.3; requiere Git LFS si se descarga el contenido.
- Versión preferida del usuario: Asset Store **2.0.0**, Unity 6.3 URP; **no disponible en el repositorio GitHub histórico**. Importación desde la cuenta del usuario pendiente y no ejecutada.
- Código nuevo propio `Assets/BIOFIT-RUNNER/Scripts/BiofitRunnerInputBridge.cs` preparado; necesita cableado al controlador real y prueba en Unity. No incorpora BLE todavía.
- El repo es público: el paquete completo de Asset Store no se puede republicar aquí por defecto. Política de exclusión `Assets/` aplicada salvo código propio.
- Próxima acción: **usar el proyecto local Trash Dash que ya esté funcionando** si existe; no reinstalar. Registrar la estructura real y comprobar la consola de Unity.
- No hay APK, editor ni hardware validados de Runner. No hay cambios en DASH/Firmware.
