using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] characters;

    public static GameManager instance;
    private int _charIdx;
    public int numberOfPlayer = 0;
    public int CharIdx
    {
        get { return _charIdx; }
        set { _charIdx = value; }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {

        if (scene.name == "Gameplay")
        {
            // Remove existing player
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                Destroy(GameObject.FindGameObjectWithTag("Player"));
            }
            Instantiate(characters[CharIdx]);
        }

    }
}
