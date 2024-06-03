Namespace VistaSiteMgr

    Module General

    
        Public Sub RaiseException(ByVal e As Exception)

            'first log to the event log
            If (Not System.Diagnostics.EventLog.SourceExists("VistaSiteMgr")) Then
                System.Diagnostics.EventLog.CreateEventSource("VistaSiteMgr", "VistaSitMgrLog")
            End If

            Dim Log As System.Diagnostics.EventLog
            log = New System.Diagnostics.EventLog
            log.Source = "VistaSiteMgr"
            log.WriteEntry(e.ToString, System.Diagnostics.EventLogEntryType.Error)

            'then, throw the error
            Throw New ArgumentException(e.ToString)
        End Sub
    End Module
End Namespace
