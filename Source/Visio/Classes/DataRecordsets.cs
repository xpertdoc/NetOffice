using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.VisioApi
{

	#region Delegates

	#pragma warning disable
	public delegate void DataRecordsets_DataRecordsetAddedEventHandler(NetOffice.VisioApi.IVDataRecordset DataRecordset);
	public delegate void DataRecordsets_BeforeDataRecordsetDeleteEventHandler(NetOffice.VisioApi.IVDataRecordset DataRecordset);
	public delegate void DataRecordsets_DataRecordsetChangedEventHandler(NetOffice.VisioApi.IVDataRecordsetChangedEvent DataRecordsetChanged);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass DataRecordsets 
	/// SupportByVersion Visio, 12,14
	///</summary>
	[SupportByVersionAttribute("Visio", 12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class DataRecordsets : IVDataRecordsets,IEventBinding
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		EDataRecordsets_SinkHelper _eDataRecordsets_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(DataRecordsets);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public DataRecordsets(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}

		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataRecordsets(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DataRecordsets(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of DataRecordsets 
        /// </summary>		
		public DataRecordsets():base("Visio.DataRecordsets")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of DataRecordsets
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public DataRecordsets(string progId):base(progId)
		{
			
		}

		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Visio, 12,14
		/// </summary>
		private event DataRecordsets_DataRecordsetAddedEventHandler _DataRecordsetAddedEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14
		/// </summary>
		[SupportByVersion("Visio", 12,14)]
		public event DataRecordsets_DataRecordsetAddedEventHandler DataRecordsetAddedEvent
		{
			add
			{
				CreateEventBridge();
				_DataRecordsetAddedEvent += value;
			}
			remove
			{
				_DataRecordsetAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 12,14
		/// </summary>
		private event DataRecordsets_BeforeDataRecordsetDeleteEventHandler _BeforeDataRecordsetDeleteEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14
		/// </summary>
		[SupportByVersion("Visio", 12,14)]
		public event DataRecordsets_BeforeDataRecordsetDeleteEventHandler BeforeDataRecordsetDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDataRecordsetDeleteEvent += value;
			}
			remove
			{
				_BeforeDataRecordsetDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Visio, 12,14
		/// </summary>
		private event DataRecordsets_DataRecordsetChangedEventHandler _DataRecordsetChangedEvent;

		/// <summary>
		/// SupportByVersion Visio 12 14
		/// </summary>
		[SupportByVersion("Visio", 12,14)]
		public event DataRecordsets_DataRecordsetChangedEventHandler DataRecordsetChangedEvent
		{
			add
			{
				CreateEventBridge();
				_DataRecordsetChangedEvent += value;
			}
			remove
			{
				_DataRecordsetChangedEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding Member
        
		/// <summary>
        /// creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == NetOffice.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, EDataRecordsets_SinkHelper.Id);


			if(EDataRecordsets_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_eDataRecordsets_SinkHelper = new EDataRecordsets_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
			if(null == _thisType)
				_thisType = this.GetType();
					
			foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
			{
				MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
				if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
					return false;
			}
				
			return false;
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates.Length;
            }
            else
                return 0;
        }

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                foreach (var item in delegates)
                {
                    try
                    {
                        item.Method.Invoke(item.Target, paramsArray);
                    }
                    catch (NetRuntimeSystem.Exception exception)
                    {
                        DebugConsole.WriteException(exception);
                    }
                }
                return delegates.Length;
            }
            else
                return 0;
		}

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != _eDataRecordsets_SinkHelper)
			{
				_eDataRecordsets_SinkHelper.Dispose();
				_eDataRecordsets_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}