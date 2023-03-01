using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEditor;
using UnityEngine;
using UnityGameFramework.Editor;

namespace ET.Editor
{
    [CustomEditor(typeof(ETComponent))]
    internal sealed class ETComponentInspector :GameFrameworkInspector
    {
        private GlobalConfig globalConfig;
        
        private void OnEnable()
        {
            globalConfig = Resources.Load<GlobalConfig>("ET/GlobalConfig");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            EditorGUI.BeginDisabledGroup(EditorApplication.isPlayingOrWillChangePlaymode);
            {
                this.globalConfig.CodeMode = (CodeMode)EditorGUILayout.EnumPopup("CodeMode: ", this.globalConfig.CodeMode);
                EditorUtility.SetDirty(this.globalConfig);
                AssetDatabase.SaveAssets();
            }
            EditorGUI.EndDisabledGroup();
        }
    }
}