using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemoTest : MonoBehaviour
{
    public GameObject question;
    public GameObject memoT;
    public GameObject rentry;
    public GameObject win;
    public Texture[] tag;
    RawImage img;
    [SerializeField] GameObject[] pieces;
    [SerializeField] int[] randoms = new int[18];


    // Start is called before the first frame update
    void Start()
    {
        randoms = randomArray0to8();

        for (int i = 0; i < 18; i++)
        {
            img = pieces[i].GetComponent<RawImage>();
            img.texture = tag[randoms[i]];
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Accept()
    {
        question.SetActive(false);
        memoT.SetActive(true);
    }

    public void Fail()
    {
        memoT.SetActive(false);
        rentry.SetActive(true);
    }

    public void Rentry()
    {
        memoT.SetActive(true);
        rentry.SetActive(false);
    }

    public void WinGame()
    {
        memoT.SetActive(false);
        win.SetActive(true);
    }

    int[] randomArray0to8() {
        int[] randomArray = new int[18];
        int[] repeated_numbers = new int[9];
        for (int i = 0; i < 18; i++) {
            int random = Random.Range(0, 9);
            if (repeated_numbers[random] < 2) {
                randomArray[i] = random;
                repeated_numbers[random]++;
            }
            else {
                i--;
            }
        }
        return randomArray;
    }

    public void PieceClick(){
        GameObject btn = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        GameObject tag = btn.transform.GetChild(1).gameObject;
        Debug.Log(tag);
        tag.SetActive(true);
    }
}