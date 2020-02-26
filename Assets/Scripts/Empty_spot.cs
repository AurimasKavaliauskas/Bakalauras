using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Empty_spot : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    Color startColor;
    bool canDrop;
    RectTransform other2;
    RectTransform rectTransform;

    // Start is called before the first frame update
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame


    void Update()
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("pasol nahuj");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("dragging");

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Snap(other2);
        Debug.Log("droped");
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Draging");
        this.transform.position += new Vector3(eventData.delta.x, eventData.delta.y);
    }

    void Snap(RectTransform rect)
    {
        if (canDrop)
        {
          this.gameObject.transform.position = rect.position;
          this.gameObject.transform.SetParent(rect);         
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("OnCollisionEnter2D");
        if (check(other.gameObject.name) == true)
        {
            startColor = other.gameObject.GetComponent<Image>().color;
            other.gameObject.GetComponent<Image>().color = Color.green;
            canDrop = true;
            other2 = other.gameObject.GetComponent<RectTransform>();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        other.gameObject.GetComponent<Image>().color = startColor;
        canDrop = false;
    }
    bool check(string other_name)
    {
        if (this.name == "IF" && other_name == "Empty_spot_body" || this.name == "IF" && other_name == "Empty_spot")
        {
            return true;
        }
        else if (this.name == "Less" && other_name == "Empty_spot_if")
        {
            return true;
        }
        else if (this.name == "move_fwd" && other_name == "Empty_spot_body" || this.name == "move_fwd" &&  other_name == "Empty_spot")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}