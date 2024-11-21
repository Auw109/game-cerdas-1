using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public Action<Pickable> OnPick;

    [SerializeField]
    public PickableType PickableType;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Memastikan ada yang subscribe event OnPicked
            if (OnPick != null)
            {
                // Memanggil event OnPicked ketika object pickable diambil
                OnPick(this);
            }
        }
    }
}