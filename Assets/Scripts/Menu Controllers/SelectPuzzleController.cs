using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SelectPuzzleController : MonoBehaviour {

	public void SelectPuzzle() {

		string[] name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name.Split ();

		int index = int.Parse (name[1]);

		//Debug.Log("You select puzzle number " + index);

		if (GameManager.instance != null) {
			GameManager.instance.SetPuzzleIndex(index);
		}

		SceneManager.LoadScene("Gameplay");
	}

	public void BackToMainMenu() {
		SceneManager.LoadScene("MainMenu");
	}
}
