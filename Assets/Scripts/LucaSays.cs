using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LucaSays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(collider col){
        if(col.gameObject.tag == "Player"){
            player.GetComponent<UIManager>().LucaSays.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnTriggerExit(collider col){
        if(col.gameObject.tag == "Player"){
            player.GetComponent<UIManager>().LucaSays.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
