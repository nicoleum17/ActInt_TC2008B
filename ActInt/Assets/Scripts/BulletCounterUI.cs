using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BulletCounterUI : MonoBehaviour
{
    public TMP_Text bulletCountText;

    void Update(){
        int count = BulletPool.Instance.GetActiveBulletCount();
        bulletCountText.text = "Balas: " + count;
    }
}
