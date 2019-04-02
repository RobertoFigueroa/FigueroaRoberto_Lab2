using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBehaviour : MonoBehaviour
{
    public static AudioSource coin_sound;
    // Start is called before the first frame update
    void Start()
    {
        coin_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 2, 0);
     
    }
    private void OnTriggerEnter(Collider other)
    {
        coin_sound.Play();
    }

}
