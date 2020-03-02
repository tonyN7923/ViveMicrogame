using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowling : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource pin;
    public AudioClip pinKnock;
    public AudioClip strike;
    public AudioClip turkey;

    public bool didHit = false;
    public bool didStrike = false;
    public bool didTurkey = false;

    void Start()
    {
        pin = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (didHit)
        {
            pin.PlayOneShot(pinKnock);
            didHit = false;
        }

        if (didStrike)
        {
            pin.PlayOneShot(strike);
            didStrike = false;
        }

        if (didTurkey)
        {
            pin.PlayOneShot(turkey);
            didTurkey = false;
        }
    }
}
