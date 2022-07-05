using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitball : MonoBehaviour
{

    AudioClip impact;
    AudioSource bounce;


    // Start is called before the first frame update
    void Start()
    {
        bounce = GetComponent<AudioSource>();
        impact = bounce.clip;
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        bounce.PlayOneShot(impact, 0.1F);
    }
}
