using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsCanvasBehaviour : MonoBehaviour
{

    public Text myCoins;
    // Start is called before the first frame update
    void Start()
    {
        myCoins.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCoins();
    }

    public void UpdateCoins()
    {
        string myPoints = "";
        for (int i = 0; i < CapsuleGenBehaviour.points; i++)
        {
            myPoints = myPoints + "█ ";
        }
        myCoins.text = myPoints;
    }
}
