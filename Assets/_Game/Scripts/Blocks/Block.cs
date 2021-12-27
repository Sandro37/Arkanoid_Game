using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private GameObject audioSource;

    private void Awake()
    {
        FindObjectOfType<GameManager>().IncreaseBlockAmount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            FindObjectOfType<GameManager>().DecreaseBlockAmount();
            Destroy(gameObject);
            GameObject audio = Instantiate(audioSource);
            Destroy(audio, 1f);
        }
    }
}
