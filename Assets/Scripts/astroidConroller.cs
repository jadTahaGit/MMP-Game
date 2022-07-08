using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidConroller : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0, -speed);
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
