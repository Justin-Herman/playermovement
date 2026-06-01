using System.Diagnostics;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public int playerspeed;
    public int enemyspeed;

    public int enemyhealth;

    private int damageovertime;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (playerspeed == 0) 
        {
            if (playerspeed > enemyspeed) 
               print("player moves first");
        }
        else
        {
            if (enemyspeed > playerspeed) 
                print("enemy moves first");
        }

        int enemyhealth = 100;

        if (Input.GetKey(KeyCode.E))
        {
           print(enemyhealth = 100 - 15);
        }

        int damageovertime = 10;

        if (damageovertime =>10)
        {
            damageovertime++
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
           print("Enemy has taken damage");
        }

       

    }
}
