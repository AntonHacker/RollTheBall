using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killBox : MonoBehaviour
{
    void OnTriggerEnter(Collider all)
    {

        if (all.tag == "Player")
        {
            Application.LoadLevel(0);
        }
    }
}










