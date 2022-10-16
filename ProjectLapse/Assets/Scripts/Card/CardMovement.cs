using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour
{
    public int maxDistance;
    Canvas canvas;
    Vector2 startPos;
    GameManager gameManager;
    void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        gameManager = GameObject.Find("Game_Manager_Object").GetComponent<GameManager>();
        startPos = transform.position;
    }
    public void DragHandler(BaseEventData data)//kart birakilinca basladigi yere donmeli
    {
        PointerEventData pointer = (PointerEventData)data;

        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform,
            pointer.position,
            canvas.worldCamera,
            out pos
            );

        pos = new Vector2(Mathf.Clamp(pos.x, -maxDistance, maxDistance), Mathf.Clamp(pos.y, -maxDistance, maxDistance));
        transform.position = canvas.transform.TransformPoint(pos);

        Rotation();
    }
    public void DropHandler(BaseEventData data)
    {
        if (transform.position.x < 50)
            gameManager.SwipeEffectt(true);
            //ekrandan cikip silinmeli yeni kart gelmeli
        else if (transform.position.x > 130)
            gameManager.SwipeEffectt(false);
            //burada da
        transform.position = startPos;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void Rotation()
    {
        float rotation;
        float value = transform.position.x - startPos.x;
        rotation = -1 * value *5;

        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
}
