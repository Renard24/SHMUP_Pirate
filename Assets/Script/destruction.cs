using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction : MonoBehaviour
{
    public GameObject guyGameObject;
    public GameObject instantiateObjectHere;
    private GameObject newInstance;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(newInstance);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            CreatePrefab();
        }
    }

    public void CreatePrefab()
    {
        float instX = instantiateObjectHere.transform.position.x;
        float instY = instantiateObjectHere.transform.position.y;
        newInstance = Instantiate(guyGameObject, new Vector3(instX, instY, 0), Quaternion.identity);
    }

    public void DestoyPrefab()
    {
        Destroy(newInstance);
    }
}
