using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum State
    {idle,
     walking,
     swimming,
     climbing
      
    }

    public State mainstate = State.idle;
    Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;


    }

    void Update()
    {
        switch (mainstate)
        {
            case State.idle:
                Idle();
                break;
                
            case State.walking:Walking(); break;
            case State.swimming:Swimming(); break;
            case State.climbing:Climbing(); break;
            default:break;

        }
    }

     void OnTriggerEnter(Collider other)
     {
        if (other.name == "WaterTrigger")
        {
            mainstate = State.swimming; 
        }
        else if (other.name== "MountainTrigger")
        {
            mainstate = State.climbing;
        }
     }
     void OnTriggerExit(Collider other)
    {
        mainstate = State.walking;
    }
    void Swimming()
    {
        Debug.Log("I'm Swimming");
    }
    void Climbing()
    {
        Debug.Log("I'm Climbing");
    }
    void Idle()
    {
        Debug.Log("Im idle");
        if(lastPosition != transform.position)
        {
            mainstate = State.walking;
        }
        lastPosition = transform.position;

    }
    void Walking()
    {
        Debug.Log("I'm walking");
        if(lastPosition== transform.position)
        {
            mainstate = State.idle;
        }
        lastPosition = transform.position;
    }



}
