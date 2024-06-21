using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeBind;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;

namespace Game.Hot
{
    [MonoCodeBind('_')]
    public partial class TestForm : StarForceUIForm
    {
        private void Start()
        {
            m_BBBButton.onClick.AddListener(OnClickConfirmButton);
            //m_bbbbfffButton.onClick.AddListener(OnClickConfirmButton);
            //m_btnOkButton.onClick.AddListener(OnClickConfirmButton);
        }
        
        private void OnClickConfirmButton()
        {
            Log.Debug("ssssssssss");
            GameEntry.UI.CloseUIForm(this.UIForm);
        }
    }
}
