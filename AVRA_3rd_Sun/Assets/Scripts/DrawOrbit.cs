using UnityEngine;
using System.Collections;

public class DrawOrbit : MonoBehaviour {

    [SerializeField] GameObject line;
    private static float scaleFactor = 500;

    Transform planet;

    private static float frequencyFactor = 1000;

    void Start () {
        planet = transform.FindChild("Planet1");
        float r = Vector3.Distance(planet.transform.position, transform.position);
        float x = 0;
        float y = r;

        for (float i = 0; i < Mathf.PI * 2; i += Mathf.PI / 90 / Mathf.Pow(r, 0.7f) * frequencyFactor)
        {
            x = Mathf.Cos(i) * r;
            y = Mathf.Sin(i) * r;
            GameObject go = GameObject.Instantiate(line, transform) as GameObject;
            go.transform.localPosition = new Vector3(x, 0, y);
            go.transform.localScale = new Vector3(go.transform.localScale.x * Mathf.Pow(r, 0.8f) / scaleFactor,
                go.transform.localScale.y * Mathf.Pow(r, 0.8f) / scaleFactor,
                go.transform.localScale.z) * Mathf.Pow(r, 0.8f) / scaleFactor;
        }
    }
}
