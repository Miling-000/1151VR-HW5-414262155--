using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class ball_controller : MonoBehaviour
{
    public void Shoot(Vector3 direction)
    {
        GetComponent<Rigidbody>().AddForce(direction);
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    void Start()
        {
            Application.targetFrameRate = 60;
        Shoot(new Vector3(300, 50, 300));
    }


   
    void Update()
    {
        
    }
}
