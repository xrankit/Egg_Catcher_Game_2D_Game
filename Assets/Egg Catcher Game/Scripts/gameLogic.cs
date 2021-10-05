using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour
{
    public GameObject egg;
    public GameObject Bomb;
    private GameObject runEgg;
    private GameObject runBomb;
    public Transform canvas;
    private RectTransform rectTransform;
    public float timedifference1 = 1.10f;
   // public float timedifference2 = 6.00f;
    private float nextruntime1;
    //private float nextruntime2;
    // Start is called before the first frame update
    void Start()
    {
        nextruntime1 = Time.time + timedifference1;
       // nextruntime2 = Time.time + timedifference2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextruntime1)
        {
            instEgg();
            nextruntime1 = Time.time + timedifference1;
        }
       // if (Time.time >= nextruntime2)
       //{
       //     instBomb();
      //      nextruntime2 = Time.time + timedifference2;
       // }

    }
    void instEgg()
    {
        runEgg = Instantiate(egg, transform.position, Quaternion.identity);
        runEgg.transform.SetParent(canvas, false);
        rectTransform = runEgg.GetComponent<RectTransform>();
        rectTransform.localPosition = rectTransform.localPosition + new Vector3(Random.Range(-900f, 100f), 0, 0);
    }

    //void instBomb()
    //{
   //     runBomb = Instantiate(Bomb, transform.position, Quaternion.identity);
   //     runBomb.transform.SetParent(canvas, false);
   //     rectTransform = runBomb.GetComponent<RectTransform>();
   //     rectTransform.localPosition = rectTransform.localPosition + new Vector3(Random.Range(-900f, 100f), 0, 0);
   // }
}
