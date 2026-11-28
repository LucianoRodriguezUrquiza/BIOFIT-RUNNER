using System;
using UnityEngine;
using UnityEngine.Events;

namespace Biofit.Runner
{
    /// <summary>
    /// Puente de acciones semánticas independiente del firmware y de las clases de Trash Dash.
    /// Debe invocarse en el hilo principal de Unity; los callbacks BLE deberán encolarse
    /// y entregarse aquí desde Update (NO llamar UnityEvent en un hilo BLE).
    /// </summary>
    public sealed class BiofitRunnerInputBridge : MonoBehaviour
    {
        [Serializable]
        public sealed class LaneChangeEvent : UnityEvent<int> { }

        [Header("Conexiones al controlador del juego (Inspector)")]
        [SerializeField] private LaneChangeEvent onChangeLane = new LaneChangeEvent();
        [SerializeField] private UnityEvent onJump = new UnityEvent();
        [SerializeField] private UnityEvent onSlide = new UnityEvent();

        [Header("Pruebas sin sensores")]
        [Tooltip("Teclas 1/2/3/4: izquierda/derecha/salto/deslizamiento.")]
        [SerializeField] private bool enableLegacyKeyboardDebug = false;
        [SerializeField] private bool verboseLogging = false;

        public event Action<string> ActionDispatched;

        public void SendLeft()
        {
            onChangeLane.Invoke(-1);
            Report("LEFT");
        }

        public void SendRight()
        {
            onChangeLane.Invoke(1);
            Report("RIGHT");
        }

        public void SendJump()
        {
            onJump.Invoke();
            Report("JUMP");
        }

        public void SendSlide()
        {
            onSlide.Invoke();
            Report("SLIDE");
        }

        /// <summary>
        /// Entrada semántica para un futuro adaptador BLE, no protocolo BLE en bruto.
        /// </summary>
        public bool TrySubmitAction(string action)
        {
            if (string.IsNullOrEmpty(action)) return false;

            switch (action.Trim().ToUpperInvariant())
            {
                case "LEFT": SendLeft(); return true;
                case "RIGHT": SendRight(); return true;
                case "JUMP": SendJump(); return true;
                case "SLIDE": SendSlide(); return true;
                default: return false;
            }
        }

        private void Report(string action)
        {
            if (verboseLogging)
                Debug.Log("[BIOFIT RUNNER INPUT] " + action, this);

            Action<string> listener = ActionDispatched;
            if (listener != null) listener(action);
        }

        private void Update()
        {
#if ENABLE_LEGACY_INPUT_MANAGER
            if (!enableLegacyKeyboardDebug) return;
            if (Input.GetKeyDown(KeyCode.Alpha1)) SendLeft();
            if (Input.GetKeyDown(KeyCode.Alpha2)) SendRight();
            if (Input.GetKeyDown(KeyCode.Alpha3)) SendJump();
            if (Input.GetKeyDown(KeyCode.Alpha4)) SendSlide();
#endif
        }
    }
}
