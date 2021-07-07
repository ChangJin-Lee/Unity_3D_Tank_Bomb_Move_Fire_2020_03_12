using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelCtrl : MonoBehaviour
{
    private float rotSpeed = 50.0f;

    private float v, rotX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotX = transform.eulerAngles.x;

        Debug.Log(rotX);

        if (rotX >= -10 && rotX < 10) transform.eulerAngles = new Vector3(359.0f, transform.eulerAngles.y, transform.eulerAngles.z);
        else if (rotX >= 360 && rotX < 350) transform.eulerAngles = new Vector3(transform.eulerAngles.x -1, transform.eulerAngles.y, transform.eulerAngles.z);
        else if (rotX <= 315 && rotX > 250) transform.eulerAngles = new Vector3(transform.eulerAngles.x +1 , transform.eulerAngles.y, transform.eulerAngles.z);

        if (Input.GetKey(KeyCode.LeftControl)) //&& ( (rotX > 315) || (rotX < 10))) //&& (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))) // 컨트롤 + 좌 or 우 화살표 키 누르면 
        {
            v = Input.GetAxis("Vertical");
            //                  x축 기준이라고 생각하면 됨.
            transform.Rotate(Vector3.left * rotSpeed * v * Time.deltaTime);
        }
       
    }
}
