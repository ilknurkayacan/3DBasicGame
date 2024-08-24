using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AgentScript : MonoBehaviour
{
    NavMeshAgent child;
    public GameObject hedef;
    public string ajanturu;
    private int carpmasayisi;
    private float darbegucu;
    public GameObject gamekontr;

    void Start()
    {
        child = GetComponent<NavMeshAgent>();
        child.SetDestination(hedef.transform.position);

        switch (ajanturu)
        {
            case "mavi":
                carpmasayisi = 15;
                darbegucu = 10f;
                break;
            case "sari":
                carpmasayisi = 6;
                darbegucu = 10f;
                break;
            case "mor":
                carpmasayisi = 2;
                darbegucu = 5f;
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("engel"))
        {
            if (carpmasayisi != 0)
            {
                carpmasayisi -= 1;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        if (other.gameObject.CompareTag("anahedef"))
        {
            gamekontr.GetComponent<GameKontrol>().Candusur(darbegucu);
            Destroy(gameObject);
        }
    }
}
