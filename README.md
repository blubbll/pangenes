# pangenes

since pangenesisgame.net is semi-ded, let's crack the protocol (kind of)!

(the username is stored in /gamedir/config.txt in <username>XXX</username>)
tools i used:

- web debugging
- hex editor (lol)

tried to login to the webserver
let formData = new FormData();
formData.append('name', 'Blubbll');
formData.append('pass', '');

fetch("https://pangenesisgame.com/login/login.php", {method: "POST", body: FormData}).then(res => res.text()).then(text => console.log(text))

but it says
no,0 

current stati:
-  no,0 = could not log in
-  no,1 = invalid username
-  no,2 = your user account does nto have permission to log in
-  no,3 = A New version is available. Update now (this is interesting lol, clicking ok removes your username from the config kek)
-  no,4 = Too many bad logins. Please visit bensgames.net/alpha (the fuq)
-  no, 5+ : same as 0

Findings:
- to play offline from the login menu, at 009CB422 jz, jump to 009CB436 instead of 009CB424
- to force the "multiplayer" button to be clickable, at 009C1C4E jz, jump to 009C1C50 instead of 009C1C78
- to forcejoin the multiplayer server, at 009CE3D7 jz, jump to 009CE3D9 instead of 009CE40A