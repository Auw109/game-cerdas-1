using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
// Membuat tiga state behaviour yang dimiliki AI enemy
    public PatrolState PatrolState = new PatrolState();
    public ChaseState ChaseState = new ChaseState();
    public RetreatState RetreatState = new RetreatState();

    // Membuat variable untuk menyimpan state yang sedang dijalankan AI enemy
    private BaseState _currentState;

    private void Awake()
    {
        // Set current state diawal sebagai patrol state
        _currentState = PatrolState;
        // Mulai menjalankan state nya
        _currentState.EnterState(this);
    }

    private void Update()
    {
        // Mengecek apakah ada current state yang sedang dijalankan
        if (_currentState != null)
        {
            // Jika ada state yang sedang dijalankan maka jalankan update state
            _currentState.UpdateState(this);
        }
    }
}



