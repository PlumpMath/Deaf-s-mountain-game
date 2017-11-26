using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour {
    public Text titre;
    public GameObject button;
    public Text play;
    public IEnumerator Start()
    {
        titre.canvasRenderer.SetAlpha(0.0f);
        play.canvasRenderer.SetAlpha(0.0f);
        Fadein(titre);
        yield return new WaitForSeconds(2);
        button.SetActive(true);
        Fadein(play);
        yield return new WaitForSeconds(1);
    }
    void Fadein(Text texT)
    {
        texT.CrossFadeAlpha(1.0f, 2f, false);
    }
}
