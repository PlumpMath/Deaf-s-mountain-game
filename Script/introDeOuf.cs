using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introDeOuf : MonoBehaviour {
    public Text one;
    public Text two;
    public Text three;
    public Text four;
    public Text five;
    public Text six;
    public Text seven;
    public Text eight;
    public Text nine;
    public Text ten;
    public Text eleven;
    public Text douze;
    public Text thirteen;
    IEnumerator Start()
    {
        one.canvasRenderer.SetAlpha(0.0f);
        two.canvasRenderer.SetAlpha(0.0f);
        three.canvasRenderer.SetAlpha(0.0f);
        four.canvasRenderer.SetAlpha(0.0f);
        five.canvasRenderer.SetAlpha(0.0f);
        six.canvasRenderer.SetAlpha(0.0f);
        seven.canvasRenderer.SetAlpha(0.0f);
        eight.canvasRenderer.SetAlpha(0.0f);
        nine.canvasRenderer.SetAlpha(0.0f);
        ten.canvasRenderer.SetAlpha(0.0f);
        eleven.canvasRenderer.SetAlpha(0.0f);
        douze.canvasRenderer.SetAlpha(0.0f);
        thirteen.canvasRenderer.SetAlpha(0.0f);
        yield return new WaitForSeconds(4);
        Fadein(one);
        yield return new WaitForSeconds(3);
        Fadeout(one);
        yield return new WaitForSeconds(3);
        Fadein(two);
        yield return new WaitForSeconds(3);
        Fadeout(two);
        yield return new WaitForSeconds(3);
        Fadein(three);
        yield return new WaitForSeconds(3);
        Fadeout(three);
        yield return new WaitForSeconds(3);
        Fadein(four);
        yield return new WaitForSeconds(3);
        Fadeout(four);
        yield return new WaitForSeconds(3);
        Fadein(five);
        yield return new WaitForSeconds(3);
        Fadeout(five);
        yield return new WaitForSeconds(3);
        Fadein(six);
        yield return new WaitForSeconds(3);
        Fadeout(six);
        yield return new WaitForSeconds(3);
        Fadein(seven);
        yield return new WaitForSeconds(3);
        Fadeout(seven);
        yield return new WaitForSeconds(3);
        Fadein(eight);
        yield return new WaitForSeconds(3);
        Fadeout(eight);
        yield return new WaitForSeconds(3);
        Fadein(nine);
        yield return new WaitForSeconds(3);
        Fadeout(nine);
        yield return new WaitForSeconds(3);
        Fadein(ten);
        yield return new WaitForSeconds(3);
        Fadeout(ten);
        yield return new WaitForSeconds(3);
        Fadein(eleven);
        yield return new WaitForSeconds(3);
        Fadeout(eleven);
        yield return new WaitForSeconds(3);
        Fadein(douze);
        yield return new WaitForSeconds(3);
        Fadeout(douze);
        yield return new WaitForSeconds(3);
        Fadein(thirteen);
        yield return new WaitForSeconds(3);
        Fadeout(thirteen);

    }
    void Fadein(Text a)
    {
        a.CrossFadeAlpha(1.0f, 1.5f, false);
    }
    void Fadeout(Text a)
    {
        a.CrossFadeAlpha(0.0f, 2.5f, false);
    }
}
