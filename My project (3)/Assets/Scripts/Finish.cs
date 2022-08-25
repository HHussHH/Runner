using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TMP_Text finishText;
    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text scoreOnGame;
    [SerializeField] private GameObject buttonRestart;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player.SetActive(false);
            finishText.gameObject.SetActive(true);
            score.text = scoreOnGame.text;
            score.gameObject.SetActive(true);
            scoreOnGame.gameObject.SetActive(false);
            buttonRestart.SetActive(true);
        }
    }


    public void ButtonRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
