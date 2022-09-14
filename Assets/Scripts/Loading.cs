using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Text txtloading;
    [SerializeField] GameObject[] loading;

    // Start is called before the first frame update
    void Start()
    {
        loading = GameObject.FindGameObjectsWithTag("LoadingBar");
        
        foreach (GameObject load in loading)
        {
            load.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Floor(Time.time) % 3 == 0)
        {
            txtloading.text = "Loading.";
        }
        else if(Mathf.Floor(Time.time) % 3 == 1)
        {
            txtloading.text = "Loading..";
        }
        else if(Mathf.Floor(Time.time) % 3 == 2)
        {
            txtloading.text = "Loading...";
        }


        if (Mathf.Floor(Time.time) % 15 == 0){
            loading[0].SetActive(true);
        }

        else if (Mathf.Floor(Time.time) % 15 == 1){
            loading[1].SetActive(true);
        }

        else if (Mathf.Floor(Time.time) % 15 == 3){
            loading[2].SetActive(true);
        }

        else if (Mathf.Floor(Time.time) % 15 == 5){
            loading[3].SetActive(true);
        }

        else if (Mathf.Floor(Time.time) % 15 == 6){
            loading[4].SetActive(true);
        }

        else if (Mathf.Floor(Time.time) % 15 == 7){
            loading[5].SetActive(true);
        }

        else if (Mathf.Floor(Time.time) % 15 == 8){
            loading[6].SetActive(true);
        }

        else if (Mathf.Floor(Time.time) % 15 == 9){
            loading[7].SetActive(true);
        }

        else if (Mathf.Floor(Time.time) % 15 == 10){
            loading[8].SetActive(true);
        }

        else if (Mathf.Floor(Time.time) % 15 == 14){
            loading[9].SetActive(true);
        }
    }
}
