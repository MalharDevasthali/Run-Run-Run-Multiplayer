using UnityEngine;
using Scripts.Commons;
using Scripts.PlayerServices;
using Scripts.UIServices;

public class Coin : MonoBehaviour, ICollectable
{

    public void OnCollected()
    {
        PlayerService.instance.GetPlayerController().CollectCoin();
        Destroy(this.gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerView>() != null)
        {
            OnCollected();
        }
    }
}
