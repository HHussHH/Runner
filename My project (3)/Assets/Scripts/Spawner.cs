using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject spawnObj;
    [SerializeField] List<GameObject> spawnPoint = new List<GameObject>();
    [SerializeField] private List<GameObject> spawnObjToDelete = new List<GameObject>();
    [SerializeField] private List<GameObject> house = new List<GameObject>();
    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text dead;
    [SerializeField] private TMP_Text deadScore;
    [SerializeField] private GameObject restartButton;
    private int Scores = -10;
  
    int i = -1;
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "House")
        {
            i++;
            Scores += 10;
            score.text = "Score:"+Scores.ToString();
        }
    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dead")
        {
            score.enabled = false;
            dead.gameObject.SetActive(true);
            player.SetActive(false);
            deadScore.gameObject.SetActive(true);
            deadScore.text = score.text;
            restartButton.SetActive(true);

        }
    }
    // Update is called once per frame
    /*void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            spawnObjToDelete.Add(Instantiate(spawnObj, spawnPoint[i].transform.position, Quaternion.identity));
            

        }

        if(Input.GetMouseButtonDown(1))
        {
            foreach (var obj in spawnObjToDelete)
            {
                obj.AddComponent<Rigidbody2D>();
                obj.GetComponent<Collider2D>().enabled = false;
                obj.GetComponent<Rigidbody2D>().simulated = true;
                
                obj.GetComponent<Rigidbody2D>().freezeRotation = true;
            }
            foreach (var house in house)
            {
                house.GetComponent<Collider2D>().enabled = false;
            }
        }
    */

    private void OnMouseEnter()
    {
        spawnObjToDelete.Add(Instantiate(spawnObj, spawnPoint[i].transform.position, Quaternion.identity));
    }

    private void OnMouseExit()
    {
        
        foreach (var obj in spawnObjToDelete)
        {
            obj.AddComponent<Rigidbody2D>();
            obj.GetComponent<Collider2D>().enabled = false;
            obj.GetComponent<Rigidbody2D>().simulated = true;

            obj.GetComponent<Rigidbody2D>().freezeRotation = true;
        }
        /*foreach (var house in house)
        {
            house.GetComponent<Collider2D>().enabled = false;
        }*/
    }

}

