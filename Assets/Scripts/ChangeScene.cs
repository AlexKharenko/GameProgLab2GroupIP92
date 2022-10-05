using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public int SceneNumber = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (this.CompareTag("Finish") && other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneNumber);

        }
    }
}
