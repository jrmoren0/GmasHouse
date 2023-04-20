using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    GameObject target;
    GameObject placementObject;

    [SerializeField]
    Material transparentMaterial;


    private void Start()
    {
     target =  Camera.main.gameObject;
    }


    public void FaceCamera()
    {
        placementObject = GameObject.FindGameObjectWithTag("House");
        placementObject.transform.LookAt(target.transform);
        Vector3 eulerRotation = placementObject.transform.rotation.eulerAngles;
        placementObject.transform.rotation = Quaternion.Euler(0, eulerRotation.y, eulerRotation.z);
    }

    public void clearPlaneMAterial()
    {
        GameObject[] planes = GameObject.FindGameObjectsWithTag("Plane");

        foreach (GameObject p in planes)
        {
            p.GetComponent<MeshRenderer>().material = transparentMaterial;
            
        }
    }
}
