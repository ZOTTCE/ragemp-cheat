/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class NatPunchthroughDebugInterface_Printf : NatPunchthroughDebugInterface {
  private HandleRef swigCPtr;

  internal NatPunchthroughDebugInterface_Printf(IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.NatPunchthroughDebugInterface_Printf_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(NatPunchthroughDebugInterface_Printf obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~NatPunchthroughDebugInterface_Printf() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_NatPunchthroughDebugInterface_Printf(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override void OnClientMessage(string msg) {
    RakNetPINVOKE.NatPunchthroughDebugInterface_Printf_OnClientMessage(swigCPtr, msg);
  }

  public NatPunchthroughDebugInterface_Printf() : this(RakNetPINVOKE.new_NatPunchthroughDebugInterface_Printf(), true) {
  }

}

}
