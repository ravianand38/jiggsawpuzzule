﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameplayController : MonoBehaviour {

	public void BackToSelectPuzzleMenu() {
		SceneManager.LoadScene("SelectPuzzleMenu");
	}

}
