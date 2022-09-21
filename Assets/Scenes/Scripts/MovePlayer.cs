using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float speed = 2f;

    public float movX;
    public float movZ;

    public float CameraAxisX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(movX, 0, movZ);
        transform.Translate(direction.normalized * speed * Time.deltaTime);
    }
    // rotación del player
    public void RotatePlayer()
    {
        CameraAxisX += Input.GetAxis("Mouse X");
        
       
        Quaternion newRotation = Quaternion.Euler(0, CameraAxisX * 2f, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2f * Time.deltaTime);

    }
}
