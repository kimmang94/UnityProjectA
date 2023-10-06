// ----------------------------------------------------------------------------
// <copyright file="Enums.cs" company="Exit Games GmbH">
//   PhotonNetwork Framework for Unity - Copyright (C) 2018 Exit Games GmbH
// </copyright>
// <summary>
// Wraps up several enumerations for PUN.
// </summary>
// <author>developer@exitgames.com</author>
// ----------------------------------------------------------------------------


namespace Photon.Pun
{
    /// <summary>Which PhotonNetwork method was called to connect (which influences the regions we want pinged).</summary>
    /// <remarks>PhotonNetwork.ConnectUsingSettings will call either ConnectToMaster, ConnectToRegion or ConnectToBest, depending on the settings.</remarks>
    public enum ConnectMethod { NotCalled, ConnectToMaster, ConnectToRegion, ConnectToBest }


    /// <summary>Used to define the level of logging output created by the PUN classes. Either log errors, info (some more) or full.</summary>
    /// \ingroup publicApi
    public enum PunLogLevel
    {
        /// <summary>Show only errors. Minimal output. Note: Some might be "runtime errors" which you have to expect.</summary>
        ErrorsOnly,

        /// <summary>Logs some of the workflow, calls and results.</summary>
        Informational,

        /// <summary>Every available log call gets into the console/log. Only use for debugging.</summary>
        Full
    }


    /// <summary>Enum of "target" options for RPCs. These define which remote clients get your RPC call. </summary>
    /// \ingroup publicApi
    public enum RpcTarget
    {
        /// <summary>RPC를 다른 모든 사람에게 보내고 이 클라이언트에서 즉시 실행합니다. 나중에 참가하는 플레이어는 이 RPC를 실행하지 않습니다.</summary>
        All,

        /// <summary>RPC를 다른 모든 사람에게 보냅니다. 이 클라이언트는 RPC를 실행하지 않습니다. 나중에 참가하는 플레이어는 이 RPC를 실행하지 않습니다.</summary>
        Others,

        /// <summary>RPC를 MasterClient에만 보냅니다. 주의: MasterClient는 RPC를 실행하기 전에 연결이 끊길 수 있으며 이로 인해 RPC가 중단될 수 있습니다..</summary>
        MasterClient,

        /// <summary>Sends the RPC to everyone else and executes it immediately on this client. New players get the RPC when they join as it's buffered (until this client leaves).</summary>
        AllBuffered,

        /// <summary>Sends the RPC to everyone. This client does not execute the RPC. New players get the RPC when they join as it's buffered (until this client leaves).</summary>
        OthersBuffered,

        /// <summary>Sends the RPC to everyone (including this client) through the server.</summary>
        /// <remarks>
        /// This client executes the RPC like any other when it received it from the server.
        /// Benefit: The server's order of sending the RPCs is the same on all clients.
        /// </remarks>
        AllViaServer,

        /// <summary>Sends the RPC to everyone (including this client) through the server and buffers it for players joining later.</summary>
        /// <remarks>
        /// This client executes the RPC like any other when it received it from the server.
        /// Benefit: The server's order of sending the RPCs is the same on all clients.
        /// </remarks>
        AllBufferedViaServer
    }


    public enum ViewSynchronization { Off, ReliableDeltaCompressed, Unreliable, UnreliableOnChange }


    /// <summary>
    /// Options to define how Ownership Transfer is handled per PhotonView.
    /// </summary>
    /// <remarks>
    /// This setting affects how RequestOwnership and TransferOwnership work at runtime.
    /// </remarks>
    public enum OwnershipOption
    {
        /// <summary>
        /// Ownership is fixed. Instantiated objects stick with their creator, room objects always belong to the Master Client.
        /// </summary>
        Fixed,
        /// <summary>
        /// Ownership can be taken away from the current owner who can't object.
        /// </summary>
        Takeover,
        /// <summary>
        /// Ownership can be requested with PhotonView.RequestOwnership but the current owner has to agree to give up ownership.
        /// </summary>
        /// <remarks>The current owner has to implement IPunCallbacks.OnOwnershipRequest to react to the ownership request.</remarks>
        Request
    }
}