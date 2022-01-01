Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Security.Cryptography
Imports System.Text
Module KeyGenerator
    Public Function GetUniqueKey(ByVal maxSize As Integer) As String
        Dim chArray As Char() = New Char(&H5E - 3) {}
      
        If Form1.RadioButton1.Checked Then
            chArray = "는თ하ა로ა모ა성로새하ლ를지文怎么说天涯问答外语频道余ა를예ნ을예ქც로하을ე돈华份价延伐伏乓传伟丢先肉年".ToCharArray
        End If
        If Form1.RadioButton2.Checked Then
            chArray = Conversions.ToCharArrayRankOne("האםאתאנעיםמאדנימהשלומהפירושהמילההזובאנגליתמךבןשלשיםושלאתהשמשלומךר")
        End If
        If Form1.RadioButton6.Checked Then
            chArray = Conversions.ToCharArrayRankOne("AraCrTusEcRtCyBuBiNmOiAqWasbsdjvgdksFSFGHCNHshKSHGJgshVHVShvghscgHCKNMBMNMVN")
        End If
        If Form1.RadioButton7.Checked Then
            chArray = Conversions.ToCharArrayRankOne("أاآلآفغثفارسيتؤتسرئسئسيصثضيفغثقعقخدحجبحخلطكمكبلبظوزرةلاىلارة")
        End If
        Dim data As Byte() = New Byte(10 - 4) {}
        Dim provider As New RNGCryptoServiceProvider
        provider.GetNonZeroBytes(data)
        data = New Byte(((maxSize - 6) + 5) - 4) {}
        provider.GetNonZeroBytes(data)
        Dim builder As New StringBuilder(maxSize)
        Dim num As Byte
        For Each num In data
            builder.Append(chArray((num Mod chArray.Length)))
        Next
        Return builder.ToString
    End Function
End Module
