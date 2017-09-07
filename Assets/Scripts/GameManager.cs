using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
　　//敵
    public GameObject prefTeki;
    public int TekiCount = 4;
    //アイテム
    public GameObject prefItem;
    public int ItemCount = 10;

    private static string _NextScene = "";
	//次のシーンを指定する。空の場合は何もしない。
	public static string NextScene{
        get {return _NextScene; }
        set {
        if((_NextScene != "Clear")
            || (value == ""))
        {
            _NextScene = value;
            Time.timeScale = 0;
        }
    }
}
	// Use this for initialization
	void Start () {
        //time.timescale=1;
        GameParams.SetScore(0);
        _NextScene = "";
        moveBall.ClearBallCount();

       /* for (int i = 0; i < TekiCount; i++){
            Instantiate(prefTeki);
        }
        for (int i = 0; i < ItemCount; i++){
            Instantiate(prefItem);
        }*/
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O)){
			NextScene = "GameOver";
	}
		else if(Input.GetKeyDown(KeyCode.C)){
			NextScene = "Clear";
		}
        else if (Input.GetKey (KeyCode.A)){
            GameParams.AddScore(000001);
        }
		if(NextScene.Length > 0){
			SceneManager.LoadSceneAsync (NextScene,LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
}
}
