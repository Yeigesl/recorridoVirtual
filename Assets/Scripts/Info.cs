using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{
    public GameObject information;
    public Collider player;

    private void OnTriggerEnter(Collider player)
    {
        //SceneManager.LoadScene(1);
        information.SetActive(true);
    }

}
