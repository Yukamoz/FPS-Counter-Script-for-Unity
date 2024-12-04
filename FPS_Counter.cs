using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPS_Counter : MonoBehaviour {

    private void Start() {

        counter = GetComponent<TextMeshProUGUI>();
        StartCoroutine(UpdateFPS());

    }

    private float GetFPS() {

        return Mathf.CeilToInt(1.0f / Time.deltaTime);

    }

    private IEnumerator UpdateFPS() {

        counter.text = GetFPS().ToString() + " FPS";
        yield return new WaitForSeconds(updateSpeed);
        StartCoroutine(UpdateFPS());

    }

    private TextMeshProUGUI counter;

    // this need to be pretty big value so the game doesnt fucking freeze
    public float updateSpeed = 2f;

}