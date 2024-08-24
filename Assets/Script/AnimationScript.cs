using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animator myanim;
    
    void Start()
    {
        myanim = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            myanim.SetBool("yuru", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            myanim.SetBool("yuru", false);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            myanim.SetBool("hizlikos", true);
           
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            myanim.SetBool("hizlikos", false);

        }
    }
}
