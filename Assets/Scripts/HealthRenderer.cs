using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRenderer : MonoBehaviour
{
    public List<GameObject> healbar;

    public BasicMovement player;

    int oricount;
    int curcount;

    // Start is called before the first frame update
    void Start()
    {
        oricount = player.health;
        curcount = player.health;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        curcount = player.health;
        if (curcount != oricount)
        {
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        for (int a = 0; a < 6; a++)
        {
            healbar[a].SetActive(false);
        }
        for (int b = 0; b < curcount; b++)
        {
            healbar[b].SetActive(true);
        }
    }
}
