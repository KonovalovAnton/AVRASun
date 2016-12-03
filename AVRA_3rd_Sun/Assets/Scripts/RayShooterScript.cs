using UnityEngine;
using System.Collections;

public class RayShooterScript : MonoBehaviour
{
	public float chargeSpeed  = 5f;

	private Camera _camera;

	// Use this for initialization
	void Start ()
	{
		_camera = GetComponent<Camera> ();

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	// Update is called once per frame
	void Update ()
	{
			Vector3 point = new Vector3 (_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
			Ray ray = _camera.ScreenPointToRay (point);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				GameObject hitObject = hit.transform.gameObject;
				ChargeableScript chargeable = hitObject.GetComponentInChildren<ChargeableScript>();
				if (chargeable != null) {
				chargeable.Charge(Time.deltaTime * chargeSpeed);
					Debug.Log ("Target hit");
				} 
		}
	}
}