using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConfiguration", menuName = "GameConfig/Create Game Config File", order = 1)]
public class GameConfig : ScriptableObject
{
    [Tooltip("Row number for the cards to create in game")]
    [Range(2, 7)]
    public int cardRow;

    [Tooltip("Coloum number for the cards to create in game")]
    [Range(2, 5)]
    public int cardCol;

    public List<Sprite> sprites = new List<Sprite>();

}
