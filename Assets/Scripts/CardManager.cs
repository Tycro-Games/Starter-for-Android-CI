using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    private List<Card> cards;

    void Start()
    {
        //load saved cards
        cards = new List<Card>();
    }

    public void AddCard()
    {
        cards.Add(new Card());
        Debug.Log("New card added");
    }
}
