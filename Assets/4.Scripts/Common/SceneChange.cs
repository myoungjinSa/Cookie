using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeToLoginScene()
    {
        SceneManager.LoadScene("Login");
    }
    public void ChangeToLobbyScene()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void ChangeToBattleScene()
    {
        SceneManager.LoadScene("Battle");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
