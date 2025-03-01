//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public partial class BurgersRottVortex : VortexModel {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal BurgersRottVortex(global::System.IntPtr cPtr, bool cMemoryOwn) : base(PatternSolverPINVOKE.BurgersRottVortex_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BurgersRottVortex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(BurgersRottVortex obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PatternSolverPINVOKE.delete_BurgersRottVortex(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public BurgersRottVortex(double Vr, double Vt, double Vs) : this(PatternSolverPINVOKE.new_BurgersRottVortex__SWIG_0(Vr, Vt, Vs), true) {
  }

  public BurgersRottVortex(double Vr, double Vt) : this(PatternSolverPINVOKE.new_BurgersRottVortex__SWIG_1(Vr, Vt), true) {
  }

  public BurgersRottVortex(double Vr) : this(PatternSolverPINVOKE.new_BurgersRottVortex__SWIG_2(Vr), true) {
  }

  public BurgersRottVortex() : this(PatternSolverPINVOKE.new_BurgersRottVortex__SWIG_3(), true) {
  }

  public override SWIGTYPE_p_Vec2 vecAt(double x, double y) {
    SWIGTYPE_p_Vec2 ret = new SWIGTYPE_p_Vec2(PatternSolverPINVOKE.BurgersRottVortex_vecAt(swigCPtr, x, y), true);
    return ret;
  }

}
