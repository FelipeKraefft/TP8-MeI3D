using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour
{
    public Text pass;
    public GameObject Incorrect;
    public GameObject Correct;

    GameObject PassScreen;
    GameObject MiniGame;

    // Start is called before the first frame update
    void Start()
    {
        PassScreen = GameObject.Find("PassScreen");
        MiniGame = GameObject.Find("MiniGame");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Check()
    {
        if (pass.text == "DaroNoEsta")
        {
            Incorrect.SetActive(false);
            Correct.SetActive(true);
            Invoke("ChangeScreen", 2);
        }
        else{
            pass.text = "";
            Incorrect.SetActive(true);
        }
    }

    void ChangeScreen()
    {
        PassScreen.SetActive(false);
        MiniGame.SetActive(true);
    }
}
