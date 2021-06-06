using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceFighter : MonoBehaviour
{
    public GameObject laserPrefab;
    public Transform firePos;

    [SerializeField]
    private float _speed;
    private float _xRange;

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        FireProjectile();
    }

    private void CalculateMovement()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hInput, vInput, 0) * _speed * Time.deltaTime);

        if (transform.position.x > _xRange)
        {
            transform.position = new Vector3(_xRange, transform.position.y, 0);
        }
        else if (transform.position.x < -_xRange)
        {
            transform.position = new Vector3(-_xRange, transform.position.y, 0);
        }
    }

    void FireProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, firePos.position, Quaternion.identity);
        }
    }
}
