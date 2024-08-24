using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private int cansayisi=3;



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ajan"))
        {
            if (cansayisi != 0)
            {
                cansayisi--;

            }
            else
            {
                Destroy(gameObject);
            }
        }
   
    }
}
