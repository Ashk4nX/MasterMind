using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Brain : MonoBehaviour {

	public Transform Player;

	// Use this for initialization
	void Start () {

		DOTween.Init(false, true, LogBehaviour.ErrorsOnly);
		
	}
	
	// Update is called once per frame
	void Update () {

		Move ();

	}

	void Move (){

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {

			Player.DOMove(new Vector3(-2, 0, 0), 1).SetRelative().SetLoops(0, LoopType.Restart);

		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {

			Player.DOMove(new Vector3(2, 0, 0), 1).SetRelative().SetLoops(0, LoopType.Restart);

		}

	}
}
