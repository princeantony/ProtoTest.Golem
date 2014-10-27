﻿using System;
using System.Windows.Automation;

namespace ProtoTest.Golem.Purple.PurpleElements
{
    public class PurpleButton : PurpleElementBase
    {
        //TODO Finish implimenting PurpleButton
        public PurpleButton(string name, string pPath) : base(name, pPath)
        {
        }

        public PurpleButton(string name, AutomationElement element) : base(name, element)
        {
            
        }

        public bool IsClickable()
        {
            bool clickable = true;
            try
            {
                PurpleElement.GetClickablePoint();
            }
            catch (Exception)
            {
                clickable = false;
            }
            return clickable;
        }
        
    }
}
