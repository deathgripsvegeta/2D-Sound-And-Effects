using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float jumpForce = 10;
    public bool isOnGround = false;

    private Rigidbody2D _playerRB;

    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            _playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
        }
    }
}
private void OnCollisionEnter2D(Collision2D other)
{
    if(other.gameObject.CompareTag("ground"))
    {
        isOnGround = true;

    }

}
