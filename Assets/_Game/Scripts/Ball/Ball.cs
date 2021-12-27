using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private bool gameStarted;
    [SerializeField] private float directionX;
    [SerializeField] private float directionY;
    [SerializeField] private float directionRadomX;
    [SerializeField] private float directionRadomY;

    private Rigidbody2D rig;

    private bool isSpacePressed;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rig = GetComponent<Rigidbody2D>();
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        Getinputs();
    }
    private void FixedUpdate()
    {
        ThrowBall();
    }
    void Getinputs()
    {
        isSpacePressed = Input.GetKey(KeyCode.Space);
    }
    private void ThrowBall()
    {
        if (!gameStarted && isSpacePressed)
        {
            rig.velocity = new Vector2(directionX * Time.fixedDeltaTime, directionY * Time.fixedDeltaTime);
            gameStarted = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
        rig.velocity += new Vector2(directionRadomX, directionRadomY);
    }
}
