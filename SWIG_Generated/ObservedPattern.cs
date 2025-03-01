//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public partial class ObservedPattern : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ObservedPattern(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ObservedPattern obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ObservedPattern obj) {
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

  ~ObservedPattern() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          PatternSolverPINVOKE.delete_ObservedPattern(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_std__vectorT_Vec2_t vecs {
    set {
      PatternSolverPINVOKE.ObservedPattern_vecs_set(swigCPtr, SWIGTYPE_p_std__vectorT_Vec2_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = PatternSolverPINVOKE.ObservedPattern_vecs_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_Vec2_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_Vec2_t(cPtr, false);
      return ret;
    } 
  }

  public double lengthAbove {
    set {
      PatternSolverPINVOKE.ObservedPattern_lengthAbove_set(swigCPtr, value);
    } 
    get {
      double ret = PatternSolverPINVOKE.ObservedPattern_lengthAbove_get(swigCPtr);
      return ret;
    } 
  }

  public double lengthBelow {
    set {
      PatternSolverPINVOKE.ObservedPattern_lengthBelow_set(swigCPtr, value);
    } 
    get {
      double ret = PatternSolverPINVOKE.ObservedPattern_lengthBelow_get(swigCPtr);
      return ret;
    } 
  }

  public double spacing {
    set {
      PatternSolverPINVOKE.ObservedPattern_spacing_set(swigCPtr, value);
    } 
    get {
      double ret = PatternSolverPINVOKE.ObservedPattern_spacing_get(swigCPtr);
      return ret;
    } 
  }

  public ObservedPattern(double lengthAbove_, double lengthBelow_, double spacing_, DoubleVector obsVecs) : this(PatternSolverPINVOKE.new_ObservedPattern(lengthAbove_, lengthBelow_, spacing_, DoubleVector.getCPtr(obsVecs)), true) {
    if (PatternSolverPINVOKE.SWIGPendingException.Pending) throw PatternSolverPINVOKE.SWIGPendingException.Retrieve();
  }

  public double length() {
    double ret = PatternSolverPINVOKE.ObservedPattern_length(swigCPtr);
    return ret;
  }

  public int size() {
    int ret = PatternSolverPINVOKE.ObservedPattern_size(swigCPtr);
    return ret;
  }

  public int centerIdx() {
    int ret = PatternSolverPINVOKE.ObservedPattern_centerIdx(swigCPtr);
    return ret;
  }

  public DoubleVector vectors() {
    DoubleVector ret = new DoubleVector(PatternSolverPINVOKE.ObservedPattern_vectors(swigCPtr), true);
    return ret;
  }

  public bool isMissingVectors() {
    bool ret = PatternSolverPINVOKE.ObservedPattern_isMissingVectors(swigCPtr);
    return ret;
  }

  public bool isConverging() {
    bool ret = PatternSolverPINVOKE.ObservedPattern_isConverging(swigCPtr);
    return ret;
  }

  public bool isUnchanging() {
    bool ret = PatternSolverPINVOKE.ObservedPattern_isUnchanging(swigCPtr);
    return ret;
  }

  public bool isSimulatableType() {
    bool ret = PatternSolverPINVOKE.ObservedPattern_isSimulatableType(swigCPtr);
    return ret;
  }

  public bool isValid() {
    bool ret = PatternSolverPINVOKE.ObservedPattern_isValid(swigCPtr);
    return ret;
  }

}
