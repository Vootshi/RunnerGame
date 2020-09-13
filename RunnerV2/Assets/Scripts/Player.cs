using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public Rigidbody player;
    public GameObject myParticleSystem;
    
    public GameObject tapToStart; 
    public GameObject gameOverScreen;
    public GameObject gameWinScreen;
    public GameObject afterFallScreen;
    

    float speed = 35f;
    float sideRotate = 1.5f;
    bool disabled = true;
    Camera cachedCamera;
    Vector3 offset;
    Vector3 camPos;
    Vector2 mousePosition;
    Vector2 touchPosition;

    void Start()
    {
        cachedCamera = Camera.main;
        camPos = Camera.main.transform.position;
        offset = new Vector3(0f, camPos.y - transform.position.y, camPos.z - transform.position.z);

        Mathf.Clamp(transform.rotation.y, -45f, 45f);

        tapToStart.SetActive(true);
    }

    private void Update()
    {
        cachedCamera.transform.position = new Vector3(0f, transform.position.y, transform.position.z) + offset; 

        if (disabled && gameOverScreen.activeInHierarchy == false && gameWinScreen.activeInHierarchy == false
            && afterFallScreen.activeInHierarchy == false)
        {
            if (Input.touchCount > 0 || Input.GetMouseButton(0))
            {
                Undisable();
            }
        }
    }

    void FixedUpdate()
    {
        if (!disabled)
        {
            transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed);

            //KeyboardController
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(transform.rotation.x, transform.rotation.y - sideRotate, transform.rotation.z);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(transform.rotation.x, transform.rotation.y + sideRotate, transform.rotation.z);
            }

            //MouseController
            if (Input.GetMouseButton(0))
            {
                mousePosition = Input.mousePosition;
                if (mousePosition.x > Camera.main.pixelWidth / 2)
                {
                    transform.Rotate(transform.rotation.x, (transform.rotation.y + sideRotate), transform.rotation.z);
                }

                if (mousePosition.x < Camera.main.pixelWidth / 2)
                {
                    transform.Rotate(transform.rotation.x, (transform.rotation.y - sideRotate), transform.rotation.z);
                }
            }

            //TouchController
            if (Input.touchCount > 0)
            {
                touchPosition = Input.GetTouch(0).position;

                if (touchPosition.x > Camera.main.pixelWidth / 2)
                {
                    transform.Rotate(transform.rotation.x, (transform.rotation.y + sideRotate), transform.rotation.z);
                }

                if (touchPosition.x < Camera.main.pixelWidth / 2)
                {
                    transform.Rotate(transform.rotation.x, (transform.rotation.y - sideRotate), transform.rotation.z);
                }
            }

        }

    }

    public bool isDisabled()
    {
        if(disabled == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Disable()
    {
        disabled = true;
        myParticleSystem.SetActive(true);
    }

    public void Undisable()
    {
        disabled = false;
        myParticleSystem.SetActive(false);
        tapToStart.SetActive(false);
    }
}
