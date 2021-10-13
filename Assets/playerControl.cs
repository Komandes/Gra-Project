using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    float movementSpeed = 6;
    float jumpForce = 7;
    public int hp = 4;
    public GameObject GameOver;
    public GameObject Button;
   
    private Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        GameOver.SetActive(false);
        Button.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001F)
        {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

    }

    public void GetHit()
    {
        hp--;
        if(hp <= 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            GameOver.SetActive(true);
            Button.SetActive(true);

        }
    }
  
}
