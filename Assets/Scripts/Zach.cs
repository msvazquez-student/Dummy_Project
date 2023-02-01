using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zach : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Zach says hi");
        }
    }
}
