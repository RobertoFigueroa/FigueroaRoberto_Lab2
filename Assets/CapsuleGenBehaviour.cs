using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleGenBehaviour : MonoBehaviour
{

    //variable para controlar las instancias del objeto:
    private GameObject currPlayer;
    public GameObject player;
    public static int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (player && !currPlayer)
            {
                currPlayer = Instantiate(player, new Vector4(-11.8f, 0.75f, 7.08f), Quaternion.identity);
            }
        }
    }
}
