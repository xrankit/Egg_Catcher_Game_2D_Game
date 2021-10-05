using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggFall : MonoBehaviour
{
    public GameObject egg;
    private GameObject runEgg;
    public GameObject Bomb;
    private GameObject runBomb;
    public Transform canvas;
    private RectTransform rectTransform;
    public float timediff1 = 0.10f;
    private float nextcall1;
    public float timediff2 = 5.00f;
    private float nextcall2;

    // Start is called before the first frame update
    void Start()
    {
        nextcall1 = Time.time + timediff1;
        nextcall2 = Time.time + timediff2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextcall1)
        {
            instEgg();
            nextcall1 = Time.time + timediff1;
        }
        if (Time.time >= nextcall2)
        {
            instBomb();
            nextcall2 = Time.time + timediff2;
        }

    }
    void instEgg()
    {
        runEgg = Instantiate(egg, transform.position, Quaternion.identity);
        runEgg.transform.SetParent(canvas, false);
        rectTransform = runEgg.GetComponent<RectTransform>();
        rectTransform.localPosition = rectTransform.localPosition + new Vector3(Random.Range(-800f,Screen.width-800f), 0, 0);
    }

    void instBomb()
   {
        runBomb = Instantiate(Bomb, transform.position, Quaternion.identity);
        runBomb.transform.SetParent(canvas, false);
        rectTransform = runBomb.GetComponent<RectTransform>();
        rectTransform.localPosition = rectTransform.localPosition + new Vector3(Random.Range(-800f, Screen.width - 800f), 0, 0);
    }
}


