using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class PlayerController : MonoBehaviour
	{
		public string id;
		public MasterStream mStream;
		public Vector3 offset;
        public GameObject outofRangeVis;

        bool recentered = false;

		private void Start() {}

		private void Update() {
			Vector3 cam_position = Vector3.zero;
			Quaternion cam_rotation = Quaternion.identity;

			if (mStream != null) {
				cam_position = mStream.getLiveObjectPosition (id);
				cam_rotation = mStream.getLiveObjectRotation (id);
			}

			Quaternion hmd_rotation = Quaternion.identity;

			hmd_rotation = UnityEngine.VR.InputTracking.GetLocalRotation (UnityEngine.VR.VRNode.CenterEye);

            //Vector3 hmd_eul = hmd_rotation.eulerAngles;
            //Vector3 cam_eul = cam_rotation.eulerAngles;

            //Vector3 goalVector = Vector3.Slerp(hmd_eul, new Vector3(hmd_eul.x, cam_eul.y, hmd_eul.z), 0.5f);

            Quaternion goalOrientation = this.transform.rotation;

            if (cam_rotation.x == 0f && cam_rotation.y == 0f && cam_rotation.z == 0f) {
                //goalOrientation = hmd_rotation;
            } else {
                goalOrientation = cam_rotation*Quaternion.Inverse(hmd_rotation);
            }

            //Quaternion goalOrientation = cam_rotation * Quaternion.Inverse(hmd_rotation);
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, goalOrientation, Mathf.Clamp(Time.deltaTime,0,1));//Quaternion.Slerp(oldOrientation, cam_rotation * Quaternion.Inverse(hmd_rotation), Time.deltaTime);


            if (!cam_position.Equals(Vector3.zero)) {
                //recentered = false;
                if (outofRangeVis)
                    outofRangeVis.SetActive(false);
                this.transform.position = cam_position + this.transform.rotation * offset;

                //if (Quaternion.Angle(this.transform.rotation, cam_rotation) < 10f) {
                //    UnityEngine.VR.InputTracking.Recenter();
                //}
            } else {
                if (outofRangeVis)
                    outofRangeVis.SetActive(true);
                //if (!recentered) {
                //    UnityEngine.VR.InputTracking.Recenter();
                //    recentered = true;
                //}
            }
		}
	}
}

