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
Public Class PhishReporterConfig
    ' Report Configuration
    Public Shared Property SecurityTeamEmailAlias As String = "securityteam@example.com"
    Public Shared Property ReportEmailSubject As String = "[PhishReporter] Phishing Email Report"
    ' Link to the security team's runbook for handling phishing emails. If the variable is empty or not defined, defaults to a simplified message"
    Public Shared Property RunbookURL As String = "https://corporatewiki/path/to/runbook"

    ' Ribbon Group Config
    Public Shared Property RibbonGroupName As String = "Report Security Issues"

    ' Button Config
    Public Shared Property ButtonName As String = "Report Phishing"
    Public Shared Property ButtonHoverDescription As String = "Report a suspicious email to the $COMPANY Information Security Team."
    Public Shared Property ButtonScreenTip As String = "Report phishing emails"
    Public Shared Property ButtonSuperTip As String = "Use this button to report suspicious emails to the $COMPANY Information Security team."

End Class

