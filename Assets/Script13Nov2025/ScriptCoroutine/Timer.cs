using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
//using Microsoft.Unity.VisualStudio.Editor;

public class Timer : MonoBehaviour
{
   public float Waktu; //kalau pakai int maka perhitungannya di bulatkan
   public float MaximumWaktu; //kalau pakai int maka perhitungannya di bulatkan
   public TMP_Text TextTimer;
   public bool WaktuBerjalan=true;
   public KeyCode StartCorountineKey;
   public KeyCode StopCorountineKey;
   public Coroutine HitungTimerCorountine;
   
   //referensi ke Progress Fill dari Image
   public Image ProgressFill;

    /*private void Start()
     {
        StartCoroutine(HitungTimer());
     }
     */

    private void Update()
    {
        if (Input.GetKeyDown(StartCorountineKey))
        {
            if(HitungTimerCorountine==null) //mendeteksi dulu apakah ada Corountine yang dijalankan sebelum di eksekusi, dan harus jalan satu kali klik
            {
                HitungTimerCorountine=StartCoroutine(HitungTimer());
            }
        }

        if (Input.GetKeyDown(StopCorountineKey))
        {
            if (HitungTimerCorountine != null)
            {
                StopCoroutine(HitungTimerCorountine);
                HitungTimerCorountine=null;
            }
        }
    }


    IEnumerator HitungTimer()
    {
        while(WaktuBerjalan==true && Waktu<MaximumWaktu)
        {
            Waktu=Waktu+1;
            TextTimer.text=Waktu.ToString();
            ProgressFill.fillAmount=Waktu/MaximumWaktu;
            yield return new WaitForSeconds(1);
        }

    }

}
