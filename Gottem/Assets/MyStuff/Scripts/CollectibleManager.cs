using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private int _totalGottem;
    private int _collectedGottem;

    private void Start()
    {
        _totalGottem = FindObjectsOfType<Collectible>().Length;
        DisplayGottemCount();
    }

    public TextMeshProUGUI gottemCount;

    private void Awake()
    {
        Instance = this;
    }
    void DisplayGottemCount()
    {
        gottemCount.SetText(_collectedGottem + " / " + _totalGottem);
    }

    public void HandleGottemCollected()
    {
        _collectedGottem++;
        DisplayGottemCount();
        if(_collectedGottem == _totalGottem)
        {
            YouWinGottemMenu.Instance.Show();
            SoundManager.Instance.PlayCoinCollectAllSound();
        }

        SoundManager.Instance.PlayCoinCollectSound();
    }
}
