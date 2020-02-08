using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

//GameData, Item 클래스가 담긴 네임스페이스 명시
using DataInfo;


public class GameManager : MonoBehaviour
{
    //싱글턴에 접근하기 위한 Static 변수 선언
    public static GameManager instance = null;

   
    //게임 상태
    private enum GameState
    {
        NONE,
        LOGIN,
        LOBBY,
        BATTLE
    } 

    //게임 종료 여부를 판단할 변수
    public bool isGameOver = false;

    //DataManager를 저장할 변수
    private DataManager dataManager;
    [Header("GameData")]

    public GameData gameData;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            
            Debug.Log("Same Instance");
        }
        else if(instance != this)       //instance 에 할당된 클래스의 인스턴스가 다를 경우 새로 생성된 클래스를 의미함
        {
            Debug.Log("Other Instance");
            Destroy(this.gameObject);

        }

        //다른 씬으로 넘어가도 삭제하지 않도록 유지함
        DontDestroyOnLoad(this.gameObject);
       
        //Data Manager를 추출해 저장
        dataManager = GetComponent<DataManager>();
       
        //DataManager 초기화
        //dataManager.Initialize();

        //LoadGameData();

    }
    //게임의 초기 데이터 로드
    void LoadGameData()
    {
        
        //Data Manager 를 통해 파일에 저장된 데이터 불러오기
        GameData data = dataManager.Load();

        gameData.moveSpeed = data.moveSpeed;


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
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("GM - START Call");
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
