using UnityEngine;

public class ItemSorting : MonoBehaviour
{
    public float movespeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playermovement linearVelocityX(0,0,1);
        playermovement linearVelocityY(0,1,0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playermovement linearVelocityX(0,0,1);
        }
        else (Input.GetKey(KeyCode.A))
                { playermovement linearVelocityX(0,0,-1); }


        if (Input.GetKey(KeyCode.W))
        {
            playermovement linearVelocityY(0,1,0);
        }
        else (Input.GetKey(KeyCode.S))
        {
            playermovement linearVelocityY(0,-1,0);
        }
    }
}
