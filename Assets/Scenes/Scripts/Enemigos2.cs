using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos2 : Enemigos

{
    [SerializeField]
    [Range(1f, 30f)]
    private float jumpForce = 2f;

    private Rigidbody rbEnemy = null;

    private void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();
        InvokeRepeating("JumpEnemy", 0f, 2f);
    }

    private void JumpEnemy()
    {
        rbEnemy.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        Debug.Log("Saltando");
    }    
    // Debo borrar todo lo que no uso del original, por eso no pongo en Update. hereda lo que se hizo en el padre.
    
}
