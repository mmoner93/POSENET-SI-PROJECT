using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlScript : MonoBehaviour
{
    public static controlScript instance;
    private int counter = 0;
    public GameObject sphere;
    void Awake()
    {
        instance = this;


    }

    void Update()
    {
        if (counter == 6)
        {
            sphere.SetActive(true);

        }

    }

    public void setCounter()
    {
        counter++;
    }

    public int getCounter()
    {
        return counter;

    }


}
