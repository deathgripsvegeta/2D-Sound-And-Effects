using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float moveSpeed = 10;

    private PlayerControl _playerScript;
       void Start()
    {
        _playerScript = GameObject.Find("player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_playerScript.isGameOver == false)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
         
    }
}
