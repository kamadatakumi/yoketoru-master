using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveBall : MonoBehaviour {
	public Text CountText;
	public float vx = -10f;
	public float vy = -10f;
	private Rigidbody rig;
	public float MIN_X = -9f;
	public float MAX_X = 9f;
	public float MIN_Y = -4f;
	public float MAX_Y = 6f;

	private static int BallCount=0;

    public static void ClearBallCount(){
        BallCount = 0;
    }


	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody> ();
	/*	rig.velocity = new Vector3 (vx, vy, 0f);

	Vector3 pos = new Vector3(
		Random.Range (MIN_X, MAX_X),
		Random.Range (MIN_Y, MAX_Y),
		0f);
	transform.position = pos;*/
		if(CompareTag("Item")){
		BallCount++;
	Debug.Log(BallCount);
		//CountText.text = "" + BallCount;
	}
	}


	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col){
        if (col.CompareTag("Player"))
        {
            if (CompareTag("Item"))
            {
                GameParams.AddScore(100);
                Destroy(gameObject);

                BallCount--;
                //CountText.text = "" + BallCount;
                if (BallCount <= 0)
                {
                    GameManager.NextScene = "Clear";
                }
            }
        }
    }
	void OnDestroy(){

	}
}
