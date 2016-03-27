using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class ObjectController : MonoBehaviour
	{
		public string label;

		[HideInInspector]
        public MasterStream mStream;

		public void Start ()
		{
            mStream = MasterStream.Instance;
		}
		public void Update() {
			Vector3 position = mStream.getLiveObjectPosition(label);
			Quaternion rotation = mStream.getLiveObjectRotation(label);
			
			SetBodyData(position, rotation);
		}
		public virtual void SetBodyData(Vector3 pos, Quaternion rot) {
			this.transform.localPosition = pos;
			this.transform.localRotation = rot;
		}
	}
}