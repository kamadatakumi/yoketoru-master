using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killcheck : MonoBehaviour 
{
	void OnTriggerEnter(Collider col){
		Destroy (gameObject);
	}
	void OnMouseEnter()
	{
		//Destroy (gameObject);
		//消す
		//SetActive 見えなくする
		//Time.timeScale=0f;
	}
}