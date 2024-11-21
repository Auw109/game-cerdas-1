using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableManager : MonoBehaviour
{
    // List dari object pickable
    private List<Pickable> _pickableList = new List<Pickable>();

    private void Start()
    {
        InitPickableList();
    }

    // Function untuk menambahkan object pickable ke list
    private void InitPickableList()
    {
        // Mencari pickable object yang memiliki component script Pickable
        // Kemudian memasukkannya ke dalam array
        Pickable[] pickableObjects = GameObject.FindObjectsOfType<Pickable>();

        // Menambahkan pickable object satu persatu ke dalam list
        for (int i = 0; i < pickableObjects.Length; i++)
        {
            // Menambahkan pickable object ke dalam list
            _pickableList.Add(pickableObjects[i]);
            // Subscribe function OnPickablePicked ke dalam event OnPick
            pickableObjects[i].OnPick += OnPickablePicked;
        }

        // Memunculkan banyaknya element/isi list pickable
        Debug.Log("Pickable List: " + _pickableList.Count);
    }

    private void OnPickablePicked(Pickable pickable)
    {
        if (pickable.PickableType == PickableType.Coin)
        {
            Debug.Log("Player mengambil coin");
        }
        else if (pickable.PickableType == PickableType.PowerUp)
        {
            Debug.Log("Player mengambil power up");
        }
        // Menghapus object pickable yang diambil dari list pickable
        _pickableList.Remove(pickable);

        Destroy(pickable.gameObject);

        // Memunculkan banyaknya element/isi list pickable
        Debug.Log("Pickable List: " + _pickableList.Count);

        CheckWin();
    }

    private void CheckWin()
    {
        if (_pickableList.Count <= 0)
        {
            Debug.Log("Win");
        }
    }
}