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
