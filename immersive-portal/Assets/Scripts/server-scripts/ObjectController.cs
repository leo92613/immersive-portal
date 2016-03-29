using System;
using UnityEngine;
namespace Holojam
{
	public class ObjectController : MonoBehaviour
	{
		public string label;
		public MasterStream mStream;
		public void Start ()
		{
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