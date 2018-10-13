using UnityEngine;
using UnityEngine.EventSystems;



public class FixedJoystick : Joystick
{
	//public GameObject player;
    Vector2 joystickPosition = Vector2.zero;
    private Camera cam = new Camera();
	ThirdPersonCharacter player = new ThirdPersonCharacter();

    void Start()
    {
		player = GetComponent<ThirdPersonCharacter>();
        joystickPosition = RectTransformUtility.WorldToScreenPoint(cam, background.position);
    }

    public override void OnDrag(PointerEventData eventData)
    {
        Vector2 direction = eventData.position - joystickPosition;
        inputVector = (direction.magnitude > background.sizeDelta.x / 2f) ? direction.normalized : direction / (background.sizeDelta.x / 2f);
		player.m_ForwardAmount = inputVector.x;
		Debug.Log (inputVector.x);
        ClampJoystick();
        handle.anchoredPosition = (inputVector * background.sizeDelta.x / 2f) * handleLimit;
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        inputVector = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
    }
}