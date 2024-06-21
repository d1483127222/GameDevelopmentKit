//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework;
using GameFramework.Event;
using GameFramework.Network;
using System.Net;
using UnityEngine;
using UnityGameFramework.Runtime;
using NetworkConnectedEventArgs = UnityGameFramework.Runtime.NetworkConnectedEventArgs;

namespace Game.Hot
{
    public class MenuForm : StarForceUIForm
    {
        [SerializeField]
        private GameObject m_QuitButton = null;

        private ProcedureMenu m_ProcedureMenu = null;

        public static bool isClose = false;
        private GameFramework.Network.INetworkChannel m_Channel;
        private NetworkChannelHelper m_NetworkChannelHelper;

        public void OnStartButtonClick()
        {
            m_ProcedureMenu.StartGame();
        }

        public void OnSettingButtonClick()
        {
            Log.Debug("测试二");
            GameEntry.UI.OpenUIForm(UIFormId.SettingForm);
            //m_Channel.Send(ReferencePool.Acquire<CSHeartBeat>());
            // 发送消息给服务端
            // m_Channel.Send (new CSHello () {
            //     Name = "服务器你好吗？",
            // });
            //GameEntry.UI.OpenUIForm(UIFormId.TestForm);

        }

        public void OnAboutButtonClick()
        {
            GameEntry.UI.OpenUIForm(UIFormId.AboutForm);
        }

        public void OnQuitButtonClick()
        {
            GameEntry.UI.OpenUIForm(UIFormId.DialogForm, new DialogParams()
            {
                Mode = 2,
                Title = GameEntry.Localization.GetString("AskQuitGame.Title"),
                Message = GameEntry.Localization.GetString("AskQuitGame.Message"),
                OnClickConfirm = delegate (object userData) { UnityGameFramework.Runtime.GameEntry.Shutdown(ShutdownType.Quit); },
            });
        }

#if UNITY_2017_3_OR_NEWER
        protected override void OnOpen(object userData)
#else
        protected internal override void OnOpen(object userData)
#endif
        {
            base.OnOpen(userData);

            m_ProcedureMenu = (ProcedureMenu)userData;
            if (m_ProcedureMenu == null)
            {
                Log.Warning("ProcedureMenu is invalid when open MenuForm.");
                return;
            }

            m_QuitButton.SetActive(Application.platform != RuntimePlatform.IPhonePlayer);


            // // 启动服务器(服务端的代码随便找随便改的，大家可以忽略，假设有个服务端就行了)
            // Demo8_SocketServer.Start();
            //
            // // 获取框架事件组件
            // EventComponent Event
            //     = UnityGameFramework.Runtime.GameEntry.GetComponent<EventComponent>();
            //
            // Event.Subscribe(NetworkConnectedEventArgs.EventId, OnConnected);
            //
            // // 获取框架网络组件
            // NetworkComponent Network
            //     = UnityGameFramework.Runtime.GameEntry.GetComponent<NetworkComponent>();
            //
            // // 创建频道
            // m_NetworkChannelHelper = new NetworkChannelHelper();
            // m_Channel = Network.CreateNetworkChannel("testName", ServiceType.Tcp, m_NetworkChannelHelper);
            //
            // // 连接服务器
            // m_Channel.Connect(IPAddress.Parse("127.0.0.1"), 8098);
            // //m_Channel.Connect(IPAddress.Parse("127.0.0.1"), 51581);

        }

#if UNITY_2017_3_OR_NEWER
        protected override void OnClose(bool isShutdown, object userData)
#else
        protected internal override void OnClose(bool isShutdown, object userData)
#endif
        {
            m_ProcedureMenu = null;

            base.OnClose(isShutdown, userData);

            Demo8_SocketServer.isOpen = false;
            m_Channel.Close();
        }

        private void OnConnected(object sender, GameEventArgs e)
        {
            NetworkConnectedEventArgs ne = (NetworkConnectedEventArgs)e;

            

            
        }
    }
}
