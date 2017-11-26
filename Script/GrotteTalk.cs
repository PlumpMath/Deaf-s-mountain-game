using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GrotteTalk : MonoBehaviour {
    public string scene;
    public AudioSource wind;
    public AudioSource music;
    public AudioSource a;
    public AudioSource b;
    public Text one;
    public Text two;
    public Text three;
    public Text four;
    public Text five;
    public Text six;
    public Text seven;
    IEnumerator Start()
    {
        one.canvasRenderer.SetAlpha(0.0f);
        two.canvasRenderer.SetAlpha(0.0f);
        three.canvasRenderer.SetAlpha(0.0f);
        four.canvasRenderer.SetAlpha(0.0f);
        five.canvasRenderer.SetAlpha(0.0f);
        six.canvasRenderer.SetAlpha(0.0f);
        seven.canvasRenderer.SetAlpha(0.0f);
        a.mute = true;
        b.mute = true;
        wind.Play();
        yield return new WaitForSeconds(2);
        music.Play();
        yield return new WaitForSeconds(2);
        Fadein(one);
        yield return new WaitForSeconds(5);
        Fadeout(one);
        yield return new WaitForSeconds(5);
        Fadein(two);
        yield return new WaitForSeconds(5);
        Fadeout(two);
        yield return new WaitForSeconds(5);
        Fadein(three);
        yield return new WaitForSeconds(5);
        Fadeout(three);
        yield return new WaitForSeconds(5);
        Fadein(four);
        yield return new WaitForSeconds(5);
        Fadeout(four);
        yield return new WaitForSeconds(5);
        Fadein(five);
        yield return new WaitForSeconds(5);
        Fadeout(five);
        yield return new WaitForSeconds(5);
        Fadein(six);
        yield return new WaitForSeconds(5);
        Fadeout(six);
        yield return new WaitForSeconds(5);
        Fadein(seven);
        yield return new WaitForSeconds(5);
        Fadeout(seven);
        yield return new WaitForSeconds(5);
        music.volume = 0.8f;
        yield return new WaitForSeconds(.1f);
        music.volume = 0.7f;
        yield return new WaitForSeconds(.1f);
        music.volume = 0.6f;
        yield return new WaitForSeconds(.1f);
        music.volume = 0.5f;
        yield return new WaitForSeconds(.1f);
        music.volume = 0.4f;
        yield return new WaitForSeconds(.1f);
        music.volume = 0.3f;
        yield return new WaitForSeconds(.1f);
        music.volume = 0.2f;
        yield return new WaitForSeconds(.1f);
        music.volume = 0.1f;
        yield return new WaitForSeconds(.1f);
        music.volume = 0.001f;
        yield return new WaitForSeconds(.1f);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(scene);
    }
    void Fadein(Text a)
    {
        a.CrossFadeAlpha(1.0f, 3f, false);
    }
    void Fadeout(Text a)
    {
        a.CrossFadeAlpha(0.0f, 3f, false);
    }
}
