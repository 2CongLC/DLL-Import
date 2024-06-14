Imports System.Runtime.InteropServices


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Engine.g_CreatePath(TextBox1.Text)
            MessageBox.Show("ok")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub


    Public Delegate Sub g_CreatePath1(ByVal pathname As String)

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim handle = Engine.LoadLibraryA(Engine.DLLNAME)
            If handle = IntPtr.Zero Then
                Console.WriteLine("Không tải được DLL")
                Return
            End If
            Dim CreatPath = CType(Marshal.GetDelegateForFunctionPointer(Engine.GetProcAddress(handle, "?g_CreatePath@@YAXPBD@Z"), GetType(g_CreatePath1)), g_CreatePath1)



            CreatPath(TextBox1.Text)



            'Giải phóng DLL ra khỏi bộ nhớ
            If handle <> IntPtr.Zero Then
                Engine.FreeLibrary(handle)
            End If

            MessageBox.Show("Ok")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
