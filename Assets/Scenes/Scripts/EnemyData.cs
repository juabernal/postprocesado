using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Enemy Data", menuName = "Crear Enemy Data")]
public class EnemyData : ScriptableObject
{
    [Header("Configuraciones")]
    [Tooltip("rango entre 1 y 30")]

    [SerializeField]
    [Range(1f, 10f)]
    public float speed = 5f;

    
    [Header("Configuración de Ataque")]

    [SerializeField]
    [Range(1f, 30f)]
    public float rangeAttack = 2f;

}
