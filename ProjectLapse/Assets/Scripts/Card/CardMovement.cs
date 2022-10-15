using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour
{
    public int maxDistance;
    Canvas canvas;
    Vector2 startPos;
    void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        startPos = transform.position;
    }
    public void DragHandler(BaseEventData data)
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
            Debug.Log("SWIPED LEFT");
        else if (transform.position.x > 130)
            Debug.Log("SWIPED RIGHT");

        transform.position = startPos;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    public void Rotation()
    {
        float rotation;
        float value = transform.position.x - startPos.x;
        rotation = -1 * value * 100 / 350;

        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
}
