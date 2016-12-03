using UnityEngine;
using System.Collections;

public class RayShooterScript : MonoBehaviour
{

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
				ChargeableScript chargeable = hitObject.GetComponent<ChargeableScript>();
				if (chargeable != null) {
					chargeable.ReactToHit();
					Debug.Log ("Target hit");
				} else {
					StartCoroutine (SphereIndicator (hit.point));
			}
		}
	}

	private IEnumerator SphereIndicator (Vector3 pos)
	{
		GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphere.transform.position = pos;

		yield return new WaitForSeconds (1);

		Destroy (sphere);
	}
}