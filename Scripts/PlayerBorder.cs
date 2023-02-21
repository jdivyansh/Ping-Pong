using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorder : MonoBehaviour
{
    public ePlayer player;
    public ScoreUI score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);
            if(player == ePlayer.PlayerRight) score.scorePlayerLeft++;
            if(player == ePlayer.PlayerLeft) score.scorePlayerRight++;
        }
    }
}
