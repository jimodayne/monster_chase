using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    string characterName;
    private const string PLAYER_0 = "Player 0";
    private const string PLAYER_1 = "Player 1";
    int selectedCharacter;


    public void PlayGame()
    {
        characterName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        switch (characterName)
        {
            case PLAYER_0:
                selectedCharacter = 0;
                break;
            case PLAYER_1:
                selectedCharacter = 1;
                break;
            default:
                // code block
                break;
        }

        GameManager.instance.CharIdx = selectedCharacter;

        SceneManager.LoadScene("Gameplay");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
