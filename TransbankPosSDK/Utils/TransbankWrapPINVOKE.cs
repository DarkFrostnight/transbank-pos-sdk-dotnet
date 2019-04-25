//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Transbank.POS.Utils {

class TransbankWrapPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="SWIGRegisterExceptionCallbacks_TransbankWrap")]
    public static extern void SWIGRegisterExceptionCallbacks_TransbankWrap(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_TransbankWrap")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_TransbankWrap(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_TransbankWrap(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_TransbankWrap(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(TransbankWrapPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(TransbankWrapPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="SWIGRegisterStringCallback_TransbankWrap")]
    public static extern void SWIGRegisterStringCallback_TransbankWrap(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_TransbankWrap(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static TransbankWrapPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_ParamInfo_index_set___")]
  public static extern void ParamInfo_index_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_ParamInfo_index_get___")]
  public static extern int ParamInfo_index_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_ParamInfo_length_set___")]
  public static extern void ParamInfo_length_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_ParamInfo_length_get___")]
  public static extern int ParamInfo_length_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_new_ParamInfo___")]
  public static extern global::System.IntPtr new_ParamInfo();

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_delete_ParamInfo___")]
  public static extern void delete_ParamInfo(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_function_set___")]
  public static extern void BaseResponse_function_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_function_get___")]
  public static extern int BaseResponse_function_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_responseCode_set___")]
  public static extern void BaseResponse_responseCode_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_responseCode_get___")]
  public static extern int BaseResponse_responseCode_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_commerceCode_set___")]
  public static extern void BaseResponse_commerceCode_set(global::System.Runtime.InteropServices.HandleRef jarg1, long jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_commerceCode_get___")]
  public static extern long BaseResponse_commerceCode_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_terminalId_set___")]
  public static extern void BaseResponse_terminalId_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_terminalId_get___")]
  public static extern int BaseResponse_terminalId_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_initilized_set___")]
  public static extern void BaseResponse_initilized_set(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_BaseResponse_initilized_get___")]
  public static extern int BaseResponse_initilized_get(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_new_BaseResponse___")]
  public static extern global::System.IntPtr new_BaseResponse();

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_delete_BaseResponse___")]
  public static extern void delete_BaseResponse(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_list_ports___")]
  public static extern string list_ports();

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_get_port_name___")]
  public static extern string get_port_name(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_read_bytes___")]
  public static extern int read_bytes(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_read_ack___")]
  public static extern int read_ack(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_calculate_lrc___")]
  public static extern byte calculate_lrc(string jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_reply_ack___")]
  public static extern int reply_ack(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_write_message___")]
  public static extern int write_message(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_open_port___")]
  public static extern int open_port(string jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_sale___")]
  public static extern string sale(int jarg1, int jarg2, bool jarg3);

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_register_close___")]
  public static extern global::System.IntPtr register_close();

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_load_keys___")]
  public static extern global::System.IntPtr load_keys();

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_polling___")]
  public static extern int polling();

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_set_normal_mode___")]
  public static extern int set_normal_mode();

  [global::System.Runtime.InteropServices.DllImport("TransbankWrap", EntryPoint="CSharp_TransbankfPOSfUtils_close_port___")]
  public static extern int close_port();
}

}
