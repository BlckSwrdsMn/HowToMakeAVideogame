using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        text.text = player.position.z.ToString("0");
    }
}
