using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    private List<Card> cards;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI priorityText;
    void Start()
    {
        //load saved cards
        cards = new List<Card>();
    }

    void DisplayAtIndex(int index = 0)
    {
        if (cards.Count == 0)
        {
            nameText.text = "";
            priorityText.text = "";
        }
        else
        {
            nameText.text = cards[0].name;
            priorityText.text = cards[0].points.ToString();
        }
    }
    public void AddCard(Card c)
    {
        cards.Add(c);
        DisplayAtIndex();
        Debug.Log("New card added at " + name);
    }
    public void RemoveCard(Card c)
    {
        cards.Remove(c);
        DisplayAtIndex();
        Debug.Log("New card removed at " + name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Tasks"))
        {
            AddCard(other.gameObject.GetComponent<Task>().Task1);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Tasks"))
        {
            RemoveCard(other.gameObject.GetComponent<Task>().Task1);
        }
    }
}
