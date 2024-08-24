using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameKontrol : MonoBehaviour
{
    private float enerji;
    public Image handbar;
    public GameObject[] noktalar;
    public GameObject engelprefab;
    private int kutucount;
    private int kalandeger;
    public Text kututext;
    public Button[] btn;
    public GameObject gameover;

    public GameObject navengel;
    public Button[] navBtn;
    public Text navtext;
    private int navsayisi;
    

    void Start()
    {
        enerji = 100;
        kutucount = 30;
        navsayisi = 5;
        navtext.text = "5";
        kututext.text = "30";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Candusur(float deger)
    {
        enerji -= deger;
        handbar.fillAmount = enerji/100;
        Gameover();
    }
    public void Gameover()
    {

        if (enerji < 0)
        {
            gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void NoktoBtn(int deger)
    {
        //noktalar[deger].GetComponent<MeshRenderer>().enabled = true;
        Instantiate(engelprefab, noktalar[deger].transform.position, Quaternion.identity);
      
        kutucount--;
        kalandeger = kutucount;
        kututext.text = kalandeger.ToString();
       
        BtnDurdur();
    }
    public void Navolustur(int deger)
    {
        Instantiate(navengel, noktalar[deger].transform.position, Quaternion.identity);
        navsayisi--;
        navtext.text = navsayisi.ToString();
        BtnDurdur();
    }

    public void BtnDurdur()
    {
        if (kutucount == 0)
        {
            foreach(var i in btn)
            {
                i.interactable = false;
            }
        }
        if (navsayisi == 0)
        {
            foreach (var i in btn)
            {
                i.interactable = false;
            }
        }
    }
}
