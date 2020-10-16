using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examples : MonoBehaviour
{   public enum Ename
    {
        MrDoom,
        GoldenMatch,
        Mayor
       

    }
    public Ename tile= Ename.MrDoom;

    public string display_tile;
    // Start is called before the first frame update
    void Start()
    {
        switch (tile)
        {
            case Ename.Mayor:Debug.Log("I'm the Mayor"); break;
            case Ename.MrDoom: Debug.Log("I'm the Villan"); break;
            case Ename.GoldenMatch: Debug.Log("I'm the Hero"); break;
            default: Debug.Log("I'm the something"); break;

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
