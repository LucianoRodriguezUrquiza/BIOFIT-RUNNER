# BIOFIT RUNNER — Registro continuo de avances (RCA)

No se reemplaza esta bitácora por mensajes de chat. Las entregas deberán identificar claramente qué fue **verificado** y qué sigue **pendiente**.

## 2026-11-27 — Inicialización del método de desarrollo

- **Petición:** tomar el modelo de trabajo de `BIOFIT-DASH` como referencia permanente para `BIOFIT-RUNNER`.
- **Base observada:** repositorio RUNNER con `README.md` y `.gitignore` únicamente en `main`, sin proyecto Unity.
- **Rama de propuesta documental:** `docs/modelo-trabajo-dash`; no cambiar `main` antes de aprobación.
- **Alcance:** documentación de objetivo, estados, procedimiento incremental, seis principios, licencias y relevo.
- **Archivos:** `README.md`, `docs/METODO_DE_TRABAJO.md`, `docs/RELEVO_PROYECTO.md`, `docs/REGISTRO_AVANCES.md`, `docs/RECURSOS_Y_LICENCIAS.md`, `.github/PULL_REQUEST_TEMPLATE.md`.
- **Fuente:** metodología y registros de validación consultados directamente en BIOFIT-DASH (README, RELEVO, CRITERIOS, CONSOLIDACION, CONTEXTO_VIVO, CI).
- **Pruebas:** lectura del repositorio; verificaciones de existencia de archivos y ramas. No se ejecutó Unity, Android ni BLE.
- **No alterado:** juego DASH, firmware ESP32, parámetros de saltos, escenas, modelos, APK, recursos de terceros.
- **Pendiente:** aprobación de la propuesta documental; importación real de Trash Dash en proyecto local independiente, confirmación de licencias y primeras pruebas en Editor.

## 2026-11-28 — Preparación técnica de Trash Dash (R0.0)

- **Objetivo:** iniciar montaje de Trash Dash en Runner conservando licencias y metodología DASH.
- **Rama:** `feat/trash-dash-bootstrap`, base `docs/modelo-trabajo-dash`.
- **Fuente original:** Unity-Technologies/EndlessRunnerSampleGame, commit fijado `8a11421d45637c1565508c55548b959a1a58ace8`, Git LFS, Unity 2019.3.
- **Contenido:** git submodule como referencia, documentación de instalación de Asset Store 2.0.0, puente de entradas semánticas propio, metadatos Unity y comprobaciones estáticas.
- **Resguardo legal:** upstream indica Asset Store EULA y fuente Luckiest Guy Apache 2.0. No se copió ni republicó el contenido original en Git público. `.gitignore` protege `Assets/` salvo código BIOFIT.
- **Pruebas:** enlaces, SHA y archivos originales inspeccionados; código propio y CI publicados para comprobación estructural. No se ejecutó Unity ni se instaló paquete 2.0.0, no existe APK.
- **Sin cambios:** Dash, firmware, BLE, algoritmos de salto, recursos locales del usuario y `main`.
- **Pendiente:** inspección del paquete real desde la PC del usuario; vincular proyecto local preservándolo; asignar eventos al controlador real; generar primera APK después de Editor.

### Plantilla para nuevas entradas

```markdown
## AAAA-MM-DD — Hito / cambio
- Solicitud y objetivo:
- Rama / commit base / commit final:
- Archivos modificados:
- Comportamiento anterior / nuevo:
- Invariantes preservados (firmware, BLE, control, assets):
- Pruebas host/CI:
- Prueba Unity Editor:
- Prueba APK Android:
- Prueba BLE/IMU física:
- Riesgos y recursos/licencias:
- Aceptación del usuario:
- Pendientes y próxima acción:
```
