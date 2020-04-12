﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Manager.Instance.tenthTrigger == true && Manager.Instance.eleventhTrigger == false)
        {
            Manager.Instance.eleventhTrigger = true;
            GameObject.Find("HeartBeat").GetComponent<AudioSource>().Stop();
        }
    }
}