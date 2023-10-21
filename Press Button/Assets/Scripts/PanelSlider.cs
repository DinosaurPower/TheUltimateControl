using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSlider : MonoBehaviour
{
   
    public Slider slider;
    public Transform panelTransform;
    public float moveSpeed = 5f;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = panelTransform.position;
    }

    private void Update()
    {
        float sliderValue = slider.value;

        // Adjust the movement direction and distance as needed
        Vector3 moveDirection = Vector3.right;
        Vector3 targetPosition = initialPosition + moveDirection * sliderValue * moveSpeed * Time.deltaTime;

        // Move the panel
        panelTransform.position = Vector3.MoveTowards(panelTransform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}