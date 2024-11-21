using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Mengakses komponen rigidbody
    [SerializeField]
    private Rigidbody _rigidbody;
    // Menentukan besar kecepatan gerak character
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Transform _camera;
    
    private void Start()
    {
        // Lock cursor di tengah layar
        Cursor.lockState = CursorLockMode.Locked;
        // Menyembunyikan cursor
        Cursor.visible = false;
    }
    
    private void Update()
    {
        // Jika menekan tombol Horizontal positif(Panah Kanan/D), variable horizontal akan bernilai 1 
        // Jika menekan tombol Horizontal negatif(Panah Kiri/A), variable horizontal akan bernilai -1 
        // Jika tidak menekan tombol Horizontal, variable horizontal akan bernilai 0 
        float horizontal = Input.GetAxis("Horizontal");
        // Jika menekan tombol Vertical positif(Panah Atas/W), variable vertical akan bernilai 1 
        // Jika menekan tombol Vertical negatif(Panah Bawah/S), variable horizontal akan bernilai -1 
        // Jika tidak menekan tombol Vertical, variable horizontal akan bernilai 0 
        float vertical = Input.GetAxis("Vertical");

        // Menentukan arah gerakan horizontal/samping
        Vector3 horizontalDirection = horizontal * _camera.right;
        // Menentukan arah gerakan vertical/depan&belakang
        Vector3 verticalDirection = vertical * _camera.forward;
        // Memastikan arah sumbu y di vertical dan horizontal tidak dihitung
        verticalDirection.y = 0;
        horizontalDirection.y = 0;

        // Menghitung total gerakan horizontal dan vertical
        Vector3 movementDirection = horizontalDirection + verticalDirection;

        _rigidbody.velocity = movementDirection * _speed * Time.deltaTime;
    }
}