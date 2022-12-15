using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

namespace Vr
{
    public class VideoSlider : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
    {

        public VideoPlayer videoPlayer;
        private Slider slider;
        private bool pressed;

        private void Awake()
        {
            slider = GetComponent<Slider>();
            slider.minValue = 0;
            slider.maxValue = (float)CalculateLengh();
        }
        public void OnPointerDown(PointerEventData a)
        {
            pressed = true;
        }
        public void OnPointerUp(PointerEventData a)
        {
            /* float frame = (float)slider.value * (float)videoPlayer.frameCount;
             videoPlayer.frame = (long)frame;*/
            MoveSlider();
            pressed = false;
        }
        void Update()
        {
            if (!pressed)
            {
                slider.value = (float)videoPlayer.time;
            }
        }

        public void MoveSlider()
        {
            videoPlayer.time = slider.value;
        }

        double CalculateLengh()
        {
            double fraction = (double)videoPlayer.frameCount / (double)videoPlayer.frameRate;
            return fraction;
        }

    }
}