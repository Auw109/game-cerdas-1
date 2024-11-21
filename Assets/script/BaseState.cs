using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface BaseState
{
    // Abstract untuk function EnterState.
    // Function ini nantinya akan digunakan untuk menulis implementasi kode yang akan
    // dilakukan ketika suatu state mulai berjalan.
    public void EnterState(Enemy enemy);

    // Abstract untuk function UpdateState.
    // Function ini nantinya akan digunakan untuk menulis implementasi kode yang akan
    // dilakukan selama state berjalan
    public void UpdateState(Enemy enemy);

    // Abstract untuk function ExitState.
    // Function ini nantinya akan digunakan untuk menulis implementasi kode yang akan
    // dilakukan ketika suatu state berhenti berjalan.
    public void ExitState(Enemy enemy);
}