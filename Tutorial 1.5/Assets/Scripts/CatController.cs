using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clipOne;
    public AudioClip clipTwo;

    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            source.clip = clipOne;
            source.Play();
            anim.SetInteger("State", 1);
        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            source.Stop();
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            source.clip = clipTwo;
            source.Play();
            anim.SetInteger("State", 2);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            source.Stop();
            anim.SetInteger("State", 0);
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            source.loop = true;
        }

        if(Input.GetKeyUp(KeyCode.L))
        {
            source.loop = false;
        }

        if (Input.GetKey("escape"))
            Application.Quit();

    }
}
