# BIOFIT RUNNER — Procedencia de recursos y licencias

## Fuentes iniciales

| Fuente | Uso previsto | Estado |
|---|---|---|
| [Trash Dash — Unity Asset Store](https://assetstore.unity.com/packages/templates/packs/endless-runner-mobile-sample-project-87901) | Base jugable a importar localmente | Paquete todavía no incorporado al repositorio RUNNER |
| [Trash Dash — Unity-Technologies/EndlessRunnerSampleGame](https://github.com/Unity-Technologies/EndlessRunnerSampleGame) | Documentación y código histórico de referencia | No se ha fusionado ni importado |
| [BIOFIT DASH](https://github.com/LucianoRodriguezUrquiza/BIOFIT-DASH) | Metodología, referencias técnicas y eventual selección de módulos BLE | No copiar gameplay, arte o escenas de DASH |
| [BIOFIT-GAME-Firmware](https://github.com/LucianoRodriguezUrquiza/BIOFIT-GAME-Firmware) | Firmware compartido ya desarrollado | No modificar en la inicialización Runner |

## Política obligatoria antes de publicar código y assets

1. **El repositorio RUNNER es público.** Un paquete gratuito de Asset Store NO implica que sea de dominio público ni que pueda republicarse como proyecto fuente completo.
2. Examinar el EULA del paquete y las licencias de recursos asociados. Registrar nombre, versión, URL y restricciones de cada dependencia.
3. Conservar paquetes protegidos localmente cuando sea necesario; publicar sólo código, configuración, herramientas y recursos cuya redistribución esté autorizada.
4. Antes del primer commit que contenga `Assets/`, inspeccionar `git status` y los archivos individualmente. El `.gitignore` genérico de Unity no excluye automáticamente assets de terceros.
5. Si excluir un paquete impediría reproducir el proyecto desde un clon público, documentar exactamente el paso manual de importación. No subir el paquete para ahorrar ese paso.
6. Atribuciones y licencias de scripts nuevos también deberán quedar documentadas. No asumir que el código GitHub histórico y la edición Asset Store tienen idéntica licencia.

## Verificación pendiente
- Versión exacta descargada del Asset Store y metadatos de licencia del paquete.
- Estructura `Assets/` realmente creada en la instalación local, antes de definir exclusiones específicas.
- Dependencias URP, Input System, Addressables, servicios y compatibilidad Android.
- Permisos para reutilizar en una distribución futura de BIOFIT GAME cualquier modelo, música, textura o animación.
