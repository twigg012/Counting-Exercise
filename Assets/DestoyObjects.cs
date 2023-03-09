using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoyObjects : MonoBehaviour

{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DestroyObject();
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}