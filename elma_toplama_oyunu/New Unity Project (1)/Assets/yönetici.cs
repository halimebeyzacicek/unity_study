using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//sahneyi terar oynatmak için ekledik.

public class yönetici : MonoBehaviour
{

    //int saniye = 10;
    public GameObject elma;
    float zaman_araligi=0.5f;
    float kalan_zaman = 0.0f;
    bool oyun_durduruldu = false;


    public void tekrar_oyna_btn()
    {
        //SceneManager.LoadScene("Scenes/SampleScene");   //sahne oyunun neresinde ise parantez içine yaz.
        SceneManager.LoadScene("Scenes/sahne_2");  //sahne 2 ye gitsin istiyorum.
        Time.timeScale = 1.0f;//zamnı eski haline getiriyoruz çünkü oyun bitince zamanı durdurmuştuk.
    } 









    public void durdur_btn()
    {
        oyun_durduruldu = !oyun_durduruldu;

        if (oyun_durduruldu == true)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
    }








    void Start()
    { 

        //Invoke("saniye_azalt", 1.0f); //fonksiyon adı, kaç saniye sonra çalışmasını istiyorsun. //invoke fonksiyonu bir kez çalışır.
        //InvokeRepeating("saniye_azalt", 0.0f, 1.0f);  //fonksiyon adı, kaç sn ye sonra ilk kez çalışacak, hangi saniyeler arası çalışacak. (1 er san ye aralıklarla çalışacak)
        //InvokeRepeating("elma_ekle", 0.0f, 0.5f);  //bunun yerine time kullanabiliriz.
    }
     
    void elma_ekle()
    {
        float rast = Random.Range(13.57f, 27.44f);

        GameObject yeni_elma = Instantiate(elma, new Vector3(rast, -14.24f, -43.69f), Quaternion.identity); //identiy= varsayılan olarak 0 açı ile.
    }


    /*
    void saniye_azalt()
    {
        saniye--;
        Debug.Log(saniye.ToString());

        if (saniye == 5)
        {
            CancelInvoke("saniye_azalt");  //saniye 5 e düşünce duracak invoke repeatting fonksiyonu. parantez içini yazmazsak tüm invokeları durdurur.
        }
    }
    */





    void Update()
    {
        if (Time.time >= kalan_zaman) //yarım saniyede bir bu if nbloğunu çalıştırmış oluyoruz.
        {
            elma_ekle();
            kalan_zaman = zaman_araligi + Time.time;
        }



        //Debug.Log(Time.time);  //oyun zamanını göstermek
        //Time.timeScale = 0.0f;  //oyunu durdurmak
        //Time.timeScale = 0.5f;  //%50 oranınca ağır ilelesin. slow motion  (1.0f--->normal akış değerleri)


    }
}
