'PhishReporter Outlook Add-In is an Outlook Add-In to Report Phishing emails to specific email addresses
'Copyright (C) 2015  Josh Rickard
'
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License.
'
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with this program.  If not, see <http://www.gnu.org/licenses/>


Public Class ThisAddIn

    Private WithEvents inspectors As Outlook.Inspectors

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        inspectors = Me.Application.Inspectors
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown

    End Sub

End Class
