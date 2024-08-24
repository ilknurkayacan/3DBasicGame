using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Image img;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            img.fillAmount -= .5f;
        }
    }

    public void Azalt()
    {
        img.fillAmount -= .1f;
    }
}
