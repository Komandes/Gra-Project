using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject Button;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         Destroy(gameObject);
         GameOver.SetActive(true);
         Button.SetActive(true);
    }
}
