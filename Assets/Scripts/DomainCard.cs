
using UnityEngine;

[CreateAssetMenu (menuName = "Cards/Domain")]
public class DomainCard: CardType
{
public override void OnSetType(CardViz viz)
{
    viz.statsHolder.SetActive(false);
}
}
