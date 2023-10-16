using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public GameObject c;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gas = Input.GetAxis("Vertical");
        float movement = 2.5f * -gas * Time.deltaTime;

        
        Transform t = gameObject.transform;

        t.Translate(0.0f, 0.0f, movement);

        float steerGas = Input.GetAxis("Horizontal");
        float turn = steerGas * 75 * Time.deltaTime;

        t.Rotate(0.0f, turn, 0.0f);
        
    }
}
