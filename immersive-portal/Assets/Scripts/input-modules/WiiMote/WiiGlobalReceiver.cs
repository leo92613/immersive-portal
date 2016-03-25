using UnityEngine;
using System.Collections;

namespace AssemblyCSharp {
    public class WiiGlobalReceiver : MonoBehaviour {

        public WiiMoteModule module;

        protected virtual void OnEnable() {
            WiiMoteModule.receivers.Add(this);
        }

        protected virtual void OnDisable() {
            WiiMoteModule.receivers.Remove(this);
        }
    }
}

