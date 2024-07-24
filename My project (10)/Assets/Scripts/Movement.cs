using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    float Speed;
    float SpeedRotation;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 2.5f;
        SpeedRotation = 55f;
    }

    // Update is called once per frame
    void Update()
    {
    //movement Vertical *If u want moment horizontal, its just trade "Vertical" for "Horizontal" and Translate(0,0,movertical) for Translate(moveHorizontal, 0,0, 0)

        float moveVertical = (Input.GetAxis("Vertical")*Speed)*Time.deltaTime;
        transform.Translate(0,0,moveVertical);

        //Rotation

        float moveRotation = (Input.GetAxis("Horizontal")*SpeedRotation)*Time.deltaTime;
        transform.Rotate(0,moveRotation,0);
         
    }
}
