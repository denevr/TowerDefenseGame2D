using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections;

public class TileManager : MonoBehaviour
{
    private GameObject tower;
    public Button towerButton;
    public Vector3 offset = new Vector3(0.0f, 19, -4.5f);
    public List<int> tileList = new List<int>();
    public int buttonPressCount;

    void Start()
    {
        towerButton.onClick.AddListener(OnButtonClickAddTower);

        Transform[] childs = (Transform[])gameObject.GetComponentsInChildren<Transform>();
        for (int i = 1; i < childs.Length; ++i)
        {
            tileList.Add(i);
        }
        buttonPressCount = 0;
        towerButton.interactable = true;
    }

    void Update()
    {
        if (buttonPressCount <= WaveSpawner.waveIndex)
        {
            towerButton.interactable = true;
        }
        else
        {
            towerButton.interactable = false;
        }
    }

    void OnButtonClickAddTower()
    {
        if (tileList.Count == 0)
            return;

        System.Random random = new System.Random();
        Transform[] childs = (Transform[])gameObject.GetComponentsInChildren<Transform>();
        int randomTile = tileList.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
        tileList.Remove(randomTile);

        GameObject randomObject = (GameObject)((Transform)childs[randomTile]).gameObject;

        if (randomObject.CompareTag("Buildable"))
        {
            GameObject towerToBuild = BuildManager.instance.GetTowerToBuild();
            tower = (GameObject)Instantiate(towerToBuild, randomObject.transform.position + offset, Quaternion.identity);
            Debug.Log("tower built");
            buttonPressCount++;
        }
    }
}