// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    public partial class DeviceDetailsBase
    {
        private AlertNotificationSettings _alertNotification;
        
        /// <summary>
        /// Optional. Gets or sets AlertNotification.
        /// </summary>
        public AlertNotificationSettings AlertNotification
        {
            get { return this._alertNotification; }
            set { this._alertNotification = value; }
        }
        
        private ChapSettings _chap;
        
        /// <summary>
        /// Optional. Gets or sets Chap.
        /// </summary>
        public ChapSettings Chap
        {
            get { return this._chap; }
            set { this._chap = value; }
        }
        
        private DeviceInfo _deviceProperties;
        
        /// <summary>
        /// Optional. Gets or sets DeviceProperties.
        /// </summary>
        public DeviceInfo DeviceProperties
        {
            get { return this._deviceProperties; }
            set { this._deviceProperties = value; }
        }
        
        private DnsServerSettings _dnsServer;
        
        /// <summary>
        /// Optional. Gets or sets DnsServer.
        /// </summary>
        public DnsServerSettings DnsServer
        {
            get { return this._dnsServer; }
            set { this._dnsServer = value; }
        }
        
        private string _instanceId;
        
        /// <summary>
        /// Optional. Gets or sets InstanceId.
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets Name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private IList<NetInterface> _netInterfaceList;
        
        /// <summary>
        /// Optional. Gets or sets NetInterfaceList.
        /// </summary>
        public IList<NetInterface> NetInterfaceList
        {
            get { return this._netInterfaceList; }
            set { this._netInterfaceList = value; }
        }
        
        private OperationInProgress _operationInProgress;
        
        /// <summary>
        /// Optional. Gets or sets OperationInProgress.
        /// </summary>
        public OperationInProgress OperationInProgress
        {
            get { return this._operationInProgress; }
            set { this._operationInProgress = value; }
        }
        
        private RemoteManagementSettings _remoteMgmtSettingsInfo;
        
        /// <summary>
        /// Optional. Gets or sets RemoteMgmtSettingsInfo.
        /// </summary>
        public RemoteManagementSettings RemoteMgmtSettingsInfo
        {
            get { return this._remoteMgmtSettingsInfo; }
            set { this._remoteMgmtSettingsInfo = value; }
        }
        
        private RemoteMinishellSettings _remoteMinishellSecretInfo;
        
        /// <summary>
        /// Optional. Gets or sets RemoteMinishellSecretInfo.
        /// </summary>
        public RemoteMinishellSettings RemoteMinishellSecretInfo
        {
            get { return this._remoteMinishellSecretInfo; }
            set { this._remoteMinishellSecretInfo = value; }
        }
        
        private string _secretEncryptionCertThumbprint;
        
        /// <summary>
        /// Optional. Gets or sets SecretEncryptionCertThumbprint.
        /// </summary>
        public string SecretEncryptionCertThumbprint
        {
            get { return this._secretEncryptionCertThumbprint; }
            set { this._secretEncryptionCertThumbprint = value; }
        }
        
        private SnapshotSettings _snapshot;
        
        /// <summary>
        /// Optional. Gets or sets Snapshot.
        /// </summary>
        public SnapshotSettings Snapshot
        {
            get { return this._snapshot; }
            set { this._snapshot = value; }
        }
        
        private TimeSettings _timeServer;
        
        /// <summary>
        /// Optional. Gets or sets TimeServer.
        /// </summary>
        public TimeSettings TimeServer
        {
            get { return this._timeServer; }
            set { this._timeServer = value; }
        }
        
        private DeviceType _type;
        
        /// <summary>
        /// Required. Gets or sets DeviceType.
        /// </summary>
        public DeviceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        private VirtualApplianceInfo _virtualApplianceProperties;
        
        /// <summary>
        /// Optional. Gets or sets VirtualApplianceProperties.
        /// </summary>
        public VirtualApplianceInfo VirtualApplianceProperties
        {
            get { return this._virtualApplianceProperties; }
            set { this._virtualApplianceProperties = value; }
        }
        
        private WebProxySettings _webProxy;
        
        /// <summary>
        /// Optional. Gets or sets WebProxy.
        /// </summary>
        public WebProxySettings WebProxy
        {
            get { return this._webProxy; }
            set { this._webProxy = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeviceDetailsBase class.
        /// </summary>
        public DeviceDetailsBase()
        {
            this.NetInterfaceList = new List<NetInterface>();
        }
        
        /// <summary>
        /// Initializes a new instance of the DeviceDetailsBase class with
        /// required arguments.
        /// </summary>
        public DeviceDetailsBase(string name, DeviceType type)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
            this.Type = type;
        }
    }
}
