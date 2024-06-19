//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using GameFramework.Network;
using UnityGameFramework.Runtime;

namespace Game.Hot
{
    public class SCHelloHandler : PacketHandlerBase
    {
        public override int Id
        {
            get
            {
                return 4;
            }
        }

        public override void Handle(object sender, Packet packet)
        {
            SCHello packetImpl = (SCHello)packet;
            
            Log.Info("Receive ss packet '{0}'.", packetImpl.Name.ToString());
        }
    }
}
