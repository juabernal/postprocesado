using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    // Protected. Privado para padre e hijos.
    /*
     [SerializeField]
     [Range(1f, 10f)]
     protected float speed = 5f;

     [SerializeField]
     [Range(1f, 30f)]
     private float rangeAttack = 2f;
    */

    [SerializeField]
    protected EnemyData enemyData;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Move();
        Attack();


    }

    // Virtual para que pueda sobreescribirlo en el hijo
    protected virtual void Move()
    {
        transform.Translate(Vector3.forward * enemyData.speed * Time.deltaTime);
    }

    public void Attack()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up, transform.TransformDirection(Vector3.forward), out hit, enemyData.rangeAttack))
        {
            if (hit.transform.CompareTag("Player"))
            { 
                Debug.Log("ATACAR AL JUGADOR");
            }
        }
    }

    public void DrawRaycast()
    {
        Gizmos.color = Color.blue;
        Vector3 directionRay = transform.TransformDirection(Vector3.forward) * enemyData.rangeAttack;
        Gizmos.DrawRay(transform.position + Vector3.up, directionRay);
    }
    private void OnDrawGizmos()
    {
        DrawRaycast();
    }



}
    

