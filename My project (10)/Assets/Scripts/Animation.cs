using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //walk front
        if(Input.GetAxis("Vertical") > 00.00){
            anim.SetBool("walkfront", true);
        }
        else
        {
            anim.SetBool("walkfront", false);
        }

        //walk back
        if(Input.GetAxis("Vertical")< 00.00){
            anim.SetBool("walkback", true);

        }
        else{
            anim.SetBool("walkback", false);
        }

        //Run
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetAxis("Vertical") > 00.00){
            anim.SetBool("run", true);
        }
        else{
            anim.SetBool("run", false);
        }
    }
}
