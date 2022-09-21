using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos3 : Enemigos
{
    [SerializeField] Transform playerTransform;

    private void LookAt()
    {
        transform.LookAt(playerTransform);
    }

    //Override para poder pisar el comportamiento del padre.
    protected override void Move()
    {
        LookAt();
        Vector3 direction = (playerTransform.position - transform.position);
        if (direction.magnitude > 2f)
        {
            transform.position += direction.normalized * enemyData.speed * Time.deltaTime;
        }
    }

}
