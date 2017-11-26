using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secondDialogue : MonoBehaviour {
    public AudioSource a;
    public AudioSource fire;
    public AudioSource wind;
    public Text one;
    public Text two;
    public Text three;
    public Text four;
    public Text five;
    IEnumerator Start()
    {
        one.canvasRenderer.SetAlpha(0.0f);
        two.canvasRenderer.SetAlpha(0.0f);
        three.canvasRenderer.SetAlpha(0.0f);
        four.canvasRenderer.SetAlpha(0.0f);
        five.canvasRenderer.SetAlpha(0.0f);
        wind.volume = 0.2f;
        fire.volume = 0.4f;
        a.Play();
        yield return new WaitForSeconds(4);
        Fadein(one);
        yield return new WaitForSeconds(3);
        Fadeout(one);
        yield return new WaitForSeconds(3);
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
        yield return new WaitForSeconds(2);
        a.Stop();
        wind.volume = 1;
        fire.volume = 1f;
    }
    void Fadein(Text a)
    {
        a.CrossFadeAlpha(1.0f, 2.5f, false);
    }
    void Fadeout(Text a)
    {
        a.CrossFadeAlpha(0.0f, 2.5f, false);
    }
}
