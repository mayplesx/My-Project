using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string LevelName; //Will be updated in Inspector to choose level
    public bool hasKey = false;

    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    private bool playerInRange;


    private void Awake()
    {
        playerInRange = false;
        visualCue.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }

    private void Update() //Portal must have a 2D Collider set to TRIGGER
    {
        if(playerInRange)
        {
            visualCue.SetActive(true);
            if(Input.GetKeyDown("e"))
            {
                Debug.Log("Portal is working");
                SceneManager.LoadScene(LevelName, LoadSceneMode.Single); //Tells Scenemanager to load Level
                                                                    //Loads it as a single scene
            }
        }
        else
        {
            visualCue.SetActive(false);
        }
    }
}