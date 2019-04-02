using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaBehaviour : MonoBehaviour
{
    public AudioSource fire_sound;
    // Start is called before the first frame update
    void Start()
    {
        fire_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        fire_sound.Play();
    }
}
