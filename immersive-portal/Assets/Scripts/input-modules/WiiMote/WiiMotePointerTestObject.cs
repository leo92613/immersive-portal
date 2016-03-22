using UnityEngine;
using System.Collections;

namespace AssemblyCSharp {
    public class WiiMotePointerTestObject : MonoBehaviour, IWiiMoteAHandler {

        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {
                
        }

        public void OnAPressDown(WiiMoteEventData eventData) {

   
            Debug.Log("OnAPressDown - " + eventData.module.name + " to " + this.gameObject.name);
            this.transform.localScale *= 2f;
        }

        public void OnAPress(WiiMoteEventData eventData) {
            //throw new System.NotImplementedException();
        }

        public void OnAPressUp(WiiMoteEventData eventData) {
            Debug.Log("OnAPressUp - " + eventData.module.name + " to " + this.gameObject.name);
            this.transform.localScale /= 2f;
        }
    }
}

