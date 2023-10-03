using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoRenderer : MonoBehaviour
{
    public List<GameObject> ammobar;

    public BasicMovement player;

    int oricount;
    int curcount;

    // Start is called before the first frame update
    void Start()
    {
        oricount = player.ammo;
        curcount = player.ammo;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        curcount = player.ammo;
        if (curcount != oricount)
        {
            UpdateUI();
        }
    }

    void UpdateUI()
    {
        for (int a = 0; a < 6; a++)
        {
            ammobar[a].SetActive(false);
        }
        for (int b = 0; b < curcount; b++)
        {
            ammobar[b].SetActive(true);
        }
    }
}
