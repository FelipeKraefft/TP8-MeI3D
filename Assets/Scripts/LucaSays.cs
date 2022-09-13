using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LucaSays : MonoBehaviour
{
    public GameObject UIManager;
    public Text Luca;
    public LightsManager lightsManager;

    // Start is called before the first frame update
    void Start()
    {
        lightsManager = GameObject.Find("[LightsManager]").GetComponent<LightsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player" && lightsManager.lucesEncendidas == false){
            
        }
        if(col.gameObject.tag == "Player" && lightsManager.lucesEncendidas){
            UIManager.GetComponent<UIManager>().LucaSays.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnTriggerExit(Collider col){
        if(col.gameObject.tag == "Player" && lightsManager.lucesEncendidas){
            UIManager.GetComponent<UIManager>().LucaSays.SetActive(false);
            Time.timeScale = 1;
            Luca.text = "Ya te dije que la contraseña es -DaroNoEsta-"; 
        }
    }
    
}
