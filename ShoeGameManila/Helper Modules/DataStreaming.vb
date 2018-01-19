Imports System.IO

Module DataStreaming
    Public Function GetImageDataFromPictureBox(ByVal piktyurBox As PictureBox) As Byte()
        Dim ms As New MemoryStream
        piktyurBox.Image.Save(ms, piktyurBox.Image.RawFormat)
        Dim data As Byte() = ms.GetBuffer()
        Return data
    End Function
End Module
