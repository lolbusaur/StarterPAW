using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Camera.Simplemjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']"
	[global::Android.Runtime.Register ("com/camera/simplemjpeg/MjpegView", DoNotGenerateAcw=true)]
	public partial class MjpegView : global::Android.Views.SurfaceView, global::Android.Views.ISurfaceHolderCallback {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='IMG_HEIGHT']"
		[Register ("IMG_HEIGHT")]
		public int ImgHeight {
			get {
				const string __id = "IMG_HEIGHT.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "IMG_HEIGHT.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='IMG_WIDTH']"
		[Register ("IMG_WIDTH")]
		public int ImgWidth {
			get {
				const string __id = "IMG_WIDTH.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "IMG_WIDTH.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='POSITION_LOWER_LEFT']"
		[Register ("POSITION_LOWER_LEFT")]
		public const int PositionLowerLeft = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='POSITION_LOWER_RIGHT']"
		[Register ("POSITION_LOWER_RIGHT")]
		public const int PositionLowerRight = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='POSITION_UPPER_LEFT']"
		[Register ("POSITION_UPPER_LEFT")]
		public const int PositionUpperLeft = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='POSITION_UPPER_RIGHT']"
		[Register ("POSITION_UPPER_RIGHT")]
		public const int PositionUpperRight = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='SIZE_BEST_FIT']"
		[Register ("SIZE_BEST_FIT")]
		public const int SizeBestFit = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='SIZE_FULLSCREEN']"
		[Register ("SIZE_FULLSCREEN")]
		public const int SizeFullscreen = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/field[@name='SIZE_STANDARD']"
		[Register ("SIZE_STANDARD")]
		public const int SizeStandard = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView.MjpegViewThread']"
		[global::Android.Runtime.Register ("com/camera/simplemjpeg/MjpegView$MjpegViewThread", DoNotGenerateAcw=true)]
		public partial class MjpegViewThread : global::Java.Lang.Thread {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/camera/simplemjpeg/MjpegView$MjpegViewThread", typeof (MjpegViewThread));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected MjpegViewThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView.MjpegViewThread']/constructor[@name='MjpegView.MjpegViewThread' and count(parameter)=3 and parameter[1][@type='com.camera.simplemjpeg.MjpegView'] and parameter[2][@type='android.view.SurfaceHolder'] and parameter[3][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/camera/simplemjpeg/MjpegView;Landroid/view/SurfaceHolder;Landroid/content/Context;)V", "")]
			public unsafe MjpegViewThread (global::Com.Camera.Simplemjpeg.MjpegView __self, global::Android.Views.ISurfaceHolder surfaceHolder, global::Android.Content.Context context)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/view/SurfaceHolder;Landroid/content/Context;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue ((surfaceHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surfaceHolder).Handle);
					__args [2] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_setSurfaceSize_II;
