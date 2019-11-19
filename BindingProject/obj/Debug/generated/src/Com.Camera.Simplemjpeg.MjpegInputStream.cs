using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Camera.Simplemjpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']"
	[global::Android.Runtime.Register ("com/camera/simplemjpeg/MjpegInputStream", DoNotGenerateAcw=true)]
	public partial class MjpegInputStream : global::Java.IO.DataInputStream {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/camera/simplemjpeg/MjpegInputStream", typeof (MjpegInputStream));
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

		protected MjpegInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/constructor[@name='MjpegInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe MjpegInputStream (global::System.IO.Stream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/InputStream;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
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
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FreeCameraMemory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='freeCameraMemory' and count(parameter)=0]"
		[Register ("freeCameraMemory", "()V", "GetFreeCameraMemoryHandler")]
		public virtual unsafe void FreeCameraMemory ()
		{
			const string __id = "freeCameraMemory.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_pixeltobmp_arrayBILandroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetPixeltobmp_arrayBILandroid_graphics_Bitmap_Handler ()
		{
			if (cb_pixeltobmp_arrayBILandroid_graphics_Bitmap_ == null)
				cb_pixeltobmp_arrayBILandroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, int>) n_Pixeltobmp_arrayBILandroid_graphics_Bitmap_);
			return cb_pixeltobmp_arrayBILandroid_graphics_Bitmap_;
		}

		static int n_Pixeltobmp_arrayBILandroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Android.Graphics.Bitmap p2 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Pixeltobmp (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='pixeltobmp' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register ("pixeltobmp", "([BILandroid/graphics/Bitmap;)I", "GetPixeltobmp_arrayBILandroid_graphics_Bitmap_Handler")]
		public virtual unsafe int Pixeltobmp (byte[] p0, int p1, global::Android.Graphics.Bitmap p2)
		{
			const string __id = "pixeltobmp.([BILandroid/graphics/Bitmap;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("read", "(Ljava/lang/String;)Lcom/camera/simplemjpeg/MjpegInputStream;", "")]
		public static unsafe global::Com.Camera.Simplemjpeg.MjpegInputStream Read (string surl)
		{
			const string __id = "read.(Ljava/lang/String;)Lcom/camera/simplemjpeg/MjpegInputStream;";
			IntPtr native_surl = JNIEnv.NewString (surl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_surl);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_surl);
			}
		}

		static Delegate cb_readMjpegFrame;
#pragma warning disable 0169
		static Delegate GetReadMjpegFrameHandler ()
		{
			if (cb_readMjpegFrame == null)
				cb_readMjpegFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ReadMjpegFrame);
			return cb_readMjpegFrame;
		}

		static IntPtr n_ReadMjpegFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReadMjpegFrame ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='readMjpegFrame' and count(parameter)=0]"
		[Register ("readMjpegFrame", "()Landroid/graphics/Bitmap;", "GetReadMjpegFrameHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap ReadMjpegFrame ()
		{
			const string __id = "readMjpegFrame.()Landroid/graphics/Bitmap;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readMjpegFrame_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetReadMjpegFrame_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_readMjpegFrame_Landroid_graphics_Bitmap_ == null)
				cb_readMjpegFrame_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ReadMjpegFrame_Landroid_graphics_Bitmap_);
			return cb_readMjpegFrame_Landroid_graphics_Bitmap_;
		}

		static int n_ReadMjpegFrame_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bmp)
		{
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bmp = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bmp, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadMjpegFrame (bmp);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='readMjpegFrame' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("readMjpegFrame", "(Landroid/graphics/Bitmap;)I", "GetReadMjpegFrame_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe int ReadMjpegFrame (global::Android.Graphics.Bitmap bmp)
		{
			const string __id = "readMjpegFrame.(Landroid/graphics/Bitmap;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bmp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bmp).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setSkip_I;
#pragma warning disable 0169
		static Delegate GetSetSkip_IHandler ()
		{
			if (cb_setSkip_I == null)
				cb_setSkip_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSkip_I);
			return cb_setSkip_I;
		}

		static void n_SetSkip_I (IntPtr jnienv, IntPtr native__this, int s)
		{
			global::Com.Camera.Simplemjpeg.MjpegInputStream __this = global::Java.Lang.Object.GetObject<global::Com.Camera.Simplemjpeg.MjpegInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSkip (s);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.camera.simplemjpeg']/class[@name='MjpegInputStream']/method[@name='setSkip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSkip", "(I)V", "GetSetSkip_IHandler")]
		public virtual unsafe void SetSkip (int s)
		{
			const string __id = "setSkip.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
