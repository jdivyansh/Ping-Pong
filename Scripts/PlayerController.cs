using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer
{
    PlayerLeft,
    PlayerRight
}

public class PlayerController : MonoBehaviour
{
    public float speed = 15f, inputSpeed = 0f;
    public ePlayer player;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        //float inputSpeed = 0f;
        if (player == ePlayer.PlayerLeft)
        {
        float inputSpeed = Input.GetAxisRaw("PlayerLeft");
        }
        else if (player == ePlayer.PlayerRight)
        {
        float inputSpeed = Input.GetAxisRaw("PlayerRight");
        }
        transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
    }
}
