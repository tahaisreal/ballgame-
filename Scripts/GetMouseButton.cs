using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed primary button.");
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");
    }
}
