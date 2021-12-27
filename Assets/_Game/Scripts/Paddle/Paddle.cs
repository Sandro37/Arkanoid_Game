using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private float velocity;

    [Header("Limite da tela")]
    [SerializeField] private float Xmin;
    [SerializeField] private float XMax;

    private float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, Xmin, XMax), transform.position.y);

        horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(new Vector2(horizontal * velocity * Time.deltaTime, 0));
    }
}
