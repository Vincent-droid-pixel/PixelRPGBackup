using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudButton : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        open = false;
    }
    private bool open;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (open == false)
            {
                anim.SetTrigger("Open");
                open = true;
            }
            else if (open == true)
            {
                anim.SetTrigger("Closed");
                open = false;
            }  
        }
    }
}
