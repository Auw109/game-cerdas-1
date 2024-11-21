using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : BaseState
{
    // Function yang akan dipanggil ketika state patrol dimulai
    public void EnterState(Enemy enemy)
    {
        Debug.Log("Start Patrol");
    }

    // Function yang akan dipanggil ketika state patrol berhenti 
    public void ExitState(Enemy enemy)
    {
        Debug.Log("Stop Patrol");
    }

    // Function yang akan dipanggil selama state patrol berjalan
    public void UpdateState(Enemy enemy)
    {
        Debug.Log("Patrolling");
    }
}