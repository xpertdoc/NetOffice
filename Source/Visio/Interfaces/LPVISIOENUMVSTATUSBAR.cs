using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// Interface LPVISIOENUMVSTATUSBAR 
	/// SupportByVersion Visio, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class LPVISIOENUMVSTATUSBAR : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(LPVISIOENUMVSTATUSBAR);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOENUMVSTATUSBAR(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOENUMVSTATUSBAR(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOENUMVSTATUSBAR(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOENUMVSTATUSBAR() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOENUMVSTATUSBAR(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="celt">Int32 celt</param>
		/// <param name="rgelt">NetOffice.VisioApi.IVStatusBar rgelt</param>
		/// <param name="pceltFetched">Int32 pceltFetched</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int32 Next(Int32 celt, out NetOffice.VisioApi.IVStatusBar rgelt, out Int32 pceltFetched)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			rgelt = null;
			pceltFetched = 0;
			object[] paramsArray = Invoker.ValidateParamsArray(celt, rgelt, pceltFetched);
			object returnItem = Invoker.MethodReturn(this, "Next", paramsArray);
			rgelt = (NetOffice.VisioApi.IVStatusBar)paramsArray[1];
			pceltFetched = (Int32)paramsArray[2];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="celt">Int32 celt</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int32 Skip(Int32 celt)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(celt);
			object returnItem = Invoker.MethodReturn(this, "Skip", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int32 Reset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Reset", paramsArray);
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="ppenm">NetOffice.VisioApi.IEnumVStatusBar ppenm</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int32 Clone(out NetOffice.VisioApi.IEnumVStatusBar ppenm)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			ppenm = null;
			object[] paramsArray = Invoker.ValidateParamsArray(ppenm);
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			ppenm = (NetOffice.VisioApi.IEnumVStatusBar)paramsArray[0];
			return NetRuntimeSystem.Convert.ToInt32(returnItem);
		}

		#endregion
		#pragma warning restore
	}
}