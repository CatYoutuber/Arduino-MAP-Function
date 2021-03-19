Class WMath
    Sub map(x As Long, in_min As Long, in_max As Long, out_min As Long, out_max As Long)
        Return (x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min
    End Sub
End Class