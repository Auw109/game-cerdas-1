using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : BaseState
{
    // Function yang akan dipanggil ketika state chase dimulai
    public void EnterState(Enemy enemy)
    {
        Debug.Log("Start Chase");
    }

    // Function yang akan dipanggil selama state chase berjalan
    public void UpdateState(Enemy enemy)
    {
        Debug.Log("Chasing");
    }

    // Function yang akan dipanggil ketika state chase berhenti
    public void ExitState(Enemy enemy)
    {
        Debug.Log("Stop Chase");
    }
}