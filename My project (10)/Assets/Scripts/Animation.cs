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
        if(Input.GetAxis("Vertical") > 00.00){
            anim.SetBool("walkfront", true);
        }
        else
        {
            anim.SetBool("walkfront", false);
        }

        if(Input.GetAxis("Vertical")< 00.00){
            anim.SetBool("walkback", true);

        }
        else{
            anim.SetBool("walkback", false);
        }
    }
}