using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidConroller : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;
    private Rigidbody2D rigidbody2D;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {

        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0, -speed);

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        
    }

    // Update is called once per frame
    void Update()
    {
        // *2 ist ein pufer
        if(-transform.position.y > screenBounds.y * 2){
            Destroy(this.gameObject);
        }
    }
}
