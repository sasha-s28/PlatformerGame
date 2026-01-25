using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private Text punts;

   private  void  Awake()
   {
        punts = GetComponent<Text>();  //agafem el component de text del joc "ui score"
   }

    private void OnEnable()
    {
        updatescore.actualitzar += puntspantalla;
    }
    private void OnDisable()
    {
        updatescore.actualitzar -= puntspantalla;
    } 

    private void puntspantalla(int PUNTS)
    {
        punts.text =PUNTS.ToString();
    }

}
