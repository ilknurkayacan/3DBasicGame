using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesScript : MonoBehaviour
{
    // Start is called before the first frame update
    ParticleSystem part;
    void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
            part.Play();
        if (Input.GetKeyDown(KeyCode.S))
            part.Pause();
        if (Input.GetKeyDown(KeyCode.T))
            part.Stop();
    }

    
    private void OnParticleCollision(GameObject other)
    {
        if (!other.gameObject.CompareTag("kup"))
        {
            Destroy(other.gameObject);
            Debug.Log("calisiyor");
            
        }
        
    }
}
