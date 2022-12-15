using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

namespace Vr
{
    public class WallpaperManger : MonoBehaviour
    {
        public List<GameObject> Buttoms = new List<GameObject>();
        public List<Texture> Wallpapers;
        [HideInInspector]
        public MeshRenderer MeshR;
        public int WallPaperNum;
        public VideoPlayer VP;
        public AudioSource audioSource;

        private void Awake()
        {
            MeshR = GetComponent<MeshRenderer>();
            // VP = GetComponent<VideoPlayer>();
        }
        private void Update()
        {
            MeshR.material.mainTexture = Wallpapers[WallPaperNum];
        }
        public void PyramidsSelect()
        {
            WallPaperNum = 1;
            foreach (GameObject g in Buttoms)
            {
                if (g.name == "Pyramids Buttoms")
                {
                    g.SetActive(true);
                }
                else
                {
                    g.SetActive(false);
                }
            }
        }
        public void BeachSelect()
        {
            WallPaperNum = 2;
            foreach (GameObject g in Buttoms)
            {
                if (g.name == "beach Buttoms")
                {
                    g.SetActive(true);
                }
                else
                {
                    g.SetActive(false);
                }
            }

        }
        public void CaveSelect()
        {

            WallPaperNum = 3;
            foreach (GameObject g in Buttoms)
            {
                if (g.name == "Cave Buttoms")
                {
                    g.SetActive(true);
                }
                else
                {
                    g.SetActive(false);
                }
            }

        }
        public void HomeSelect()
        {
            VP.Stop();
            WallPaperNum = 0;
            foreach (GameObject g in Buttoms)
            {
                if (g.name == "Home Buttoms")
                {
                    g.SetActive(true);
                }
                else
                {
                    g.SetActive(false);
                }
            }
        }
        public void BallSelect()
        {
            WallPaperNum = 4;
            foreach (GameObject g in Buttoms)
            {
                if (g.name == "Ball Buttoms")
                {
                    g.SetActive(true);
                }
                else
                {
                    g.SetActive(false);
                }
            }
        }
        public void CitySelect()
        {
            audioSource.mute = false;
            VP.Play();
            if (VP.isPlaying)
            {
                Debug.Log(VP.time);
            }

            foreach (GameObject g in Buttoms)
            {
                if (g.name == "City Buttoms")
                {
                    g.SetActive(true);
                }
                else
                {
                    g.SetActive(false);
                }
            }

        }
        public void Mute()
        {
            audioSource.mute = true;

        } 
        public void UnMute()
        {
            audioSource.mute = false;

        }
    }
}
