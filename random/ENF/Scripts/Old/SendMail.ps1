Param(
      [string]$toName
     )

. .\Variables.ps1

$searcherFrom = ([adsisearcher]"samaccountname=$env:USERNAME")
$fromName = $searcherFrom.FindOne().Properties.name
$fromAddr = $searcherFrom.FindOne().Properties.mail

if (-not $toName) { $toName = $fromName }

$searcherTo = ([adsisearcher]"name=$toName") 
#$toName = $searcherTo.FindOne().Properties.name
$toAddr = $searcherTo.FindOne().Properties.mail

$subject = "Test email from powershell script with multiple attachments"

$bodyMsg  = @"
This is a test of sending emails via Powershell V2.
It uses AD to find name and email for you.
It inclues having multple attachments.
Thus begins my start or reign under my evil command... I mean, ENF Monitoring Suite (Patent Pending).

SMTP server removed so no one else abuses it. Luckly, I can compile to EXE when I distribute. Just no parameters though...
"@

$attch  = @();
$attch += "$ENFDir\ENF Triage\TriageList.txt"
#$attch += "$ENFDir\SendMail.ps1.txt"

Send-MailMessage   `
 -to $toAddr   `
 -from  $fromAddr  `
 -subject $subject   `
 -body $bodyMsg   `
 -SmtpServer $smtpSrv  `
 -Attachments $attch
