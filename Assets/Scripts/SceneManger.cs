using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vr
{
    public class SceneManger : MonoBehaviour
    {
        public WallpaperManger WM;
        public Texture kjsd;

        public void PyramidsSelect()
        {
            foreach( Texture T  in WM.Wallpapers)
            {
                if( T.name == "Pyramids")
                {
                    Debug.Log(T.name);
                    WM.MeshR.material.mainTexture = kjsd;
                }
            }
        }
         public void BeachSelect()
        {
            foreach( Texture T  in WM.Wallpapers)
            {
                if( T.name == "Beach")
                {
                    WM.MeshR.material.mainTexture = T;
                }
            }
        }
        public void CaveSelect()
        {
            foreach (Texture T in WM.Wallpapers)
            {
                if (T.name == "Cave")
                {
                    WM.MeshR.material.mainTexture = T;
                }
            }
        }
    }

    
}
