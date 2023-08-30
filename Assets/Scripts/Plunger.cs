using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Plunger : MonoBehaviour
{

    public float delay = 3F;
    public float radius = 0.2F;
    public float impulsePower = 20F;

    private Rigidbody[] balls;

    private void Start()
    {
        balls = FindObjectsOfType<Rigidbody>();
    }

    private void Update()
    {
        delay -= Time.deltaTime;
        if(delay <= 0)
        {
            KickBall();
            delay = 3F;
        }
    }

    private void KickBall()
    {
        foreach (Rigidbody ball in balls)
        { 
            if(Vector3.Distance(transform.position, ball.transform.position) < radius)
            {
                ball.AddForce(Vector3.forward * impulsePower, ForceMode.Impulse);
            }
            
        }
    }



}
