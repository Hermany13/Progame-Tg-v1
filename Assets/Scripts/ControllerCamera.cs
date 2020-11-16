using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : MonoBehaviour
{
    private Vector2 velocidade;

    private Transform player;

    public float smoothTimeX;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }


   
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.position.x, ref velocidade.x, smoothTimeX);

        transform.position = new Vector3(posX, transform.position.z);
    }
}
