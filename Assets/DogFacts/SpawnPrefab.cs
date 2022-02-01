using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    [SerializeField]
    public GameObject myPrefab;
    [SerializeField]
    public Transform parent;
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Instantiate(myPrefab, new Vector3(-1400, 300, -2), Quaternion.identity, parent);

        }
        
    }
}
