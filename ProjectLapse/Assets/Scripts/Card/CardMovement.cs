using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardMovement : MonoBehaviour
{
    public int maxDistance;
    Canvas canvas;
    Vector3 startPos;
    GameManager gameManager;
    public static int storyCardValue;
    Animator anim;
    void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        anim = GetComponent<Animator>();
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
        if (transform.position.x < -6) // Canvasýn içinde x deðeri nedense -9 ve 9 arasýnda gidip geliyor þimdilik deðiþtiriyorum eski // Eski deðerler 50 ve 130 -Altay
            StartCoroutine(Drop(true, 1));
        else if (transform.position.x > 6)
            StartCoroutine(Drop(false, 2));
        else
            ResetPos();
    }
    IEnumerator Drop(bool value, int value2)
    {
        anim.SetTrigger("Swipe");
        yield return new WaitForSeconds(1);
        gameManager.SwipeEffect(value);
        storyCardValue = value2;
        ResetPos();
    }
    
    public void ResetPos()
    {
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
