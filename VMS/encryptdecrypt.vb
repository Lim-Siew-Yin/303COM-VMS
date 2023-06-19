Imports System.Security.Cryptography
Public Class encryptdecrypt
    Private tripleDes As New TripleDESCryptoServiceProvider

    Private Function truncateHas(ByVal key As String, ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ReDim Preserve hash(length - 1)
        Return hash

    End Function

    Sub New(ByVal key As String)

        tripleDes.Key = truncateHas(key, tripleDes.KeySize \ 8)
        tripleDes.IV = truncateHas("", tripleDes.BlockSize \ 8)

    End Sub

    Public Function encryptData(ByVal plaintext As String) As String

        Dim plaintextByte() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim encSteam As New CryptoStream(ms, tripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        encSteam.Write(plaintextByte, 0, plaintextByte.Length)
        encSteam.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)

    End Function


End Class
