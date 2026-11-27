# BIOFIT RUNNER — Proyecto independiente de BIOFIT GAME

**Estado inicial: 27/11/2026 — preparación documental; todavía NO contiene Trash Dash ni un proyecto Unity.** No existe APK ni integración BLE verificada de RUNNER. `main` se conserva como punto de partida.

BIOFIT RUNNER es un videojuego de **exergaming endless runner 3D** para Android: desplazamiento por tres carriles, obstáculos, monedas, saltos y deslizamientos, con futura locomoción en el lugar controlada por dos trackers Waveshare ESP32-S3-LCD-1.47B con IMU QMI8658 y BLE. El smartphone ejecutará Unity. Más adelante podrán sumarse muñecas, joystick y modos de visualización adicionales.

## Leer primero

1. [Relevo operativo vigente](docs/RELEVO_PROYECTO.md): estado real, fuentes de verdad, próximos pasos y pendientes.
2. [Método de trabajo](docs/METODO_DE_TRABAJO.md): seis principios heredados/adaptados de BIOFIT DASH, Git seguro, pruebas y aceptación.
3. [Registro de avances](docs/REGISTRO_AVANCES.md): cambios, evidencias, versiones y limitaciones.
4. [Recursos y licencias](docs/RECURSOS_Y_LICENCIAS.md): origen de Trash Dash y precauciones antes de publicar archivos.

Referencias independientes:
- [BIOFIT DASH](https://github.com/LucianoRodriguezUrquiza/BIOFIT-DASH) — videojuego anterior y fuente de metodología; **no copiar el proyecto entero**.
- [BIOFIT-GAME-Firmware](https://github.com/LucianoRodriguezUrquiza/BIOFIT-GAME-Firmware) — firmware compartido, no se modifica para importar otro juego.
- [Trash Dash: Unity Asset Store](https://assetstore.unity.com/packages/templates/packs/endless-runner-mobile-sample-project-87901) — base prevista del juego; importación local pendiente.
- [Trash Dash: código histórico GitHub](https://github.com/Unity-Technologies/EndlessRunnerSampleGame) — referencia antigua; no mezclar automáticamente con el paquete actual.

## Plan de hitos (propuestos, no realizados)

| Hito | Objetivo | Criterio de aceptación |
|---|---|---|
| R0.1 — Base del juego | Importar edición actual de Trash Dash en proyecto Unity independiente | Consola sin errores bloqueantes y partida funcional en Editor |
| R0.2 — Android | Generar y ejecutar APK | Menús, carriles, saltos, deslizamientos, monedas y obstáculos funcionan en dispositivo |
| R0.3 — Entrada BIOFIT | Integrar receptor BLE sin modificar firmware estable | Dos trackers conectados; recepción y acciones registradas, pruebas Android |
| R0.4 — Locomoción | Investigar STEP/WALK/RUN con los dos tobillos | Ensayos etiquetados y métricas de errores; no confundir candidatos con detección validada |
| R0.5 — Exergaming | Relacionar movimiento real con velocidad y obstáculos | Prueba física reproducible, sin regresiones de salto o carriles |

**Versión prevista para comenzar:** Unity 6.3 LTS, si el paquete actual importa correctamente. Registrar la versión exacta del editor y del paquete tras la primera instalación. No asumir compatibilidad sin una prueba.

## Reglas rápidas

- Trabajar en **un proyecto local de RUNNER**, separado de DASH. Una vez preparado, actualizar con Git y no reinstalar por cada versión.
- `main` solo conserva versiones aceptadas. Desarrollar cambios en ramas acotadas; no fusionar ni borrar ramas sin autorización.
- Agrupar cambios y reducir APK/ensayos físicos repetidos; distinguir CI, Editor, Android y validación IMU.
- Preservar firmware, BLE y parámetros aceptados de DASH. Reutilizar componentes por adaptación controlada, no por copia masiva.
- No subir recursos de Asset Store ni terceros al repositorio público sin verificar los derechos de redistribución.
- Registrar en cada entrega: alcance, archivos modificados, pruebas, resultados y pendientes. No afirmar pruebas no ejecutadas.
