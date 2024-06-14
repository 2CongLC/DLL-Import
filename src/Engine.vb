
Imports System
Imports System.Runtime.InteropServices

Public Class Engine

    <System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function LoadLibraryA(ByVal lpLibFileName As String) As IntPtr
    End Function
    <System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function GetProcAddress(hModule As IntPtr, lpProcName As String) As IntPtr
    End Function
    <System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function FreeLibrary(ByVal hModule As IntPtr) As Boolean
    End Function
    <System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function GetCurrentProcess() As IntPtr
    End Function

    <System.Runtime.InteropServices.DllImport("psapi.dll", SetLastError:=True)>
    Public Shared Function EnumProcessModules(hProcess As IntPtr, <Out> lphModule() As IntPtr, cb As Integer, <Out> ByRef lpcbNeeded As Integer) As Boolean
    End Function


    Public Const DLLNAME As String = "Engine.dll"


    ''' <summary>
    ''' Sử dụng DLL Export Viewer để xem Tên Sub và Func kiểu cdecl < br/>
    ''' Dùng Dependency Walker tìm theo mã Ordianl sau đó copy tên func vào EntryPoint <br />
    ''' </summary>
    ''' <param name="pathname"></param>
    <System.Runtime.InteropServices.DllImport(DLLNAME, EntryPoint:="?g_CreatePath@@YAXPBD@Z", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Sub g_CreatePath(ByVal pathname As String)
    End Sub






End Class
