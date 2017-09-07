using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public float MAX_SPEED = 10f;
    public Bounds MoveBounds; 

    void OnDrawGizmos(){
        Gizmos.DrawWireCube(MoveBounds.center, MoveBounds.size);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 mpos = Input.mousePosition;
		mpos.z = transform.position.z - Camera.main.transform.position.z;
		Vector3 target = Camera.main.ScreenToWorldPoint (mpos);

		//Vector3 dir = target - transform.position;
		Vector3 newpos = Vector3.MoveTowards (
			                 transform.position,
			                 target,
			                 MAX_SPEED * Time.deltaTime);

		//newpos.x = Mathf.Clamp(newpos.x, MoveBounds.min.y, MoveBounds.max.y);
		//newpos.y = Mathf.Clamp(newpos.y, MoveBounds.min.y, MoveBounds.max.y);

		newpos.x = Mathf.Clamp(newpos.x, -10f, 10f);
		newpos.y = Mathf.Clamp(newpos.y, -4f, 6f);

		transform.position = newpos;
	}

	void OnTriggerEnter(Collider col){
		if(col.CompareTag("Teki")){
			Destroy (gameObject);
            GameManager.NextScene = "GameOver";
		}
	}
}
