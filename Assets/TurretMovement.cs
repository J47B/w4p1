using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float rotation = 0.0f;

        if (Input.GetKey(KeyCode.Q))
        {
            rotation = -50 * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotation = 50 * Time.deltaTime;
        }

        transform.Rotate(0.0f, rotation, 0.0f);
    }
}