#pragma warning disable 0169
			static Delegate GetSetSurfaceSize_IIHandler ()
			{
				if (cb_setSurfaceSize_II == null)
					cb_setSurfaceSize_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetSurfaceSize_II);
				return cb_setSurfaceSize_II;
			}

			static void n_SetSurfaceSize_II (IntPtr jnienv, IntPtr native__this, int width, int height)
			{
				global::Com.Camera.Simplemjpeg.MjpegView.MjpegViewThread __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView.MjpegViewThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetSurfaceSize (width, height);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView.MjpegViewThread']/method[@name='setSurfaceSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("setSurfaceSize", "(II)V", "GetSetSurfaceSize_IIHandler")]
			public virtual unsafe void SetSurfaceSize (int width, int height)
			{
				const string __id = "setSurfaceSize.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (width);
					__args [1] = new JniArgumentValue (height);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/camera/simplemjpeg/MjpegView", typeof (MjpegView));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected MjpegView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/constructor[@name='MjpegView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MjpegView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/constructor[@name='MjpegView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MjpegView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isStreaming;
#pragma warning disable 0169
		static Delegate GetIsStreamingHandler ()
		{
			if (cb_isStreaming == null)
				cb_isStreaming = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStreaming);
			return cb_isStreaming;
		}

		static bool n_IsStreaming (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStreaming;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStreaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='isStreaming' and count(parameter)=0]"
			[Register ("isStreaming", "()Z", "GetIsStreamingHandler")]
			get {
				const string __id = "isStreaming.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_freeCameraMemory;
#pragma warning disable 0169
		static Delegate GetFreeCameraMemoryHandler ()
		{
			if (cb_freeCameraMemory == null)
				cb_freeCameraMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FreeCameraMemory);
			return cb_freeCameraMemory;
		}

		static void n_FreeCameraMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FreeCameraMemory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='freeCameraMemory' and count(parameter)=0]"
		[Register ("freeCameraMemory", "()V", "GetFreeCameraMemoryHandler")]
		public virtual unsafe void FreeCameraMemory ()
		{
			const string __id = "freeCameraMemory.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resumePlayback;
#pragma warning disable 0169
		static Delegate GetResumePlaybackHandler ()
		{
			if (cb_resumePlayback == null)
				cb_resumePlayback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumePlayback);
			return cb_resumePlayback;
		}

		static void n_ResumePlayback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumePlayback ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='resumePlayback' and count(parameter)=0]"
		[Register ("resumePlayback", "()V", "GetResumePlaybackHandler")]
		public virtual unsafe void ResumePlayback ()
		{
			const string __id = "resumePlayback.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setDisplayMode_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayMode_IHandler ()
		{
			if (cb_setDisplayMode_I == null)
				cb_setDisplayMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisplayMode_I);
			return cb_setDisplayMode_I;
		}

		static void n_SetDisplayMode_I (IntPtr jnienv, IntPtr native__this, int s)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayMode (s);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setDisplayMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDisplayMode", "(I)V", "GetSetDisplayMode_IHandler")]
		public virtual unsafe void SetDisplayMode (int s)
		{
			const string __id = "setDisplayMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOverlayBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetOverlayBackgroundColor_IHandler ()
		{
			if (cb_setOverlayBackgroundColor_I == null)
				cb_setOverlayBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOverlayBackgroundColor_I);
			return cb_setOverlayBackgroundColor_I;
		}

		static void n_SetOverlayBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int c)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayBackgroundColor (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setOverlayBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOverlayBackgroundColor", "(I)V", "GetSetOverlayBackgroundColor_IHandler")]
		public virtual unsafe void SetOverlayBackgroundColor (int c)
		{
			const string __id = "setOverlayBackgroundColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOverlayPaint_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetSetOverlayPaint_Landroid_graphics_Paint_Handler ()
		{
			if (cb_setOverlayPaint_Landroid_graphics_Paint_ == null)
				cb_setOverlayPaint_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOverlayPaint_Landroid_graphics_Paint_);
			return cb_setOverlayPaint_Landroid_graphics_Paint_;
		}

		static void n_SetOverlayPaint_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayPaint (p);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setOverlayPaint' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("setOverlayPaint", "(Landroid/graphics/Paint;)V", "GetSetOverlayPaint_Landroid_graphics_Paint_Handler")]
		public virtual unsafe void SetOverlayPaint (global::Android.Graphics.Paint p)
		{
			const string __id = "setOverlayPaint.(Landroid/graphics/Paint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOverlayPosition_I;
#pragma warning disable 0169
		static Delegate GetSetOverlayPosition_IHandler ()
		{
			if (cb_setOverlayPosition_I == null)
				cb_setOverlayPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOverlayPosition_I);
			return cb_setOverlayPosition_I;
		}

		static void n_SetOverlayPosition_I (IntPtr jnienv, IntPtr native__this, int p)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayPosition (p);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setOverlayPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOverlayPosition", "(I)V", "GetSetOverlayPosition_IHandler")]
		public virtual unsafe void SetOverlayPosition (int p)
		{
			const string __id = "setOverlayPosition.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOverlayTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetOverlayTextColor_IHandler ()
		{
			if (cb_setOverlayTextColor_I == null)
				cb_setOverlayTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOverlayTextColor_I);
			return cb_setOverlayTextColor_I;
		}

		static void n_SetOverlayTextColor_I (IntPtr jnienv, IntPtr native__this, int c)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayTextColor (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setOverlayTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOverlayTextColor", "(I)V", "GetSetOverlayTextColor_IHandler")]
		public virtual unsafe void SetOverlayTextColor (int c)
		{
			const string __id = "setOverlayTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setResolution_II;
#pragma warning disable 0169
		static Delegate GetSetResolution_IIHandler ()
		{
			if (cb_setResolution_II == null)
				cb_setResolution_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetResolution_II);
			return cb_setResolution_II;
		}

		static void n_SetResolution_II (IntPtr jnienv, IntPtr native__this, int w, int h)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetResolution (w, h);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setResolution' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setResolution", "(II)V", "GetSetResolution_IIHandler")]
		public virtual unsafe void SetResolution (int w, int h)
		{
			const string __id = "setResolution.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (w);
				__args [1] = new JniArgumentValue (h);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_;
#pragma warning disable 0169
		static Delegate GetSetSource_Lcom_camera_simplemjpeg_MjpegInputStream_Handler ()
		{
			if (cb_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_ == null)
				cb_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSource_Lcom_camera_simplemjpeg_MjpegInputStream_);
			return cb_setSource_Lcom_camera_simplemjpeg_MjpegInputStream_;
		}

		static void n_SetSource_Lcom_camera_simplemjpeg_MjpegInputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Camera.Simplemjpeg.MjpegInputStream source = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.SetSource (source);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='com.camera.simplemjpeg.MjpegInputStream']]"
		[Register ("setSource", "(Lcom/camera/simplemjpeg/MjpegInputStream;)V", "GetSetSource_Lcom_camera_simplemjpeg_MjpegInputStream_Handler")]
		public virtual unsafe void SetSource (global::Com.Camera.Simplemjpeg.MjpegInputStream source)
		{
			const string __id = "setSource.(Lcom/camera/simplemjpeg/MjpegInputStream;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showFps_Z;
#pragma warning disable 0169
		static Delegate GetShowFps_ZHandler ()
		{
			if (cb_showFps_Z == null)
				cb_showFps_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowFps_Z);
			return cb_showFps_Z;
		}

		static void n_ShowFps_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowFps (b);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='showFps' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showFps", "(Z)V", "GetShowFps_ZHandler")]
		public virtual unsafe void ShowFps (bool b)
		{
			const string __id = "showFps.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startPlayback;
#pragma warning disable 0169
		static Delegate GetStartPlaybackHandler ()
		{
			if (cb_startPlayback == null)
				cb_startPlayback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartPlayback);
			return cb_startPlayback;
		}

		static void n_StartPlayback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartPlayback ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='startPlayback' and count(parameter)=0]"
		[Register ("startPlayback", "()V", "GetStartPlaybackHandler")]
		public virtual unsafe void StartPlayback ()
		{
			const string __id = "startPlayback.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopPlayback;
#pragma warning disable 0169
		static Delegate GetStopPlaybackHandler ()
		{
			if (cb_stopPlayback == null)
				cb_stopPlayback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopPlayback);
			return cb_stopPlayback;
		}

		static void n_StopPlayback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPlayback ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='stopPlayback' and count(parameter)=0]"
		[Register ("stopPlayback", "()V", "GetStopPlaybackHandler")]
		public virtual unsafe void StopPlayback ()
		{
			const string __id = "stopPlayback.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int native_f, int w, int h)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format f = (global::Android.Graphics.Format) native_f;
			__this.SurfaceChanged (holder, f, w, h);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual unsafe void SurfaceChanged (global::Android.Views.ISurfaceHolder holder, [global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Format f, int w, int h)
		{
			const string __id = "surfaceChanged.(Landroid/view/SurfaceHolder;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				__args [1] = new JniArgumentValue ((int) f);
				__args [2] = new JniArgumentValue (w);
				__args [3] = new JniArgumentValue (h);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceCreated (global::Android.Views.ISurfaceHolder holder)
		{
			const string __id = "surfaceCreated.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			global::Com.Camera.Simplemjpeg.MjpegView __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegView']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceDestroyed (global::Android.Views.ISurfaceHolder holder)
		{
			const string __id = "surfaceDestroyed.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
