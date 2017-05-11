using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HitAreaAssigner_20170209
{
    class ColorSetter
    {
        //rectangleareaのstate,tagのそれぞれをkeyとする
        //２種のkeyによるそれぞれのcolorpick（２つは独立している）
        //listviewにおける選択状態も参照
 
        Color baseColor = Color.FromArgb(200, 64, 80, 255);
        int[] baseColorArgb = new []{200, 64, 80, 255};

        struct BindedColorWithState
        {
            public int state;
            public int[] argb;
            public BindedColorWithState(int state)
            {
                this.state = state;
                argb = new int[4];
            }
        }

        struct BindedColorWithTag
        {
            public string tag;
            public int[] argb;
            public BindedColorWithTag(string tag)
            {
                this.tag = tag;
                argb = new int[4];
            }
        }

        LinkedList<BindedColorWithState> stateList;
        LinkedList<BindedColorWithTag> tagList;

        public ColorSetter()
        {
            stateList = new LinkedList<BindedColorWithState>();
            tagList = new LinkedList<BindedColorWithTag>();
        }
        
        public Color GetColor(bool isSelect, int state, string tag)
        {
            int[] argb = new int[4];
            if (state == 0 && tag.Length == 0)
            {
                argb = baseColorArgb;
            }
            else
            {
                if(state!=0)
                {
                    
                }
                if(tag.Length > 0)
                {

                }
            }

            if(isSelect)
            {
                for (int i = 1; i < argb.Length; i++)
                    argb[i] += 60;
            }

            for(int i = 0; i < argb.Length; i++)
            {
                if (argb[i] > 255) argb[i] = 255;
                if (argb[i] < 0) argb[i] = 0;
            }

            return Color.FromArgb(argb[0], argb[1], argb[2], argb[3]);
        }

        public void SetBindedColorWithState(int state, int[] argb)
        {
            if (argb.Length != 4) return;

        }

        public void SetBindedColoeWithTag(string tag, int[] argb)
        {
            if (argb.Length != 4) return;

        }
    }
}
