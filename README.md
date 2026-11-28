# BIOFIT RUNNER — Endless Runner para Android (BIOFIT GAME)

**Estado 28/11/2026: R0.0 bootstrap del repositorio, sin APK validada.** Se mantiene independiente de BIOFIT DASH y del firmware ESP32. El videojuego elegido es **Trash Dash**, de Unity Technologies.

## ¿Dónde está el juego?

**Hay dos fuentes distintas que NO deben confundirse:**

1. **Juego recomendado para el desarrollo actual:** [Trash Dash / Endless Runner | Mobile Sample Project en Unity Asset Store](https://assetstore.unity.com/packages/templates/packs/endless-runner-mobile-sample-project-87901), edición 2.0.0 (septiembre 2026), declarada compatible con Unity 6.3 URP. Debe obtenerse desde la cuenta del usuario e importarse **localmente** en Unity. Sus archivos originales no se republican en este repositorio público.
2. **Fuente histórica oficial enlazada:** [Unity-Technologies/EndlessRunnerSampleGame](https://github.com/Unity-Technologies/EndlessRunnerSampleGame), fijada en el submódulo `ThirdParty/TrashDash-Upstream`. Es **Unity 2019.3**, no la edición 2.0.0. El submódulo es una referencia Git al origen oficial y **no una copia** del contenido.

**Este repositorio contiene hoy:** metodología, guías de instalación, un adaptador propio de acciones de control, un enlace a la versión histórica oficial y pruebas estáticas del repositorio. **Aún no contiene el juego nuevo importado**, ni se ha probado una APK.

## Guías de entrada
- [Instalar Trash Dash y preparar un único proyecto local](docs/BASE_TRASH_DASH.md).
- [Relevo operativo vigente](docs/RELEVO_PROYECTO.md).
- [Método de trabajo ICC/DIPL/RFD/BRO/FLM/RCA](docs/METODO_DE_TRABAJO.md).
- [Fuentes, licencias y límites del repositorio público](docs/RECURSOS_Y_LICENCIAS.md).
- [Registro RCA](docs/REGISTRO_AVANCES.md).

## Estructura

```text
Assets/BIOFIT-RUNNER/Scripts/BiofitRunnerInputBridge.cs   <-- código propio
ThirdParty/TrashDash-Upstream/                           <-- gitlink a GitHub oficial, versión histórica
docs/                                                     <-- documentación y licencias
tests/                                                    <-- controles de repositorio (no compilan Unity)
.github/workflows/                                        <-- CI estática
```

## Hoja de ruta

| Versión | Resultado exigido | Estado |
|---|---|---|
| R0.0 | Repositorio, reglas, referencia upstream, puente neutro de acciones | Propuesta en rama |
| R0.1 | Importación local de Trash Dash 2.0.0; juego original funciona en Unity 6.3 | Pendiente |
| R0.2 | APK Android de Trash Dash sin sensores | Pendiente |
| R0.3 | Conexión BLE y eventos semánticos integrados en el puente | Pendiente |
| R0.4 | STEP/WALK/RUN basados en dos tobillos, validación con señales físicas | Pendiente |
| R0.5 | Exergaming con velocidad controlada por movimiento y obstáculos calibrados | Pendiente |

## Reglas esenciales
- `main` se modifica solamente tras validación y autorización; no hacer merge automático.
- Un único proyecto local Runner. No reinstalar, borrar archivos locales, hacer `reset --hard`, `git clean` ni `push --force`.
- No modificar sin autorización el firmware ni BLE/saltos estables de DASH.
- **Protección Git:** `.gitignore` excluye por defecto los assets del paquete de terceros en `Assets/`; solamente se versiona el código propio en `Assets/BIOFIT-RUNNER/`. Verificar `git status` antes de agregar archivos.
- Las pruebas CI estáticas **no equivalen** a compilación Unity, APK ni validación IMU.

Referencias: [BIOFIT DASH](https://github.com/LucianoRodriguezUrquiza/BIOFIT-DASH) · [Firmware](https://github.com/LucianoRodriguezUrquiza/BIOFIT-GAME-Firmware).
