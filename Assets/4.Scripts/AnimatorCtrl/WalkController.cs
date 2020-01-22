﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkController : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) == true)
        {
            animator.SetFloat("Move", 1.0f, 0.1f, Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S) == true)
        {

        }
        else if(Input.GetKey(KeyCode.A) == true)
        {
            animator.SetFloat("Direction", -1.0f, 0.1f, Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D) == true)
        {
            animator.SetFloat("Direction", 1.0f, 0.1f, Time.deltaTime);
        }
        else
        {
            animator.SetFloat("Direction", 0.0f, 0.1f, Time.deltaTime);
            animator.SetFloat("Move", 0.0f, 0.1f, Time.deltaTime);
        }

    }
}
