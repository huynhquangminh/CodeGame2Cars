using UnityEngine;
using System.Collections;

public class GameMenuCotrol : MonoBehaviour {

	public void ClickPlay()
    {
        Application.LoadLevel("GamePlay");
    }
  public  void ClickQuit()
    {
        Application.Quit();
    }
}
