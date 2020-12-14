using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToLoginBehaviour : MonoBehaviour
{
    public void OnBackToLoginButtonPressed()
    {

        NetworkClient client = FindObjectOfType<NetworkClient>();
        Destroy(client.gameObject);
        Debug.Log("Back To Start Button Pressed");
        SceneManager.LoadScene("Start Menu");
    }
}
