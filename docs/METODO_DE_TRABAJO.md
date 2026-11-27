# BIOFIT RUNNER — Método de trabajo (adaptación de BIOFIT DASH)

**Fuente de referencia:** [BIOFIT DASH — Relevo operativo](https://github.com/LucianoRodriguezUrquiza/BIOFIT-DASH/blob/main/docs/RELEVO_PROYECTO.md) y [Criterios permanentes de BIOFIT GAME](https://github.com/LucianoRodriguezUrquiza/BIOFIT-DASH/blob/main/docs/CRITERIOS_DE_TRABAJO_BIOFIT_GAME.md). Este documento aplica las mismas reglas a un **proyecto nuevo e independiente**, no declara funciones ya implementadas.

## Seis principios operativos

### ICC — Integridad del control corporal
- Mantener intactos el firmware compartido, los datos IMU y la conexión BLE/detector que estén validados en DASH. La versión de Unity del juego no exige reflashear los ESP32.
- STEP/WALK/RUN de Runner todavía **no están validados**; no presentar umbrales o cadencias experimentales como definitivos.
- Separar detección de marcha/carrera y salto bilateral; no reutilizar directamente el cooldown de salto para bloquear pasos.
- Distinguir comandos del juego, candidatos del clasificador y gestos físicos realmente comprobados. Cambiar parámetros de detección solo por evidencia y autorización expresa.

### DIPL — Desarrollo incremental en proyecto local único
- Runner tendrá su **propia carpeta local y su propio repositorio**, diferentes de DASH; fijar la ruta real cuando el usuario lo instale. No adivinar rutas Windows.
- No reinstalar paquetes ni sobrescribir archivos locales para cada avance. No multiplicar ZIP ni reimportar recursos sin necesidad.
- Cerrar Unity antes de actualizar archivos mediante Git. Antes de tocar código: verificar `git status`, rama, HEAD y diferencias.
- Preferir `git fetch` y `git pull --ff-only`. Evitar `git add .` indiscriminado, `reset --hard`, `clean -fd`, sobrescrituras o `push --force`.
- Una rama por lote funcional y commits acotados. Conservar `main` estable; fusionar solo tras validación y autorización. Ante conflicto o archivos locales no versionados, detenerse y preservar.
- El usuario hace solo los pasos necesarios en Unity/Android; cambios de texto y código publicables pueden hacerse desde GitHub cuando corresponda.

### RFD — Recursos y fuentes documentadas
- Registrar URL, proveedor, edición, versión y licencia de Trash Dash, paquetes Unity, plugins BLE, modelos 3D, animaciones, música y demás dependencias.
- Usar fuentes verificables y distinguir ejemplos del código histórico frente al paquete efectivamente instalado.
- No modificar recursos aguas arriba sin estrategia de actualización y trazabilidad.

### BRO — Biblioteca de recursos originales
- Preservar los archivos importados y los materiales propios del usuario, incluso si Git los ignora.
- **Repositorio público:** no publicar paquetes y assets completos de Unity Asset Store ni recursos de terceros salvo autorización/licencia expresa. La ausencia de licencia NO permite libre redistribución.
- Cuando se conozcan las rutas reales, establecer exclusiones de Git específicas y revisar el staging archivo por archivo. Evitar reglas hipotéticas que oculten código propio.
- Documentar qué necesita tener la copia local para reproducir la estética y qué parte sí puede distribuirse.

### FLM — Full Level Map / Layout (principio adaptado)
- En DASH el FLM exige fidelidad a coordenadas y colisiones del nivel. En Runner se aplica **a segmentos de pista, tres carriles, obstáculos y distancias reales del gameplay**.
- Capturas ilustrativas o imágenes generadas no sustituyen datos de prefabs, colliders, posición de spawns, hitboxes ni pruebas de rutas transitables.
- Si se diseña un circuito, presentar planos o esquemas basados en la configuración efectiva y marcar claramente estimaciones.
- No copiar el sistema de niveles 2D de DASH: son juegos de arquitectura distinta.

### RCA — Registro continuo de avances
- Actualizar `README.md` cuando cambie el estado general, `docs/RELEVO_PROYECTO.md` para el relevo y `docs/REGISTRO_AVANCES.md` por lote.
- Anotar: fecha, petición, objetivo, rama, commit, archivos, causa, pruebas ejecutadas, resultados, problemas, estado de aceptación, próximos pasos.
- Separar explícitamente: **código inspeccionado**, **tests host/CI**, **Unity Editor**, **APK Android**, **BLE con hardware**, **validación biomecánica**.
- No considerar aprobada una versión por el éxito de pruebas de sintaxis. No inventar tiempos de respuesta o latencia ni afirmar compilaciones inexistentes.

## Ciclo de trabajo por versión

1. Leer README y RELEVO; verificar el estado remoto real.
2. Definir alcance, invariantes y criterios de aceptación de un lote.
3. Crear rama de trabajo desde la base vigente y preservar el juego original como referencia.
4. Implementar cambios mínimos coherentes, con pruebas automatizadas cuando sean viables.
5. Registrar resultados y limitaciones (incluyendo qué no se pudo probar).
6. Pedir **una sola sesión de prueba bien diseñada** en Unity o Android por lote significativo, evitando recompilaciones menores.
7. Con aceptación explícita, consolidar en `main`, registrar versión y no borrar ramas ni reescribir historial por defecto.

## Comprobaciones automáticas

DASH usa `.github/workflows/` y `tests/` con varias comprobaciones. Runner adoptará una CI propia **cuando exista código**: validación de archivos Unity (`Assets`, `Packages`, `ProjectSettings`), pruebas del adaptador de entrada, regresión de acciones, lint/estructura según dependencias efectivas. Un CI de scripts NO acredita una APK ni funcionamiento BLE.

## Límites iniciales

No está importado Trash Dash. No existe código propio Runner ni se ha validado el receptor BLE aquí. No se ha compilado Android. Las reglas son vinculantes para el desarrollo, pero los hitos son propuestas que se validarán progresivamente.
