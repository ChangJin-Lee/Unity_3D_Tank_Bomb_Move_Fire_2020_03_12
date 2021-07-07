using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    private float moveSpeed = 80.0f;
    private float rotSpeed = 90.0f;

    private float h, v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.LeftControl))
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            transform.Rotate(Vector3.up * rotSpeed * h * Time.deltaTime);
            transform.Translate(Vector3.forward * v * moveSpeed * Time.deltaTime);
        }
    }
}
