using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentCtrl : MonoBehaviour
{
    private float rotSpeed = 50.0f;

    private float h;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift)) //&& (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))) // 컨트롤 + 좌 or 우 화살표 키 누르면 
        {
            h = Input.GetAxis("Horizontal");

            transform.Rotate(Vector3.up*rotSpeed*h*Time.deltaTime);
        }
        
    }
}
