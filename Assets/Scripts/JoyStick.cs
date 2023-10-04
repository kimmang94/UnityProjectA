using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class JoyStick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler , IEndDragHandler
{
    [SerializeField]
    private RectTransform lever;
    private RectTransform leverBG;
    private Vector2 touchPos;

    public float Horizontal	=> touchPos.x;
    public float Vertical	=> touchPos.y;
    
    private void Awake()
    {
        leverBG = GetComponent<RectTransform>();
    }

    /// <summary>
    /// 터치 시작 시 1회
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerDown(PointerEventData eventData)
    {

    }

    /// <summary>
    /// 터치 상태일 때 매 프레임
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrag(PointerEventData eventData)
    {
        touchPos = Vector2.zero;
        
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(leverBG, eventData.position,
                eventData.pressEventCamera, out touchPos))
        {
            touchPos.x = (touchPos.x / leverBG.sizeDelta.x);
            touchPos.y = (touchPos.y / leverBG.sizeDelta.y);

            touchPos = new Vector2(touchPos.x * 2 - 1, touchPos.y * 2 - 1);
            touchPos = (touchPos.magnitude > 1) ? touchPos.normalized : touchPos;

            lever.anchoredPosition =
                new Vector2(touchPos.x * leverBG.sizeDelta.x / 2, touchPos.y * leverBG.sizeDelta.y / 2);

        }
    }

    /// <summary>
    /// 터치 종료시 1회
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerUp(PointerEventData eventData)
    {
        lever.anchoredPosition = Vector2.zero;
        touchPos = Vector2.zero;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lever.anchoredPosition = Vector2.zero;
        touchPos = Vector2.zero;
    }
}
