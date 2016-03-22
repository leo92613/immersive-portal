using UnityEngine;
using System.Collections;

namespace AssemblyCSharp {
    public class WiiMoteGlobalTestObject : WiiGlobalReceiver, IGlobalWiiMoteHandler {

        /// <summary>
        /// Test object for global inputs from the wii mote. If the module is populated, then the object will only recieve globals from that object. Otherwise, it will recieve globals from all wiimotes.
        /// </summary>
        /// <remarks>
        /// DO:
        ///     * Extend WiiGlobalReceiver instead of MonoBehaviour.
        /// DO NOT:
        ///     * Fail to use base.OnEnable() and base.OnDisable() if overriding those functions.
        /// </remarks>

        public WiiMoteModule module;

        public void OnGlobalAPressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalAPressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalAPress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalAPress on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalAPressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalAPressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalBPressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalBPressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalBPress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalBPress on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalBPressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalBPressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalLeftPressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalLeftPressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalLeftPress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalLeftPress on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalLeftPressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalLeftPressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalRightPressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalRightPressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalRightPress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalRightPress on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalRightPressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalRightPressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalUpPressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalUpPressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalUpPress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalUpPress on " + this.name + " from module " + eventData.module.name);
            }
        }

        public void OnGlobalUpPressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalUpPressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalDownPressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalDownPressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalDownPress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalDownPress on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalDownPressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalDownPressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalPlusPressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalPlusPressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalPlusPress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalPlusPress on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalPlusPressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalPlusPressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalMinusPressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalMinusPressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalMinusPress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalMinusPress on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalMinusPressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalMinusPressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalHomePressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalHomePressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalHomePress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalHomePress on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalHomePressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalHomePressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalOnePressDown(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalOnePressDown on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalOnePress(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalOnePress on " + this.name + " from module " + eventData.module.name);
            } 
        }

        public void OnGlobalOnePressUp(WiiMoteEventData eventData) {
            if ((module && module.Equals(eventData.module)) || !module) {
                Debug.Log("OnGlobalOnePressUp on " + this.name + " from module " + eventData.module.name);
            } 
        }
    }
}

