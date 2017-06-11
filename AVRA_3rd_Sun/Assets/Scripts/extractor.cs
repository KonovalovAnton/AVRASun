using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(MeshFilter))]
public class Example : MonoBehaviour
{
    private void Start()
    {
        AssetDatabase.CreateAsset(GetComponent<MeshFilter>().mesh, "Assets/mesh.asset");
    }
}