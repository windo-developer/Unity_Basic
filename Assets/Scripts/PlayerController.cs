using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _speed = 10.0f;
    public GameObject _obj;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime * _speed;
        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime * _speed;
        if (Input.GetKey(KeyCode.A))
            transform.position -= new Vector3(1.0f, 0.0f, 0.0f) * Time.deltaTime * _speed;
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(1.0f, 0.0f, 0.0f) * Time.deltaTime * _speed;
    }
}