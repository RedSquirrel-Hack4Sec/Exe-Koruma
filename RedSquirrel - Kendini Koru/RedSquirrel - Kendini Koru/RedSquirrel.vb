Imports System.Runtime.InteropServices
Public Class RedSquirrel
    <DllImport("ntdll.dll")>
    Shared Function NtSetInformationProcess(ByVal p As IntPtr, ByVal c As Integer, ByRef i As Integer, ByVal l As Integer) As Integer
    End Function
    Shared Sub Apply()
        NtSetInformationProcess(Process.GetCurrentProcess.Handle, 29, 1, 4)
    End Sub
    Shared Sub Disable()
        NtSetInformationProcess(Process.GetCurrentProcess.Handle, 29, 0, 4)
    End Sub
End Class
