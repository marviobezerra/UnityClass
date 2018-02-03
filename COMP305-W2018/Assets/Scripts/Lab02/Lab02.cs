using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lab02 : MonoBehaviour {

    public SpriteRenderer image;

    public Sprite sprite;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(buttonClick);
    }

    public void buttonClick () {
        image.sprite = sprite;
	}
}
