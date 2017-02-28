using UnityEngine;
using System.Collections;

public class RayShooterScript : MonoBehaviour
{
	[SerializeField] GameObject flash;
    [SerializeField] AudioSource flashSound;
	public float chargeSpeed  = 5f;

	private Camera _camera;
    // Use this for initialization
    void Start ()
	{
		_camera = GetComponent<Camera> ();

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

        EnableFlash(false);
    }

	// Update is called once per frame
	void Update ()
	{
        //EnableFlash(false);
        Vector3 point = new Vector3 (_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
		Ray ray = _camera.ScreenPointToRay (point);
		RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            GameObject hitObject = hit.transform.gameObject;
            ChargeableScript chargeable = hitObject.GetComponentInChildren<ChargeableScript>();
            Meteor meteor = hitObject.GetComponentInParent<Meteor>();

            if (chargeable != null && !ChargeableScript.gameover)
            {
                EnableFlash(true);
                chargeable.Charge(Time.deltaTime * chargeSpeed);
                //Debug.Log("Target hit");
            }
            else if(meteor != null)
            {
                EnableFlash(true);
                meteor.HitBySun();
                //Debug.Log("Meteor hit");
            }
            else
            {
                EnableFlash(false);
                //Debug.Log("Deactivate!");
            }
        }
        else
        {
            EnableFlash(false);
        }
	}

    void EnableFlash(bool enable)
    {
        flash.SetActive(enable);
        flashSound.mute = !enable;
    }
}