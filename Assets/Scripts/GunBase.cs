using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    [SerializeField] private float frameRate = 1.0f;
    private float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= frameRate)
        {
            time -= frameRate;
            Shoot();
        }
    }

    public virtual void Shoot()
    {
       

    }
}
