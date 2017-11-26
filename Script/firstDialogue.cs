using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstDialogue : MonoBehaviour {
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
        Fadein(six);
        yield return new WaitForSeconds(5);
        Fadeout(six);
        yield return new WaitForSeconds(5);
        Fadein(seven);
        yield return new WaitForSeconds(5);
        Fadeout(seven);
        yield return new WaitForSeconds(5);
        
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
