using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerFollow : MonoBehaviour
{
public NavMeshAgent Enemy;
public Transform Player;

private void Start()
{

}

private void Update()
{
Enemy.SetDestination(Player.position);
}
}
