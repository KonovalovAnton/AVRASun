using UnityEngine;
using System.Collections;

public class RayShooterScript : MonoBehaviour
{
	public float chargeSpeed  = 5f;

	private Camera _camera;
	private GameObject flash;
	// Use this for initialization
	void Start ()
	{
		_camera = GetComponent<Camera> ();

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

		flash = transform.GetChild(0).gameObject;//GetComponentInChildren<Transform>().gameObject;
		flash.SetActive(false);
	}

	// Update is called once per frame
	void Update ()
	{
			flash.SetActive(false);
			Vector3 point = new Vector3 (_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
			Ray ray = _camera.ScreenPointToRay (point);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
			
			GameObject hitObject = hit.transform.gameObject;
			ChargeableScript chargeable = hitObject.GetComponentInChildren<ChargeableScript>();
			WaterSphereScript waterSphere = hitObject.GetComponentInChildren<WaterSphereScript>();
			LavaSphereScript lavaSphere = hitObject.GetComponentInChildren<LavaSphereScript>();

			/*if (chargeable.temperature > 50f) {
				waterSphere.SetMaterialAlpha(0f);
				lavaSphere.SetMaterialAlpha((chargeable.temperature - 50f) / 50f);
			}
			else if (chargeable.temperature < 50f) {
				waterSphere.SetMaterialAlpha((chargeable.temperature - 50f)/ 50f);
				lavaSphere.SetMaterialAlpha(0f);
			}
			else {
				waterSphere.SetMaterialAlpha(0f);
				lavaSphere.SetMaterialAlpha(0f);
			} */
			if (chargeable != null && !ChargeableScript.gameover) {
				flash.SetActive(true);
				chargeable.Charge(Time.deltaTime * chargeSpeed);
				Debug.Log ("Target hit");
			}
			else {
				flash.SetActive(false);
				Debug.Log("Deactivate!");
			}
		}
	}
}